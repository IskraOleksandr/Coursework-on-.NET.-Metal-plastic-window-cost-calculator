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
        string Error_Login { set; }
      
        string Password { get; set; }

        string LabelDescription { set; }
        ListView ListView { get; set; }
        event EventHandler<EventArgs> get_material_desc;


        event EventHandler<EventArgs> login;
        event EventHandler<EventArgs> register;
        event EventHandler<EventArgs> register_validation;
        event EventHandler<EventArgs> show_materials;

        void LetUserLogin();
        void LetLogin();

        void show_menu();
    }
}
