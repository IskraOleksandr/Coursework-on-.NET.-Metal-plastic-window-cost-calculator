using Metal_plastic_window_cost_calculator.Models;
using Metal_plastic_window_cost_calculator.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Metal_plastic_window_cost_calculator.Presenters
{
    public class AdminMaterialsPresenter
    {
        //Fields
        private IAdminView _View;

        private BindingSource materialsBindingSource;
        private IEnumerable<Materials> materialsList;
        private Window_CalculatorContext _context;

        //Constructor
        public AdminMaterialsPresenter(IAdminView view, Window_CalculatorContext repository)
        {
            this.materialsBindingSource = new BindingSource();
            this._View = view;
            this._context = repository;

            //Subscribe event handler methods to view events
            _View.load_combobox_items += new EventHandler<EventArgs>(LoadComboBox);
            _View.change_table += new EventHandler<EventArgs>(ChageTable);
            _View.SearchEvent += new EventHandler<EventArgs>(SearchItem);
            _View.SortEvent += new EventHandler<EventArgs>(SortMaterial);

            _View.add += new EventHandler<EventArgs>(Add);
            _View.edit += new EventHandler<EventArgs>(Edit);
            _View.delete += new EventHandler<EventArgs>(Delete);

            _View.addItemEvent += new EventHandler<EventArgs>(AddItem);
            _View.editItemEvent += new EventHandler<EventArgs>(EditItem);
            _View.deleteItemEvent += new EventHandler<EventArgs>(DeleteItem);


            this._View.SetMaterialsListBindingSource(materialsBindingSource);
            LoadAllItemsList();

            this._View.Show();
        }

        private void Add(object? sender, EventArgs e)
        {
            var selectedItem = (ComboBoxItem)_View.SelectedTable;

            if (selectedItem.Id == "MaterialsTable")
            {
                _View.OpenAddForms(true);
            }
            else if (selectedItem.Id == "UsersTable")
            {
                _View.OpenAddForms(false);
            }
        }

        private void Edit(object? sender, EventArgs e)
        {
            var selectedItem = (ComboBoxItem)_View.SelectedTable;

            if (selectedItem.Id == "MaterialsTable")
            {
                _View.OpenEditForms(true);
            }
            else if (selectedItem.Id == "UsersTable")
            {
                _View.OpenEditForms(false);
            }
        }
        private void Delete(object? sender, EventArgs e)
        {
            var selectedItem = (ComboBoxItem)_View.SelectedTable;

            if (selectedItem.Id == "MaterialsTable")
            {
                _View.OpenDeleteForms(true);
            }
            else if (selectedItem.Id == "UsersTable")
            {
                _View.OpenDeleteForms(false);
            }
        }
        private void AddItem(object? sender, EventArgs e)
        {
            string str = sender as string;
            if (str == "mat")
            {
                var authors = new Materials
                {
                    Category = _View.Category,
                    Name = _View.Name_,
                    Color = _View.Color_,
                    CostPerMeter = _View.CostPerMeter,
                    Description = _View.Description,
                };
                _context.MaterialsTable.Add(authors);
            }
            else if (str == "us")
            {
                byte[] saltbuf = new byte[16];

                RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
                randomNumberGenerator.GetBytes(saltbuf);

                StringBuilder sb = new StringBuilder(16);
                for (int i = 0; i < 16; i++)
                    sb.Append(string.Format("{0:X2}", saltbuf[i]));
                string salt = sb.ToString();

                byte[] password = Encoding.Unicode.GetBytes(salt + _View.Password);//переводим пароль в байт-массив  

                var md5 = MD5.Create();//создаем объект для получения средств шифрования  

                byte[] byteHash = md5.ComputeHash(password);//вычисляем хеш-представление в байтах  

                StringBuilder hash = new StringBuilder(byteHash.Length);
                for (int i = 0; i < byteHash.Length; i++)
                    hash.Append(string.Format("{0:X2}", byteHash[i]));

                var user = new User
                {
                    FullName = _View.FullName,
                    Login = _View.Login,
                    Password = hash.ToString(),
                    Salt = salt,
                    Email = _View.Email,
                    IsAdmin = _View.IsAdmin,
                };
                _context.UsersTable.Add(user);
            }
            _context.SaveChanges();

            LoadAllItemsList();
        }

        private void EditItem(object? sender, EventArgs e)
        {
            string str = sender as string;
            if (str == "mat")
            {
                var query = (from b in _context.MaterialsTable where b.Id == _View.Id select b).Single();

                query.Category = _View.Category;
                query.Name = _View.Name_;
                query.Color = _View.Color_;
                query.CostPerMeter = _View.CostPerMeter;
                query.Description = _View.Description;
            }
            else if (str == "us")
            {
                var query = (from b in _context.UsersTable where b.Id == _View.Id select b).Single();

                query.FullName = _View.FullName;
                query.Login = _View.Login;
                query.Email = _View.Email;
                query.IsAdmin = _View.IsAdmin;
            }
            _context.SaveChanges();

            LoadAllItemsList();
        }

        private void DeleteItem(object? sender, EventArgs e)
        {
            string str = sender as string;

            if (str == "mat")
            {
                var row = _View.getDataGridSelectedRow() as DataGridViewRow;
                var query = from b in _context.MaterialsTable where b.Id == Convert.ToInt32(row.Cells["Id"].Value) select b;

                if (query == null)
                    return;

                _context.MaterialsTable.RemoveRange(query);
            }
            else if (str == "us")
            {
                var row = _View.getDataGridSelectedRow() as DataGridViewRow;
                var query = from b in _context.UsersTable where b.Id == Convert.ToInt32(row.Cells["Id"].Value) select b;

                if (query == null)
                    return;

                _context.UsersTable.RemoveRange(query);
            }

            _context.SaveChanges();

            LoadAllItemsList();
        }

        private void ChageTable(object? sender, EventArgs e)
        {
            var selectedItem = (ComboBoxItem)_View.SelectedTable;


            if (selectedItem.Id == "MaterialsTable")
            {
                LoadAllItemsList();
                SetComboBox(true);//
            }
            else if (selectedItem.Id == "UsersTable")
            {
                LoadAllItemsList();
                SetComboBox(false);//
            }
        }

        private void LoadAllItemsList()
        {
            try
            {
                var selectedItem = (ComboBoxItem)_View.SelectedTable;

                if (selectedItem.Id == "MaterialsTable")
                {
                    var query = from b in _context.MaterialsTable select b;
                    materialsBindingSource.DataSource = query.ToList();
                }
                else if (selectedItem.Id == "UsersTable")
                {
                    var query = from b in _context.UsersTable select b;
                    materialsBindingSource.DataSource = query.ToList();
                    this._View.RemoveDataGridColumn("Password");
                    this._View.RemoveDataGridColumn("Salt");
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void LoadComboBox(object? sender, EventArgs e)
        {
            var items = GetComboBoxItems();
            var items1 = GetComboBoxItems();
            var items2 = GetComboBoxItemsT();
            _View.SetComboBoxItems(items, items1);
            _View.SetComboBoxItems(items2);
        }

        public void SetComboBox(bool flag)
        {
            if (flag)
            {
                var items = GetComboBoxItems();
                var items1 = GetComboBoxItems();
                _View.SetComboBoxItems(items, items1);
            }
            else
            {
                var items = GetComboBoxItemsUs();
                var items1 = GetComboBoxItemsUs();
                _View.SetComboBoxItems(items, items1);
            }
        }

        private void SearchItem(object sender, EventArgs e)
        {
            var Item = (ComboBoxItem)_View.SelectedTable;


            var selectedItem = (ComboBoxItem)_View.SearchIn;
            var selectedItemOrderBy = (ComboBoxItem)_View.OrderBy;

            if (selectedItem.Id == "MaterialsTable")
            {
                SearchMaterial(selectedItem.Id, _View.SearchValue, selectedItemOrderBy.Id);
            }
            else if (selectedItem.Id == "UsersTable")
            {
                SearchUser(selectedItem.Id, _View.SearchValue, selectedItemOrderBy.Id);
            }
        }

        private void SortMaterial(object? sender, EventArgs e)
        {
            try
            {
                var Item = (ComboBoxItem)_View.SelectedTable;

                var selectedItemOrderBy = (ComboBoxItem)_View.OrderBy;

                if (Item.Id == "MaterialsTable")
                {
                    RefreshData(selectedItemOrderBy.Id, true);
                }
                else if (Item.Id == "UsersTable")
                {
                    RefreshData(selectedItemOrderBy.Id, false);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private async void RefreshData(string order, bool material_or_user)
        {
            try
            {
                bool isAsc = _View.IsASC;

                if (material_or_user)
                {
                    var query = from m in _context.MaterialsTable select m;

                    if (!string.IsNullOrEmpty(order))
                    {
                        query = isAsc ? query.OrderBy(m => EF.Property<object>(m, order)) : query.OrderByDescending(m => EF.Property<object>(m, order));
                    }
                    else
                    {
                        query = isAsc ? query.OrderBy(m => m.Category) : query.OrderByDescending(m => m.Category);
                    }

                    materialsBindingSource.DataSource = query.ToList();
                }
                else
                {
                    var query = from m in _context.UsersTable select m;

                    if (!string.IsNullOrEmpty(order))
                    {
                        query = isAsc ? query.OrderBy(m => EF.Property<object>(m, order)) : query.OrderByDescending(m => EF.Property<object>(m, order));
                    }
                    else
                    {
                        query = isAsc ? query.OrderBy(m => m.FullName) : query.OrderByDescending(m => m.FullName);
                    }

                    materialsBindingSource.DataSource = query.ToList();
                }
            }
            catch (Exception)
            {

            }
        }
        private void SearchMaterial(string where, string what, string how)
        {
            try
            {
                IQueryable<Materials> query = _context.MaterialsTable;
                if (!string.IsNullOrEmpty(where) && !string.IsNullOrEmpty(what))
                {
                    if (where == "Id")
                    {
                        if (int.TryParse(what, out int id))
                        {
                            query = query.Where(m => EF.Property<int>(m, where) == id);
                        }
                    }
                    else if (where == "Category")
                    {
                        query = query.Where(m => EF.Property<string>(m, where).Contains(what));
                    }
                    else if (where == "Name")
                    {
                        query = query.Where(m => EF.Property<string>(m, where).Contains(what));
                    }
                    else if (where == "Color")
                    {
                        query = query.Where(m => EF.Property<string>(m, where).Contains(what));
                    }
                    else if (where == "CostPerMeter")
                    {
                        if (int.TryParse(what, out int num))
                        {
                            query = query.Where(m => EF.Property<int>(m, where) == num);
                        }
                    }
                }

                if (!string.IsNullOrEmpty(how))
                {
                    if (how == "Id")
                    {
                        query = query.OrderBy(m => EF.Property<int>(m, how));
                    }
                    else if (how == "Category")
                    {
                        query = query.OrderBy(m => EF.Property<string>(m, how));
                    }
                    else if (how == "Name")
                    {
                        query = query.OrderBy(m => EF.Property<string>(m, how));
                    }
                    else if (how == "Color")
                    {
                        query = query.OrderBy(m => EF.Property<string>(m, how));
                    }
                    else if (how == "CostPerMeter")
                    {
                        query = query.OrderBy(m => EF.Property<int>(m, how));
                    }
                }

                materialsBindingSource.DataSource = query.ToList();
            }
            catch (Exception ex)
            {

            }
        }

        private void SearchUser(string where, string what, string how)
        {
            try
            {
                IQueryable<User> query = _context.UsersTable;
                if (!string.IsNullOrEmpty(where) && !string.IsNullOrEmpty(what))
                {
                    if (where == "Id")
                    {
                        if (int.TryParse(what, out int id))
                        {
                            query = query.Where(m => EF.Property<int>(m, where) == id);
                        }
                    }
                    else if (where == "FullName")
                    {
                        query = query.Where(m => EF.Property<string>(m, where).Contains(what));
                    }
                    else if (where == "Login")
                    {
                        query = query.Where(m => EF.Property<string>(m, where).Contains(what));
                    }
                    else if (where == "Email")
                    {
                        query = query.Where(m => EF.Property<string>(m, where).Contains(what));
                    }
                }

                if (!string.IsNullOrEmpty(how))
                {
                    if (how == "Id")
                    {
                        query = query.OrderBy(m => EF.Property<int>(m, how));
                    }
                    else if (how == "FullName")
                    {
                        query = query.OrderBy(m => EF.Property<string>(m, how));
                    }
                    else if (how == "Login")
                    {
                        query = query.OrderBy(m => EF.Property<string>(m, how));
                    }
                    else if (how == "Email")
                    {
                        query = query.OrderBy(m => EF.Property<string>(m, how));
                    }
                }

                materialsBindingSource.DataSource = query.ToList();
            }
            catch (Exception ex)
            {

            }
        }

        public List<ComboBoxItem> GetComboBoxItems()
        {
            return new List<ComboBoxItem> {new ComboBoxItem { Id = "Id", Text = "Id" },
                new ComboBoxItem { Id = "Category", Text = "Category" }, new ComboBoxItem { Id = "Name", Text = "Name" },
                new ComboBoxItem { Id = "Color", Text = "Color" } , new ComboBoxItem { Id = "CostPerMeter", Text = "Cost per meter" } };
        }

        public List<ComboBoxItem> GetComboBoxItemsT()
        {
            return new List<ComboBoxItem> { new ComboBoxItem { Id = "MaterialsTable", Text = "Materials" },
            new ComboBoxItem { Id = "UsersTable", Text = "Users" } };
        }

        public List<ComboBoxItem> GetComboBoxItemsUs()
        {
            return new List<ComboBoxItem> {new ComboBoxItem { Id = "Id", Text = "Id" },
                new ComboBoxItem { Id = "FullName", Text = "FullName" }, new ComboBoxItem { Id = "Login", Text = "Login" },
                new ComboBoxItem { Id = "Email", Text = "Email" } , new ComboBoxItem { Id = "IsAdmin", Text = "Is admin" } };
        }
    }
}
