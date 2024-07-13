using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace Metal_plastic_window_cost_calculator.Models
{
    public partial class Window_CalculatorContext : DbContext
    {
        public Window_CalculatorContext()
        {
            if (Database.EnsureCreated())
            {
                UsersTable.Add(new User { FullName = "Admin", Login = "Admin", Email = "admin@gmail.com", Password = "0B2FFE4FAE90F11F26F4223C2FDC95BB", IsAdmin = true });

                MaterialsTable.Add(new Materials { Category = "Glass", Name = "Glass", Color = "White", CostPerMeter = 17, Description = "Пластамасовая рамка белого цвета" });
                MaterialsTable.Add(new Materials { Category = "Glass", Name = "Glass", Color = "White", CostPerMeter = 17, Description = "Пластамасовая рамка белого цвета" });
                MaterialsTable.Add(new Materials { Category = "Glass", Name = "Glass", Color = "White", CostPerMeter = 17, Description = "Пластамасовая рамка белого цвета" });
                SaveChanges();
            }
        }
       
        public virtual DbSet<User> UsersTable { get; set; }
        public virtual DbSet<Materials> MaterialsTable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            optionsBuilder.UseSqlServer("Server=DESKTOP-4SUHQ4F;Database=WindowCalculator_v2n1x;Integrated Security=SSPI;TrustServerCertificate=true");
        }

    }
}
