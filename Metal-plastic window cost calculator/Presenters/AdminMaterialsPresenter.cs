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
    public class AdminMaterialsPresenter
    {
        //Fields
        private IAdminView _View;
        private IRepository _repository;
        private BindingSource materialsBindingSource;
        private IEnumerable<Materials> materialsList;

        //Constructor
        public AdminMaterialsPresenter(IAdminView view, IRepository repository)
        {
            this.materialsBindingSource = new BindingSource();
            this._View = view;
            this._repository = repository;
           // _View.get_material_desc += new EventHandler<EventArgs>(test2);
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
            //this._View.RemoveDataGridColumn("Id"); Description
            //this._View.RemoveDataGridColumn("Description"); Description
        }

        private async void LoadAllMaterial()
        {
            //_View.ClearListView();
            //var materials = await _repository.GetMaterials();
            //foreach (var material in materials)
            //{
            //    _View.Add_To_List(new ListViewItem(new string[] { material.Id.ToString(), material.Category, material.Name, 
            //         material.Color, material.CostPerMeter.ToString(), material.Description }) );
            //}
        }
        public async void test2(object? sender, EventArgs e)
        {
            //string str = sender as string;
            //int id = Convert.ToInt32(str);
            //var material = await _repository.GetMaterial(id);
            //_View.LabelDescription = material.Description;

        }
        private void SearchPet(object sender, EventArgs e)
        {
           // bool emptyValue = string.IsNullOrWhiteSpace(this._View.SearchValue);
           //// List<Materials> SearchMaterial1(string searchIn, string searchValue, string sortOrder, string sortBy)
            
           // if (emptyValue == false)//Dima12//Qwerty-123
           //     materialsList = _repository.SearchMaterial1(this.view.SearchValue);

           // else materialsList = _repository.GetIEnumerableMaterials();

           // materialsBindingSource.DataSource = materialsList;
        }
    }
}
