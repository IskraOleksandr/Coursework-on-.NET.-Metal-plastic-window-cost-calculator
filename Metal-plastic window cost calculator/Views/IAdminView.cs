using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_plastic_window_cost_calculator.Views
{
    public interface IAdminView
    {
        void SetMaterialsListBindingSource(BindingSource petList);
        void Show();//Optional
    }
}
