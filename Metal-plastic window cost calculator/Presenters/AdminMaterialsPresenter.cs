using Metal_plastic_window_cost_calculator.Models;
using Metal_plastic_window_cost_calculator.Repository;
using Metal_plastic_window_cost_calculator.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Metal_plastic_window_cost_calculator.Presenters
{
    public class AdminMaterialsPresenter
    {
        //Fields
        private IAdminView _View;
        //private IRepository _repository;
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
            //SetComboBox();
            _View.load_combobox_items += new EventHandler<EventArgs>(LoadComboBox);
            _View.change_table += new EventHandler<EventArgs>(ChageTable);
            _View.get_material_desc += new EventHandler<EventArgs>(test2);
            _View.SearchEvent += new EventHandler<EventArgs>(SearchPet);
            _View.SortEvent += new EventHandler<EventArgs>(SortMateriar);

            //Set pets bindind source
            this._View.SetMaterialsListBindingSource(materialsBindingSource);

            //Load pet list view

            //LoadAllPetList();

            //Show view
            this._View.Show();
        }

        private void ChageTable(object? sender, EventArgs e)
        {
            var selectedItem = (ComboBoxItem)_View.SelectedTable;


            if (selectedItem.Id == "MaterialsTable")
            {
                LoadAllPetList();
                SetComboBox(true);//
            }
            else if (selectedItem.Id == "UsersTable")
            {
                LoadAllPetList();
                SetComboBox(false);//
            }
        }

        //Methods
        private void LoadAllPetList()
        {
            try
            {
                //using (var db = new Window_CalculatorContext())
                //{
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
                }



                //this._View.RemoveDataGridColumn("Id");// Description
                //    this._View.RemoveDataGridColumn("Description");// Description
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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


        public async void test2(object? sender, EventArgs e)
        {
            string str = sender as string;
            int id = Convert.ToInt32(str);

            using (var db = new Window_CalculatorContext())
            {
                var query = (from b in db.MaterialsTable where b.Id == id select b).Take(1).Single();
                _View.LabelDescription = query.Description;
            }
        }
        private void SearchPet(object sender, EventArgs e)
        {
            var selectedItem = (ComboBoxItem)_View.SearchIn;
            var selectedItemOrderBy = (ComboBoxItem)_View.OrderBy;

            SearchData(selectedItem.Id, _View.SearchValue, selectedItemOrderBy.Id);
        }

        private void SortMateriar(object? sender, EventArgs e)
        {
            try
            {
                var selectedItemOrderBy = (ComboBoxItem)_View.OrderBy;
                RefreshData(selectedItemOrderBy.Id);
            }
            catch (Exception ex)
            {

            }
        }

        private async void RefreshData(string order)
        {
            try
            {
                bool isAsc = _View.IsASC;

                var query = from m in _context.MaterialsTable select m;

                if (!string.IsNullOrEmpty(order))
                {
                    query = isAsc ? query.OrderBy(m => EF.Property<object>(m, order))
                        : query.OrderByDescending(m => EF.Property<object>(m, order));
                }
                else
                {
                    query = isAsc ? query.OrderBy(m => m.Category)
                        : query.OrderByDescending(m => m.Category);
                }

                materialsBindingSource.DataSource = query.ToList();//
            }
            catch (Exception)
            {

            }
        }
        private void SearchData(string where, string what, string how)
        {
            try
            {
                using (var db = new Window_CalculatorContext())
                {
                    IQueryable<Materials> query = db.MaterialsTable;
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

                    materialsBindingSource.DataSource = query.ToList();//
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
