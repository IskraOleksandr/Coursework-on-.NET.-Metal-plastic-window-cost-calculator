using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_plastic_window_cost_calculator.Views
{
    public interface IBuyWindowView
    {
        string TextBoxHeightText { get; set; }
        string TextBoxWidthText { get; set; }

        string TextBoxFrameText { get; set; }
        string Label_FullPrice { get; set; }

        string Label_Price { get; set; }
        bool ButtonEnabled { get; set; }


        event EventHandler<EventArgs> load_datagrid_items;
        event EventHandler<EventArgs> data_grid_frame_click;

        event EventHandler<EventArgs> data_grid_glass_click;
        event EventHandler<EventArgs> data_grid_furniture_click;

        event EventHandler<EventArgs> data_grid_cart_click;
        event EventHandler<EventArgs> text_box_text_change;
        event EventHandler<EventArgs> showOrderPriceList;

        void Show();
        void SetDataGridBindingSource(BindingSource frameList, BindingSource glassList, BindingSource furnitureList);
        void RemoveDataGridsColumn(string column_Name);

        object getDataGridFrameSelectedRow();
        object getDataGridGlassSelectedRow();
        object getDataGridFurnitureSelectedRow();
        object getDataGridSelectedRow();

        object getDataGridViewRowCollection();
        void setDataGridColums();
        void clearDataGrid();

        void showMessageBoxWithIcon(string message, string caption);
        void showMessageBox(string message, string caption);
    }
}
