﻿using System;
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
                SaveChanges();
            }
        }
        public Window_CalculatorContext(DbContextOptions<Window_CalculatorContext> options) : base(options)
        {

        }
        public virtual DbSet<User> UsersTable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-4SUHQ4F;Database=WindowCalculator;Integrated Security=SSPI;TrustServerCertificate=true");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Users_T__3214EC07934EC078");

                entity.ToTable("Users_Table");

                entity.Property(e => e.IsAdmin).HasMaxLength(80);
                entity.Property(e => e.FullName)
                    .HasMaxLength(80)
                    .HasColumnName("Full_Name");
                entity.Property(e => e.Login)
                    .HasMaxLength(40)
                    .HasColumnName("Login");
                entity.Property(e => e.Password)
                    .HasMaxLength(80)
                    .HasColumnName("Password");
                entity.Property(e => e.IsAdmin);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}