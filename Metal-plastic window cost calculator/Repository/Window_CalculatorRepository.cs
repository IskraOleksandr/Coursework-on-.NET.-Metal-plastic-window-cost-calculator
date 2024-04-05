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
        public async Task<Materials> GetMaterial(int id)
        {
            return await _context.MaterialsTable.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task AddMaterial(Materials materials)
        {
            await _context.MaterialsTable.AddAsync(materials);
        }

        public async Task<List<Materials>> GetMaterials()
        {
            var materials = await _context.MaterialsTable.ToListAsync();
            return materials;
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
