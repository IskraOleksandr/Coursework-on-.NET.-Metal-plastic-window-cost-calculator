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
        }

        private async void onValidation(object? sender, EventArgs e)
        {
            _user.FullName = _View.FullName;
            _user.Email = _View.Email;
            _user.IsAdmin = _View.IsAdmin;
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
                    _View.LetUserLogin();
                    
                }
            }


        }

        private async void OnRegister(object? sender, EventArgs e)
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

        private async void OnLogin(object? sender, EventArgs e)
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
                    _View.LetLogin();
                    _View.Login = "text";
                }else _View.LetUserLogin();
            }

            
        }
    }
}
