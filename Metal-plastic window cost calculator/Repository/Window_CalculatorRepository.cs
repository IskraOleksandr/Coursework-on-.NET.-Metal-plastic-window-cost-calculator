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


        public async Task<List<Materials>> SearchMaterial(string id, string sort_type)
        {
            var mat = await _context.MaterialsTable.Where(m => m.Category == id).OrderBy(m => m.CostPerMeter).ToListAsync();
            return mat;
        }
        public List<Materials> SearchMaterial1(string searchIn, string searchValue, string sortOrder, string sortBy)
        {
            IQueryable<Materials> query = MaterialsWhere(searchIn,searchValue);//_context.MaterialsTable.Where(m => m.Category.Contains("Frame"));

            switch (sortOrder)
            {
                case "ASC":
                    query = MaterialsSortByAsc(query, sortBy);
                    break;
                case "DESC":
                    query = MaterialsSortByDesc(query, sortBy);
                    break;
            }


            return query.ToList();
        }

        private IQueryable<Materials> MaterialsWhere(string searchIn, string searchValue)
        {
            IQueryable<Materials> query;

            switch (searchIn)
            {
                case "Category":
                    query = _context.MaterialsTable.Where(m => m.Category.Contains(searchValue));
                    break;
                case "Name":
                    query = _context.MaterialsTable.Where(m => m.Name.Contains(searchValue));
                    break;
                case "Color":
                    query = _context.MaterialsTable.Where(m => m.Color.Contains(searchValue));
                    break;
                case "CostPerMeter":
                    query = _context.MaterialsTable.Where(m => m.CostPerMeter == Convert.ToInt32(searchValue));
                    break;
                default:
                    query = _context.MaterialsTable.Where(m => m.Id == Convert.ToInt32(searchValue));
                    break;
            }
            return query;
        }

        private IQueryable<Materials> MaterialsSortByAsc(IQueryable<Materials> query, string sortBy)
        {
            switch (sortBy)
            {
                case "Category":
                    query = _context.MaterialsTable.OrderBy(m => m.Category);
                    break;
                case "Name":
                    query = _context.MaterialsTable.OrderBy(m => m.Name);
                    break;
                case "Color":
                    query = _context.MaterialsTable.OrderBy(m => m.Color);
                    break;
                case "CostPerMeter":
                    query = _context.MaterialsTable.OrderBy(m => m.CostPerMeter);
                    break;
                default:
                    query = _context.MaterialsTable.OrderBy(m => m.Id);
                    break;
            }

            return query;
        }

        private IQueryable<Materials> MaterialsSortByDesc(IQueryable<Materials> query, string sortBy)
        {
            switch (sortBy)
            {
                case "Category":
                    query = _context.MaterialsTable.OrderByDescending(m => m.Category);
                    break;
                case "Name":
                    query = _context.MaterialsTable.OrderByDescending(m => m.Name);
                    break;
                case "Color":
                    query = _context.MaterialsTable.OrderByDescending(m => m.Color);
                    break;
                case "CostPerMeter":
                    query = _context.MaterialsTable.OrderByDescending(m => m.CostPerMeter);
                    break;
                default:
                    query = _context.MaterialsTable.OrderByDescending(m => m.Id);
                    break;
            }

            return query;
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
        public IEnumerable<Materials> GetIEnumerableMaterials()
        {
            var materials = _context.MaterialsTable.ToList();
            return materials;
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
