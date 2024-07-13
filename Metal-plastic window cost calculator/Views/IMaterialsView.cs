using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_plastic_window_cost_calculator.Views
{
    public interface IMaterialsView
    {
        bool IsASC { get; set; }
        string SearchValue { get;}
        object SearchIn { get; }
        object OrderBy { get; }
        string LabelDescription { set; }


        //Events
        event EventHandler<EventArgs> SearchEvent;
        event EventHandler<EventArgs> get_material_desc;

        event EventHandler<EventArgs> load_combobox_items;
        event EventHandler<EventArgs> SortEvent;


        //Methods
        void SetMaterialsListBindingSource(BindingSource materialsList);
        void SetComboBoxItems(List<ComboBoxItem> items, List<ComboBoxItem> items1);
        void RemoveDataGridColumn(string column_Name);
        void Show();
    }
}
