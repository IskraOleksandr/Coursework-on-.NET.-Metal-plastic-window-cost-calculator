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
        private IAddMaterialView _addView;

        private BindingSource materialsBindingSource;
        private IEnumerable<Materials> materialsList;
        private Window_CalculatorContext _context;
        //Constructor
        public AdminMaterialsPresenter(IAdminView view, IAddMaterialView add, Window_CalculatorContext repository)
        {
            this.materialsBindingSource = new BindingSource();
            this._View = view;
            this._addView = add;
            this._context = repository;

            //Subscribe event handler methods to view events
            //SetComboBox();
            _View.load_combobox_items += new EventHandler<EventArgs>(LoadComboBox);
            _View.change_table += new EventHandler<EventArgs>(ChageTable);
            _View.get_material_desc += new EventHandler<EventArgs>(test2);
            _View.SearchEvent += new EventHandler<EventArgs>(SearchPet);
            _View.SortEvent += new EventHandler<EventArgs>(SortMateriar);
            _View.editMEvent += new EventHandler<EventArgs>(EditMaterial);
            _addView.validation_filds += new EventHandler<EventArgs>(validate_filds);
            //
            //_addView.editMaterial += new EventHandler<EventArgs>(EditMaterial);

            //Set pets bindind source
            this._View.SetMaterialsListBindingSource(materialsBindingSource);

            //Load pet list view

            //LoadAllPetList();

            //Show view
            this._View.Show();
        }

        private void validate_filds(object? sender, EventArgs e)
        {
            //_View.
            bool valid = true;

            if (_addView.Category.Length <= 3)
            {
                _addView.LabelError_Category = "error";
                valid = false;
            }
            else _addView.LabelError_Category = "";


            if (_addView.Name_.Length <= 3)
            {
                _addView.LabelError_Name = "error";
                valid = false;
            }
            else _addView.LabelError_Name = "";


            if (_addView.Color_.Length < 3)
            {
                _addView.LabelError_Color = "error";
                valid = false;
            }
            else _addView.LabelError_Color = "";


            if (_addView.CostPerMeter <= 0)
            {
                _addView.LabelError_CostPerMeter = "error";
                valid = false;
            }
            else _addView.LabelError_CostPerMeter = "";


            if (_addView.Description.Length < 1)
            {
                _addView.LabelError_Description = "error";
                valid = false;
            }
            else _addView.LabelError_Description = "";


            _addView.enable_button(valid);
        }

        public void EditMaterial(object? sender, EventArgs e)
        {
            var row = sender as DataGridViewRow; ;

           

            using (var dialog = new FormAddMaterial(true))
            {
                dialog.Category = row.Cells["Category"].Value.ToString();
                dialog.Name = row.Cells["Name"].Value.ToString();
                dialog.Color_ = row.Cells["Color"].Value.ToString();
                dialog.CostPerMeter = Convert.ToInt32(row.Cells["CostPerMeter"].Value);
                dialog.Description = row.Cells["Description"].Value.ToString();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var authors = new Materials
                    {
                        Category = dialog.Category,
                        Name = dialog.Name_,
                        Color = dialog.Color_,
                        CostPerMeter = dialog.CostPerMeter,
                        Description =  dialog.Description,
                    };

                    _context.MaterialsTable.Update(authors);
                    _context.SaveChanges();
                }
            }
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
                    this._View.RemoveDataGridColumn("Password");
                }



                //this._View.RemoveDataGridColumn("Id");// Description
                //    // Description
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
            LoadAllPetList();
        }
        private void SearchPet(object sender, EventArgs e)
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

        private void SortMateriar(object? sender, EventArgs e)
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

        private void SearchUser(string where, string what, string how)
        {
            try
            {
                //using (var db = new Window_CalculatorContext())
                //{
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
                    //else if (where == "CostPerMeter")
                    //{
                    //    if (int.TryParse(what, out int num))
                    //    {
                    //        query = query.Where(m => EF.Property<bool>(m, where) == true);
                    //    }
                    //}
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
                    //else if (how == "CostPerMeter")
                    //{
                    //    query = query.OrderBy(m => EF.Property<int>(m, how));
                    //}
                }

                materialsBindingSource.DataSource = query.ToList();//
                                                                   // }
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
        //private void ShowMaterialssView(object sender, EventArgs e)
        //{
        //    IMaterialsView view = Materials_Form.GetInstace((Form1)_View);
        //    Window_CalculatorContext context = new Window_CalculatorContext();
        //    new MaterialsPresenter(view, context);//
        //}
    }
}
