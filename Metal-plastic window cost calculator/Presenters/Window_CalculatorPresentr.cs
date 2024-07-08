using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metal_plastic_window_cost_calculator.Models;
using Metal_plastic_window_cost_calculator.Repository;
using Metal_plastic_window_cost_calculator.Views;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.ApplicationServices;

namespace Metal_plastic_window_cost_calculator.Presenters
{
    public class Window_CalculatorPresenter
    {
        //private IMaterialsView mainView;
        private readonly IUser _user;
        private readonly IRepository _repository;
        private readonly IWindow_Calculator_View _View;
        private readonly IAdminView _AdminView;
        //private readonly IWindow_Calc_Log_View _ViewLog;

        public Window_CalculatorPresenter(IRepository context, IWindow_Calculator_View view/*, IAdminView adminView*/)
        {
            _repository = context;
            _View = view;
            _View.ShowPetView += new EventHandler<EventArgs>(ShowMaterialssView);
            _View.ShowAdmDbView += new EventHandler<EventArgs>(ShowAdminView);

        }
        private void ShowMaterialssView(object sender, EventArgs e)
        {
            IMaterialsView view = Materials_Form.GetInstace((Form1)_View);
            Window_CalculatorContext context = new Window_CalculatorContext();
            new MaterialsPresenter(view, context);//
        }

        private void ShowAdminView(object sender, EventArgs e)
        {
            IAdminView view = Admin_Form.GetInstace((Form1)_View);
            IAddMaterialView view1 = new FormAddMaterial();
            Window_CalculatorContext context = new Window_CalculatorContext();
            new AdminMaterialsPresenter(view, view1, context);//
        }

    }
}
