using Metal_plastic_window_cost_calculator.Models;
using Metal_plastic_window_cost_calculator.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Metal_plastic_window_cost_calculator.Presenters
{
    public class BuyWindowPresenter
    {
        IBuyWindowView _View;
        Window_CalculatorContext _context;
        private BindingSource frameBindingSource;
        private BindingSource glassBindingSource;
        private BindingSource furnitureBindingSource;

        private List<Materials> cart;
        string orderString;
        //string NL = Environment.NewLine;
        

        public BuyWindowPresenter(Window_CalculatorContext context, IBuyWindowView view)
        {
            _context = context;
            _View = view;

            frameBindingSource = new BindingSource();
            glassBindingSource = new BindingSource();
            furnitureBindingSource = new BindingSource();

            cart = new List<Materials>();
            _View.load_datagrid_items += new EventHandler<EventArgs>(load_mat);
            _View.data_grid_frame_click += new EventHandler<EventArgs>(DataGridFrame_click);
            _View.data_grid_glass_click += new EventHandler<EventArgs>(DataGridGlass_click);
            _View.data_grid_furniture_click += new EventHandler<EventArgs>(DataGridFurniture_click);
            _View.data_grid_cart_click += new EventHandler<EventArgs>(DataGridCart_click);
            _View.text_box_text_change += new EventHandler<EventArgs>(textBoxs_textChange);
            _View.showOrderPriceList += new EventHandler<EventArgs>(showOrder);

            this._View.SetDataGridBindingSource(frameBindingSource, glassBindingSource, furnitureBindingSource);
            load_materials_to_dataGrids();
            _View.Show();
        }

        private void showOrder(object? sender, EventArgs e)
        {
            _View.showMessageBox(orderString, "Order list");
        }

        private void textBoxs_textChange(object? sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void DataGridFrame_click(object? sender, EventArgs e)
        {
            var row = _View.getDataGridFrameSelectedRow() as DataGridViewRow;
            AddToCart("Frame", row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString());
        }

        private void DataGridGlass_click(object? sender, EventArgs e)
        {
            var row = _View.getDataGridGlassSelectedRow() as DataGridViewRow;
            AddToCart("Glass", row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString());
        }

        private void DataGridFurniture_click(object? sender, EventArgs e)
        {
            var row = _View.getDataGridFurnitureSelectedRow() as DataGridViewRow;
            AddToCart(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString());
        }

        private void DataGridCart_click(object? sender, EventArgs e)
        {
            var row = _View.getDataGridSelectedRow() as DataGridViewRow;
            if (row != null)
            {
                RemoveFromCart(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());
            }
        }// Price
        private double ComputePrice(Materials frame, Materials glass, List<Materials> furniture)
        {
            string BR = "-------------------------------------------";
            double frameCost = 0;
            if (frame != null)
            {
                frameCost = (double)frame.CostPerMeter;

            }

            double glassCost = 0;
            if (glass != null)
            {
                glassCost = (double)glass.CostPerMeter;

            }

            double furnitureCost = 0;
            if (furniture != null)
            {
                foreach (Materials i in furniture)
                    furnitureCost += (double)i.CostPerMeter;
            }

            double h = 0.0;
            double w = 0.0;
            double c = 0.0;//frame width
            try
            {
                h = Convert.ToDouble(_View.TextBoxHeightText);
                w = Convert.ToDouble(_View.TextBoxWidthText);
                c = Convert.ToDouble(_View.TextBoxFrameText);
            }
            catch (Exception) {/*if cant convert*/}

            double formula1 = h * w - 2 * h * c - 2 * w * c + 4 * c * c;// = (h-2c)(w-2c) =
            double formula2 = h * w - formula1;// = 2c(h + w - 2c).
            double res = (frameCost * formula2) + (glassCost * formula1) + furnitureCost;

            //build string
            if (frame != null && glass != null && furniture != null)
            {
                orderString = "";
                orderString += $"                    ORDER                 " + Environment.NewLine;
                orderString += BR + Environment.NewLine;
                orderString += $"FRAME" + Environment.NewLine;
                orderString += $"{frame?.Name} {frame?.Color} ----------- ${Math.Round(frameCost * formula2, 2)}" + Environment.NewLine;
                orderString += BR + Environment.NewLine;
                orderString += $"GLASS" + Environment.NewLine;
                orderString += $"{glass?.Name} {glass?.Color} ----------- ${Math.Round(glassCost * formula1, 2)}" + Environment.NewLine;
                orderString += BR + Environment.NewLine;
                orderString += $"FURNITURE" + Environment.NewLine;
                foreach (Materials m in furniture)
                    orderString += $"{m.Name} {m.Color} ----------- ${m.CostPerMeter}" + Environment.NewLine;
                orderString += BR + Environment.NewLine;
                orderString += $"TOTAL" + Environment.NewLine;
                orderString += $"Price                          ${res}" + Environment.NewLine;
                orderString += $"Full Price ----------- ${Math.Round(res / 10.0 + res, 2)}" + Environment.NewLine;
                orderString += BR;

                _View.ButtonEnabled = true;
            }
            else
                _View.ButtonEnabled = false;

            return res;
        }
        private void UpdatePrice()
        {
            if (_View.TextBoxHeightText != "" && _View.TextBoxWidthText != "")
            {
                Materials f = null, g = null;// frame glass
                List<Materials> fs = null;// furnitures
                bool tmp = false;
                foreach (Materials item in cart)
                    if (item.Category == "Frame")
                        f = item;
                    else if (item.Category == "Glass")
                        g = item;
                    else
                        tmp = true;
                if (tmp)
                {
                    fs = new List<Materials>();
                    foreach (Materials item in cart)
                        if (item.Category != "Glass" && item.Category != "Frame")
                            fs.Add(item);
                }

                double res = ComputePrice(f, g, fs);
                _View.Label_Price = Math.Round(res, 2).ToString();
                _View.Label_FullPrice = Math.Round(res / 10.0 + res, 2).ToString();
            }
        }
        private void AddToCart(string cat, string n, string col, string cost)
        {
            var query = from b in _context.MaterialsTable select b;
            var dataGridRows = _View.getDataGridViewRowCollection() as DataGridViewRowCollection;

            foreach (Materials item in query.ToList())
                if (item.Category == cat &&
                    item.Name == n &&
                    item.Color == col &&
                    item.CostPerMeter == Convert.ToInt32(cost))
                {

                    int buf = 0;
                    if (cat == "Frame" || cat == "Glass")
                        foreach (Materials j in cart)
                            if (j.Category == cat) buf++;
                    if (buf == 0)
                        cart.Add(item);
                    else _View.showMessageBoxWithIcon("You cant add more " + cat + " in your cart.", "Oops...");

                    //update dataGridView
                    dataGridRows.Clear();
                    foreach (Materials i in cart)
                        dataGridRows.Add(i.Category, i.Name, i.Color, i.CostPerMeter);
                }
            UpdatePrice();
        }

        private void RemoveFromCart(string cat, string n, string col, string cost)
        {
            var query = from b in _context.MaterialsTable select b;
            var dataGridRows = _View.getDataGridViewRowCollection() as DataGridViewRowCollection;

            foreach (Materials item in query.ToList())
                if (item.Category == cat &&
                    item.Name == n &&
                    item.Color == col &&
                    item.CostPerMeter == Convert.ToInt32(cost))
                {
                    cart.Remove(item);

                    //update dataGridView
                    dataGridRows.Clear();
                    foreach (Materials i in cart)
                        dataGridRows.Add(i.Category, i.Name, i.Color, i.CostPerMeter);
                }
            UpdatePrice();
        }

        private void load_mat(object? sender, EventArgs e)
        {
            load_materials_to_dataGrids();
        }

        private void load_materials_to_dataGrids()
        {
            var query = from b in _context.MaterialsTable where b.Category == "Frame" select b;
            frameBindingSource.DataSource = query.ToList();

            var query1 = from b in _context.MaterialsTable where b.Category == "Glass" select b;
            glassBindingSource.DataSource = query1.ToList();

            var query2 = from b in _context.MaterialsTable where b.Category == "Furniture" select b;
            furnitureBindingSource.DataSource = query2.ToList();

            this._View.RemoveDataGridsColumn("Id");// Description
            this._View.RemoveDataGridsColumn("Category");// Description
            this._View.RemoveDataGridsColumn("Description");// Description
        }
    }
}
