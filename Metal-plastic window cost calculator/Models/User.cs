using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_plastic_window_cost_calculator.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }

        public string? Email { get; set; }

        public bool IsAdmin { get; set; }
    }
}
