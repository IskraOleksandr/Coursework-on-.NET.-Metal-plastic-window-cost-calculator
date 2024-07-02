using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_plastic_window_cost_calculator.Views
{
    public interface IWindow_Calculator_View//mainView
    {
        event EventHandler<EventArgs> ShowPetView;
        event EventHandler<EventArgs> ShowAdmDbView;
        //string LabelDescription { set; }
        //ListView ListView { get; set; }

        


        //event EventHandler<EventArgs> get_material_desc;



        //event EventHandler<EventArgs> show_materials;



        //void show_menu();
    }
}
