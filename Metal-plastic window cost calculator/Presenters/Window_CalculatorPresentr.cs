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
    internal class Window_CalculatorPresenter
    {
        private readonly Models.User _user;
        private readonly IRepository _repository;
        private readonly IWindow_Calculator_View _View;
        //private readonly IWindow_Calc_Log_View _ViewLog;

        public Window_CalculatorPresenter(IRepository context, IWindow_Calculator_View view)
        {
            //this._user = user;
            _repository = context;
            _View = view;


            //_ViewLog.login += new EventHandler<EventArgs>(OnLogin);
            //_ViewLog.register += new EventHandler<EventArgs>(OnRegister);
            //_ViewLog.register_validation += new EventHandler<EventArgs>(onValidation);
            _View.show_materials += new EventHandler<EventArgs>(test);//test2
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

        //public async void onValidation(object? sender, EventArgs e)
        //{
        //    _user.FullName = _ViewLog.FullName;
        //    _user.Email = _ViewLog.Email;
        //    _user.IsAdmin = _ViewLog.IsAdmin;
        //    _user.Login = _ViewLog.Login;
        //    _user.Password = _ViewLog.Password;

        //    var users = await _repository.GetUsers();

        //    if (users.Count == 0)
        //    {
        //        //_View.LetUserLogin();
        //    }
        //    else
        //    {
        //        Check_Login(users);
        //        //var users_t = users.Where(a => a.Login == _user.Login);
        //        //if (users_t.ToList().Count != 0)
        //        //{
        //        //    _View.Error_Login = "Логин занят";
        //        //}
        //        //else _View.Error_Login = "";
        //    }
        //}

        //public void Check_Login(List<Models.User> users)
        //{
        //    var users_t = users.Where(a => a.Login == _user.Login);

        //    if (_user.Login.Trim().Length <= 3 && _user.Login.Trim().Length > 15)
        //    {
        //        _ViewLog.Error_Login = "Не коректная длина логина";
        //    }

        //    if (users_t.ToList().Count != 0)
        //    {
        //        _ViewLog.Error_Login = "Логин занят";
        //    }
        //    else _ViewLog.Error_Login = "";
        //}





        //public async void OnRegister(object? sender, EventArgs e)
        //{
        //    _user.FullName = _ViewLog.FullName;
        //    _user.Email = _ViewLog.Email;
        //    _user.IsAdmin = _ViewLog.IsAdmin;

        //    _user.Login = _ViewLog.Login;
        //    _user.Password = _ViewLog.Password;

        //    await _repository.AddUser(_user);
        //    await _repository.Save();

        //    _ViewLog.LetUserLogin();
        //}

        //public async void OnLogin(object? sender, EventArgs e)
        //{
        //    _user.Login = _ViewLog.Login;
        //    _user.Password = _ViewLog.Password;

        //    var users = await _repository.GetUsers();

        //    if (users.Count == 0)
        //    {
        //        _ViewLog.LetUserLogin();
        //    }
        //    else
        //    {
        //        var users_t = users.Where(a => a.Login == _user.Login);
        //        if (users_t.ToList().Count != 0)
        //        {
        //            _ViewLog.OpenMainForm();
        //            //_View.show_menu();
        //            //_View.LetLogin();
        //            //_View.Login = "text";
        //        }
        //        else _ViewLog.LetUserLogin();
        //    }


        //}
    }
}
