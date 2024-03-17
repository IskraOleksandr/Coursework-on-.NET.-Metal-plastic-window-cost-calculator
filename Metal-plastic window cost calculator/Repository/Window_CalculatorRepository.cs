using Metal_plastic_window_cost_calculator.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_plastic_window_cost_calculator.Repository
{
    public class Window_CalculatorRepository : IRepository
    {
        private readonly Window_CalculatorContext _context;

        public Window_CalculatorRepository(Window_CalculatorContext context)
        {
            _context = context;
        }

        public async Task AddUser(User user)
        {
            await _context.UsersTable.AddAsync(user);
        }

        public async Task<List<User>> GetUsers()
        {
            var users = await _context.UsersTable.ToListAsync();
            return users;
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
