using Metal_plastic_window_cost_calculator.Models;
using Metal_plastic_window_cost_calculator.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Metal_plastic_window_cost_calculator.Presenters
{
    public class CRUD_Presenter
    {
        private IAddMaterialView _View;
        
        private Window_CalculatorContext _context;
        //Constructor
        public CRUD_Presenter(IAddMaterialView view, Window_CalculatorContext repository)
        {
            this._View = view;
            this._context = repository;

            //Subscribe event handler methods to view events
            //this._View.addMaterial += new EventHandler<EventArgs>(_addMaterial);
            //this._View.validation_filds += new EventHandler<EventArgs>(validate_filds);
        }

        private void validate_filds(object? sender, EventArgs e)
        {
            //_View.
            bool valid = true;

            if (_View.Category.Length <= 3)
            {
                _View.LabelError_Category = "error";
                valid = false;
            }
            else _View.LabelError_Category = "";


            if (_View.Name_.Length <= 3)
            {
                _View.LabelError_Name = "error";
                valid = false;
            }
            else _View.LabelError_Name = "";


            if (_View.Color_.Length < 3)
            {
                _View.LabelError_Color = "error";
                valid = false;
            }
            else _View.LabelError_Color = "";


            if (_View.CostPerMeter <= 0)
            {
                _View.LabelError_CostPerMeter = "error";
                valid = false;
            }
            else _View.LabelError_CostPerMeter = "";


            if (_View.Description.Length < 1)
            {
                _View.LabelError_Description = "error";
                valid = false;
            }
            else _View.LabelError_Description = "";


            _View.enable_button(valid);
        }

        private void _addMaterial(object? sender, EventArgs e)
        {
            var authors = new Materials { 
                Category = _View.Category,
                Name = _View.Name_,
                Color = _View.Color_,
                CostPerMeter = _View.CostPerMeter,
                Description = _View.Description,
            };
            _context.MaterialsTable.Add(authors);
            _context.SaveChanges();
            //MessageBox.Show(_View.Category);
        }

        private void _editMaterial(object? sender, EventArgs e)
        {
            var row = sender as DataGridViewRow;

            var authors = new Materials
            {
                Category = _View.Category,
                Name = _View.Name_,
                Color = _View.Color_,
                CostPerMeter = _View.CostPerMeter,
                Description = _View.Description,
            };


            _context.MaterialsTable.Update(authors);
            _context.SaveChanges();
            //MessageBox.Show(_View.Category);
        }
    }
}
