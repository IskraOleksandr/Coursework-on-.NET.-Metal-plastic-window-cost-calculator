using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_plastic_window_cost_calculator.Views
{
    public interface IWindow_Calc_Log_View
    {
        string FullName { get; set; }
        string Email { get; set; }
        bool IsAdmin { get; set; }
        //
        string Login { get; set; }
        string Error_Login { set; }

        string Password { get; set; }


        event EventHandler<EventArgs> login;
        event EventHandler<EventArgs> register;
        event EventHandler<EventArgs> register_validation;

        void LetUserLogin();
        void LetLogin();
        void OpenMainForm();
    }
}
