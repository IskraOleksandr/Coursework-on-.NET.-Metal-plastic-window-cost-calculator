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
            {//                                               Password = Admin
                UsersTable.Add(new User { FullName = "Admin", Login = "Admin", Email = "admin@gmail.com", Password = "0B2FFE4FAE90F11F26F4223C2FDC95BB", Salt = "3CFD6F6D6ECA8B1F7037082D46788621", IsAdmin = true });

                MaterialsTable.Add(new Materials { Category = "Glass", Name = "Glass", Color = "Transparent", CostPerMeter = 30, Description = "Regular glass" });
                MaterialsTable.Add(new Materials { Category = "Frame", Name = "Plastic", Color = "White", CostPerMeter = 25, Description = "White plastic frame" });
                MaterialsTable.Add(new Materials { Category = "Frame", Name = "Tree", Color = "Brown", CostPerMeter = 10, Description = "Wooden frame" });
                MaterialsTable.Add(new Materials { Category = "Glass", Name = "Glass 2", Color = "Transparent", CostPerMeter = 60, Description = "Double glass" });
                MaterialsTable.Add(new Materials { Category = "Glass", Name = "Dark glass", Color = "Black", CostPerMeter = 45, Description = "Tinted glass" });
                MaterialsTable.Add(new Materials { Category = "Glass", Name = "Dark glass 2", Color = "Black", CostPerMeter = 90, Description = "Double tinted glass" });
                MaterialsTable.Add(new Materials { Category = "Section", Name = "Plastic", Color = "White", CostPerMeter = 5, Description = "White plastic section" });
                MaterialsTable.Add(new Materials { Category = "Section", Name = "Plastic", Color = "Black", CostPerMeter = 7, Description = "Black plastic section" });
                MaterialsTable.Add(new Materials { Category = "Section", Name = "Tree", Color = "Brown", CostPerMeter = 3, Description = "Wooden section" });
                MaterialsTable.Add(new Materials { Category = "Sill", Name = "Plastic", Color = "White", CostPerMeter = 10, Description = "White window sill" });
                MaterialsTable.Add(new Materials { Category = "Sill", Name = "Plastic", Color = "Black", CostPerMeter = 20, Description = "Black window sill" });
                MaterialsTable.Add(new Materials { Category = "Sill", Name = "Tree", Color = "Brown", CostPerMeter = 30, Description = "Wooden window sill" });
                MaterialsTable.Add(new Materials { Category = "Section", Name = "Plastic", Color = "White", CostPerMeter = 10, Description = "White plastic opening section" });
                MaterialsTable.Add(new Materials { Category = "Section", Name = "Plastic", Color = "Black", CostPerMeter = 14, Description = "Black plastic opening section" });
                MaterialsTable.Add(new Materials { Category = "Section", Name = "Tree", Color = "Brown", CostPerMeter = 6, Description = "Wooden opening section" });
                MaterialsTable.Add(new Materials { Category = "Furniture", Name = "Plastic", Color = "White", CostPerMeter = 3, Description = "Plastic white handles" });
                MaterialsTable.Add(new Materials { Category = "Furniture", Name = "Plastic", Color = "Black", CostPerMeter = 6, Description = "Plastic black handles" });
                MaterialsTable.Add(new Materials { Category = "Furniture", Name = "Steel", Color = "Metallic", CostPerMeter = 10, Description = "Metal handles" });
                MaterialsTable.Add(new Materials { Category = "Furniture", Name = "Steel", Color = "Metallic", CostPerMeter = 13, Description = "Metallic handles" });
                SaveChanges();
            }
        }
       
        public virtual DbSet<User> UsersTable { get; set; }
        public virtual DbSet<Materials> MaterialsTable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            optionsBuilder.UseSqlServer("Server=DESKTOP-4SUHQ4F;Database=WindowCalculator_f1;Integrated Security=SSPI;TrustServerCertificate=true");
        }

    }
}
