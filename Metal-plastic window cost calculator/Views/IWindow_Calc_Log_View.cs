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
        string Login { get; set; }

        string Password { get; set; }
        string PasswordConfirm { get; set; }

        string Email { get; set; }
        string Error_Login { set; }

        bool ButtonEnabled { get; set; }


        event EventHandler<EventArgs> login;
        event EventHandler<EventArgs> register;
        event EventHandler<EventArgs> register_validation;

        event EventHandler<EventArgs> ShowPetView;
        event EventHandler<EventArgs> ShowAdmDbView;

        void LetUserLogin();
        void OpenMainForm(bool flag);

        void ClearTextBoxs();
        void ChangeFormToLogin();
    }
}
