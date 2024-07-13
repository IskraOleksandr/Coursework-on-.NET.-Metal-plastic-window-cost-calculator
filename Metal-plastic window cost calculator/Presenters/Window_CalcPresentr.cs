using System;
using System.Collections.Generic;
using System.Linq;
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

            _View.login += new EventHandler<EventArgs>(OnLogin);
            _View.register += new EventHandler<EventArgs>(OnRegister);
            _View.register_validation += new EventHandler<EventArgs>(onValidation);

        }


        public async void onValidation(object? sender, EventArgs e)
        {
            _user.FullName = _View.FullName;
            _user.Email = _View.Email;
            //_user.IsAdmin = _ViewLog.IsAdmin;
            _user.Login = _View.Login;
            _user.Password = _View.Password;

            var query = from b in _context.UsersTable select b;
            var users = query.ToList();

            if (users.Count() == 0)
            {
                //_View.LetUserLogin();
            }
            else
            {
                Check_Login(users);
                //var users_t = users.Where(a => a.Login == _user.Login);
                //if (users_t.ToList().Count != 0)
                //{
                //    _View.Error_Login = "Логин занят";
                //}
                //else _View.Error_Login = "";
            }
        }

        public void Check_Login(List<Models.User> users)
        {
            var users_t = users.Where(a => a.Login == _user.Login);

            if (_user.Login.Trim().Length <= 3 && _user.Login.Trim().Length > 15)
            {
                _View.Error_Login = "Не коректная длина логина";
            }

            if (users_t.ToList().Count != 0)
            {
                _View.Error_Login = "Логин занят";
            }
            else _View.Error_Login = "";
        }





        public async void OnRegister(object? sender, EventArgs e)
        {
            //_user.FullName = _ViewLog.FullName;
            //_user.Email = _ViewLog.Email;

            //_user.Login = _ViewLog.Login;
            //_user.Password = _ViewLog.Password;

            //await _repository.AddUser(_user);
            //await _repository.Save();

            var user = new Models.User
            {
                FullName = _View.FullName,
                Login = _View.Login,
                Password = _View.Password,
                Email = _View.Email,
                IsAdmin = false,
            };
            _context.UsersTable.Add(user);

            _View.LetUserLogin();
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
            new MaterialsPresenter(view, context);//
        }

        private void ShowAdminView(object sender, EventArgs e)
        {
            IAdminView view = Admin_Form.GetInstace((Form1)_view);
            Window_CalculatorContext context = new Window_CalculatorContext();
            new AdminMaterialsPresenter(view, context);//
        }

        private void ShowBuyWindowView(object sender, EventArgs e)
        {
            IBuyWindowView view = FormBuyWindow.GetInstace((Form1)_view);
            Window_CalculatorContext context = new Window_CalculatorContext();
            new BuyWindowPresenter(context, view);
            
        }
    }
}
