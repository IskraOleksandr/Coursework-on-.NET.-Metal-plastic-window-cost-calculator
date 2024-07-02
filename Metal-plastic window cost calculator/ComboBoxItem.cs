using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_plastic_window_cost_calculator
{
    public class ComboBoxItem
    {
        public string Id { get; set; }
        public string Text { get; set; }


        public override string ToString()
        {
            return Text;
        }
    }

}
