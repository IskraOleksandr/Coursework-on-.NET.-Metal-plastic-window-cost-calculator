using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metal_plastic_window_cost_calculator.Models;
using Metal_plastic_window_cost_calculator.Repository;
using Metal_plastic_window_cost_calculator.Views;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.ApplicationServices;

namespace Metal_plastic_window_cost_calculator.Presenters
{
    internal class Window_CalcPresenter
    {
        private readonly Models.User _user;
        private readonly IRepository _repository;
        private readonly IWindow_Calc_Log_View _ViewLog;

        public Window_CalcPresenter(Models.User user, IRepository context, IWindow_Calc_Log_View view)
        {
            _user = user;
            _repository = context;
            _ViewLog = view;

            _ViewLog.login += new EventHandler<EventArgs>(OnLogin);
            _ViewLog.register += new EventHandler<EventArgs>(OnRegister);
            _ViewLog.register_validation += new EventHandler<EventArgs>(onValidation);

        }


        public async void onValidation(object? sender, EventArgs e)
        {
            _user.FullName = _ViewLog.FullName;
            _user.Email = _ViewLog.Email;
            _user.IsAdmin = _ViewLog.IsAdmin;
            _user.Login = _ViewLog.Login;
            _user.Password = _ViewLog.Password;

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
                _ViewLog.Error_Login = "Не коректная длина логина";
            }

            if (users_t.ToList().Count != 0)
            {
                _ViewLog.Error_Login = "Логин занят";
            }
            else _ViewLog.Error_Login = "";
        }





        public async void OnRegister(object? sender, EventArgs e)
        {
            _user.FullName = _ViewLog.FullName;
            _user.Email = _ViewLog.Email;
            _user.IsAdmin = _ViewLog.IsAdmin;

            _user.Login = _ViewLog.Login;
            _user.Password = _ViewLog.Password;

            await _repository.AddUser(_user);
            await _repository.Save();

            _ViewLog.LetUserLogin();
        }

        public async void OnLogin(object? sender, EventArgs e)
        {
            _user.Login = _ViewLog.Login;
            _user.Password = _ViewLog.Password;

            var users = await _repository.GetUsers();

            if (users.Count == 0)
            {
                _ViewLog.LetUserLogin();
            }
            else
            {
                var users_t = users.Where(a => a.Login == _user.Login);
                if (users_t.ToList().Count != 0)
                {
                    _ViewLog.OpenMainForm();
                    //_View.show_menu();
                    //_View.LetLogin();
                    //_View.Login = "text";
                }
                else _ViewLog.LetUserLogin();
            }


        }
    }
}
