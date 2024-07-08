using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_plastic_window_cost_calculator.Views
{
    public interface IAddMaterialView
    {
        string Category { get; set; }
        string LabelError_Category { get; set; }

        string Name_ { get; set; }
        string LabelError_Name { get; set; }

        string Color_ { get; set; }
        string LabelError_Color { get; set; }

        int CostPerMeter { get; set; }
        string LabelError_CostPerMeter { get; set; }

        string Description { get; set; }
        string LabelError_Description { get; set; }


        event EventHandler<EventArgs> addMaterial;
        event EventHandler<EventArgs> editMaterial;

        event EventHandler<EventArgs> validation_filds;


        void enable_button(bool off_on_flag);
    }
}
