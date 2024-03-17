using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_plastic_window_cost_calculator
{
    public interface IWindow_Calculator_View
    {
        string FullName { get; set; }
        string Email { get; set; }
        bool IsAdmin { get; set; }
        //
        string Login { get; set; }
        string Password { get; set; }

        event EventHandler<EventArgs> login;
        event EventHandler<EventArgs> register;
        event EventHandler<EventArgs> register_validation;
        void LetUserLogin();
        void LetLogin();
    }
}
