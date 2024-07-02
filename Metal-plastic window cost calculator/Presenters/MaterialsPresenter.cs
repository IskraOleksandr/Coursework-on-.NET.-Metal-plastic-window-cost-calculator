using Metal_plastic_window_cost_calculator.Models;
using Metal_plastic_window_cost_calculator.Repository;
using Metal_plastic_window_cost_calculator.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_plastic_window_cost_calculator.Presenters
{
    public class MaterialsPresenter
    {
        //Fields
        private IMaterialsView _View;
        private IRepository _repository;
        private BindingSource materialsBindingSource;
        private IEnumerable<Materials> materialsList;

        //Constructor
        public MaterialsPresenter(IMaterialsView view, IRepository repository)
        {
            this.materialsBindingSource = new BindingSource();
            this._View = view;
            this._repository = repository;
            _View.load_combobox_items += new EventHandler<EventArgs>(LoadComboBox);
            _View.get_material_desc += new EventHandler<EventArgs>(test2);
            
            _View.SearchEvent += new EventHandler<EventArgs>(SearchPet);
            //Subscribe event handler methods to view events
            //this.view.SearchEvent += SearchPet;
            //Set pets bindind source
            this._View.SetMaterialsListBindingSource(materialsBindingSource);

            //Load pet list view
            LoadAllPetList();
            //Show view
            this._View.Show();
        }

        //Methods
        private void LoadAllPetList()
        {
            materialsList = _repository.GetIEnumerableMaterials();
            materialsBindingSource.DataSource = materialsList;//Set data source.
            this._View.RemoveDataGridColumn("Id");// Description
            this._View.RemoveDataGridColumn("Description");// Description
        }

        //private async void LoadAllMaterial()
        //{
        //    //_View.ClearListView();
        //    //var materials = await _repository.GetMaterials();
        //    //foreach (var material in materials)
        //    //{
        //    //    _View.Add_To_List(new ListViewItem(new string[] { material.Id.ToString(), material.Category, material.Name, 
        //    //         material.Color, material.CostPerMeter.ToString(), material.Description }) );
        //    //}
        //}

        public void LoadComboBox(object? sender, EventArgs e)
        {
            var items = GetComboBoxItems();
            var items1 = GetComboBoxItems();
            _View.SetComboBoxItems(items, items1);
        }


        public async void test2(object? sender, EventArgs e)
        {
            string str = sender as string;
            int id = Convert.ToInt32(str);
            var material = await _repository.GetMaterial(id);
            _View.LabelDescription = material.Description;

        }
        private void SearchPet(object sender, EventArgs e)
        {
            //MessageBox.Show("="+_View.SearchValue);
            //bool emptyValue = string.IsNullOrWhiteSpace(this._View.SearchValue);
            //// List<Materials> SearchMaterial1(string searchIn, string searchValue, string sortOrder, string sortBy)
            //if (emptyValue == false)//Dima12//Qwerty-123
            //    materialsList = _repository.SearchMaterial1(this.view.SearchValue);
            //else materialsList = _repository.GetIEnumerableMaterials();
            //materialsBindingSource.DataSource = materialsList;
            var selectedItem = (ComboBoxItem)_View.SearchIn;
            var selectedItemOrderBy = (ComboBoxItem)_View.OrderBy;

            MessageBox.Show("=" + selectedItemOrderBy.Id);

            var material = _repository.SearchMaterial1(selectedItem.Id, _View.SearchValue, selectedItemOrderBy.Id, "ASC");
            materialsBindingSource.DataSource = material;
        }

        public List<ComboBoxItem> GetComboBoxItems()
        {
            return new List<ComboBoxItem> { new ComboBoxItem { Id = "Category", Text = "Category" },
            new ComboBoxItem { Id = "Name", Text = "Name" }, new ComboBoxItem { Id = "Color", Text = "Color" }
            , new ComboBoxItem { Id = "CostPerMeter", Text = "Cost per meter" } };
        }
    }
}
