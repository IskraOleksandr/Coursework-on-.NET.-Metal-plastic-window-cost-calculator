using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_plastic_window_cost_calculator.Models
{
    public interface IUser
    {
        int Id { get; set; }
        string? FullName { get; set; }
        string? Login { get; set; }
        string? Password { get; set; }

        string? Email { get; set; }

        bool IsAdmin { get; set; }
    }
}
