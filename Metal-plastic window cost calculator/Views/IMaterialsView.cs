using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_plastic_window_cost_calculator.Views
{
    public interface IMaterialsView
    {
        string SearchValue { get;}//
        object SearchIn { get; }//
        object OrderBy { get; }//

        string LabelDescription { set; }
        //Events
        event EventHandler<EventArgs> SearchEvent;//

        event EventHandler<EventArgs> get_material_desc;

        event EventHandler<EventArgs> load_combobox_items;//

        //Methods
        void SetMaterialsListBindingSource(BindingSource petList);
        void Add_To_List(ListViewItem value);
        void RemoveDataGridColumn(string column_Name);
        void ClearListView();
        void Show();//Optional

        void SetComboBoxItems(List<ComboBoxItem> items, List<ComboBoxItem> items1);//
    }
}
