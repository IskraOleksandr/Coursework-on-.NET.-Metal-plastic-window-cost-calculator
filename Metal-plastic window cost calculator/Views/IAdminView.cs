using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_plastic_window_cost_calculator.Views
{
    public interface IAdminView
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name_ { get; set; }
        public string Color_ { get; set; }
        public int CostPerMeter { get; set; }
        public string Description { get; set; }

        public string FullName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }//
        public string Email { get; set; }
        public bool IsAdmin { get; set; }

        bool IsASC { get; set; }
        object SelectedTable { get; }//
        string SearchValue { get; }//
        object SearchIn { get; }//
        object OrderBy { get; }//
        string LabelDescription { set; }

        //Events
        event EventHandler<EventArgs> SearchEvent;//
        
        event EventHandler<EventArgs> load_combobox_items;//
        event EventHandler<EventArgs> change_table;
        event EventHandler<EventArgs> SortEvent;//


        event EventHandler<EventArgs> add;
        event EventHandler<EventArgs> addItemEvent;//

        event EventHandler<EventArgs> edit;
        event EventHandler<EventArgs> editItemEvent;//

        event EventHandler<EventArgs> delete;
        event EventHandler<EventArgs> deleteItemEvent;

        //Methods
        void SetMaterialsListBindingSource(BindingSource petList);
        void RemoveDataGridColumn(string column_Name);
        void Show();//Optional

        void SetComboBoxItems(List<ComboBoxItem> items, List<ComboBoxItem> items1);//
        void SetComboBoxItems(List<ComboBoxItem> items);//

        object getDataGridSelectedRow();

        void OpenAddForms(bool flag);
        void OpenEditForms(bool flag);
        void OpenDeleteForms(bool flag);
    }
}
