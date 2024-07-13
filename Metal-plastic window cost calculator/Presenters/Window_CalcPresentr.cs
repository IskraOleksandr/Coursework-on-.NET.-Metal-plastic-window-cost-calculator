using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Metal_plastic_window_cost_calculator.Models;
using Metal_plastic_window_cost_calculator.Views;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.ApplicationServices;

namespace Metal_plastic_window_cost_calculator.Presenters
{
    internal class Window_CalcPresenter
    {
        private readonly Models.User _user;
        private readonly Window_CalculatorContext _context;
        private readonly IWindow_Calculator_View _view;
        private readonly IWindow_Calc_Log_View _View;

        public Window_CalcPresenter(Window_CalculatorContext context, IWindow_Calc_Log_View view, IWindow_Calculator_View view1)
        {
            _context = context;
            _View = view;
            _view = view1;
            _user = new Models.User();

            _view.ShowPetView += new EventHandler<EventArgs>(ShowMaterialssView);
            _view.ShowAdmDbView += new EventHandler<EventArgs>(ShowAdminView);
            _view.ShowBuyWindowView += new EventHandler<EventArgs>(ShowBuyWindowView);

            _View.login += new EventHandler<EventArgs>(OnLoginX);
            _View.register += new EventHandler<EventArgs>(OnRegister);

        }



        public async void OnRegister(object? sender, EventArgs e)
        {
            byte[] saltbuf = new byte[16];

            RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
            randomNumberGenerator.GetBytes(saltbuf);

            StringBuilder sb = new StringBuilder(16);
            for (int i = 0; i < 16; i++)
                sb.Append(string.Format("{0:X2}", saltbuf[i]));
            string salt = sb.ToString();

            byte[] password = Encoding.Unicode.GetBytes(salt + _View.Password);//переводим пароль в байт-массив  

            var md5 = MD5.Create();//создаем объект для получения средств шифрования  

            byte[] byteHash = md5.ComputeHash(password);//вычисляем хеш-представление в байтах  

            StringBuilder hash = new StringBuilder(byteHash.Length);
            for (int i = 0; i < byteHash.Length; i++)
                hash.Append(string.Format("{0:X2}", byteHash[i]));

            var user = new Models.User
            {
                FullName = _View.FullName,
                Login = _View.Login,
                Password = hash.ToString(),
                Salt = salt,
                Email = _View.Email,
                IsAdmin = false,
            };
            _context.UsersTable.Add(user);

            //_View.LetUserLogin();
        }
        public async void OnLoginX(object? sender, EventArgs e)
        {
            _user.Login = _View.Login;
            _user.Password = _View.Password;

            var query = from b in _context.UsersTable select b;
            var users = query.ToList();

            if (users.Count == 0)
            {
                _View.LetUserLogin();
            }
            else
            {
                var users_t = users.Where(a => a.Login == _user.Login);
                var user = users_t.First();
                string? salt = user.Salt;

                byte[] password = Encoding.Unicode.GetBytes(salt + _user.Password);//переводим пароль в байт-массив  

                var md5 = MD5.Create();//создаем объект для получения средств шифрования  

                byte[] byteHash = md5.ComputeHash(password);//вычисляем хеш-представление в байтах  

                StringBuilder hash = new StringBuilder(byteHash.Length);
                for (int i = 0; i < byteHash.Length; i++)
                    hash.Append(string.Format("{0:X2}", byteHash[i]));
                if (user.Password != hash.ToString())
                {
                    _View.LetUserLogin();
                }

                if (user.IsAdmin == true)
                {
                    _View.OpenMainForm(true);
                }
                else
                {
                    _View.OpenMainForm(false);
                }
            }
        }
        public async void OnLogin(object? sender, EventArgs e)
        {
            _user.Login = _View.Login;
            _user.Password = _View.Password;

            var query = from b in _context.UsersTable select b;
            var users = query.ToList();

            if (users.Count == 0)
            {
                _View.LetUserLogin();
            }
            else
            {
                var users_t = users.Where(a => a.Login == _user.Login);
                if (users_t.ToList().Count != 0)
                {

                    if (users_t.ToList()[0].IsAdmin == true)
                    {
                        _View.OpenMainForm(true);
                    }
                    else
                    {
                        _View.OpenMainForm(false);
                    }
                }
                else _View.LetUserLogin();
            }
        }


        private void ShowMaterialssView(object sender, EventArgs e)
        {
            IMaterialsView view = Materials_Form.GetInstace((Form1)_view);
            Window_CalculatorContext context = new Window_CalculatorContext();
            MaterialsPresenter presenter = new MaterialsPresenter(view, context);//
        }

        private void ShowAdminView(object sender, EventArgs e)
        {
            IAdminView view = Admin_Form.GetInstace((Form1)_view);
            Window_CalculatorContext context = new Window_CalculatorContext();
            AdminMaterialsPresenter presenter = new AdminMaterialsPresenter(view, context);//
        }

        private void ShowBuyWindowView(object sender, EventArgs e)
        {
            IBuyWindowView view = FormBuyWindow.GetInstace((Form1)_view);
            Window_CalculatorContext context = new Window_CalculatorContext();
            BuyWindowPresenter presenter = new BuyWindowPresenter(context, view);

        }
    }
}
