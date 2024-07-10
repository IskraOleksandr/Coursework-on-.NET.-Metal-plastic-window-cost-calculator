using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_plastic_window_cost_calculator.Views
{
    public interface IWindow_Calculator_View
    {
        event EventHandler<EventArgs> ShowPetView;
        event EventHandler<EventArgs> ShowAdmDbView;

        void hide_button();
    }
}
