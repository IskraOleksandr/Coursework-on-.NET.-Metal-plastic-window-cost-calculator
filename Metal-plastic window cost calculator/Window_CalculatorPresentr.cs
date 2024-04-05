using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metal_plastic_window_cost_calculator.Models;
using Metal_plastic_window_cost_calculator.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.ApplicationServices;

namespace Metal_plastic_window_cost_calculator
{
    internal class Window_CalculatorPresenter
    {
        private readonly Models.User _user;
        private readonly IRepository _repository;
        private readonly IWindow_Calculator_View _View;

        public Window_CalculatorPresenter(Models.User user, IRepository context, IWindow_Calculator_View view)
        {
            this._user = user;
            this._repository = context;
            this._View = view;

            _View.login += new EventHandler<EventArgs>(OnLogin);
            _View.register += new EventHandler<EventArgs>(OnRegister);
            _View.register_validation += new EventHandler<EventArgs>(onValidation);
            _View.show_materials += new EventHandler<EventArgs>(test);
            _View.get_material_desc += new EventHandler<EventArgs>(test2);
        }

        public async void test(object? sender, EventArgs e)
        {
            _View.ListView.Items.Clear();
            var materials = await _repository.GetMaterials();
            foreach (var material in materials)
            {

                _View.ListView.Items.Add(
                 new ListViewItem(new string[] { material.Id.ToString(), material.Category, material.Name, material.Color, material.CostPerMeter.ToString(), material.Description })
                    );
            }

        }

        public async void test2(object? sender, EventArgs e)
        {
            string str = sender as string;
            int id = Convert.ToInt32(str);
            var material = await _repository.GetMaterial(id);
            _View.LabelDescription = material.Description;

        }

        public async void onValidation(object? sender, EventArgs e)
        {
            _user.FullName = _View.FullName;
            _user.Email = _View.Email;
            _user.IsAdmin = _View.IsAdmin;
            _user.Login = _View.Login;
            _user.Password = _View.Password;

            var users = await _repository.GetUsers();

            if (users.Count == 0)
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
            _user.FullName = _View.FullName;
            _user.Email = _View.Email;
            _user.IsAdmin = _View.IsAdmin;

            _user.Login = _View.Login;
            _user.Password = _View.Password;

            await _repository.AddUser(_user);
            await _repository.Save();

            _View.LetUserLogin();
        }

        public async void OnLogin(object? sender, EventArgs e)
        {
            _user.Login = _View.Login;
            _user.Password = _View.Password;

            var users = await _repository.GetUsers();

            if (users.Count == 0)
            {
                _View.LetUserLogin();
            }
            else
            {
                var users_t = users.Where(a => a.Login == _user.Login);
                if (users_t.ToList().Count != 0)
                {
                    _View.show_menu();
                    //_View.LetLogin();
                    //_View.Login = "text";
                }
                else _View.LetUserLogin();
            }


        }
    }
}
