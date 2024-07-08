using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_plastic_window_cost_calculator.Models
{
    public interface IMaterials
    {
        int Id { get; set; }
        string Category { get; set; }
        string Name { get; set; }
        string Color { get; set; }
        int CostPerMeter { get; set; }
        string Description { get; set; }
    }
}
