using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metal_plastic_window_cost_calculator.Models;

namespace Metal_plastic_window_cost_calculator.Repository
{
    public interface IRepository
    {
        Task Save();

        Task<List<User>> GetUsers();

        Task AddUser(User user);

        Task<Materials> GetMaterial(int id);

        List<Materials> SearchMaterial1(string searchIn, string searchValue, string sortOrder, string sortBy);

        Task<List<Materials>> GetMaterials();

        IEnumerable<Materials> GetIEnumerableMaterials();

        Task AddMaterial(Materials material);
    }
}
