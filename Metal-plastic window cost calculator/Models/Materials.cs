using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_plastic_window_cost_calculator.Models
{
    public class Materials
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int CostPerMeter { get; set; }
        public string Description { get; set; }
    }
}
