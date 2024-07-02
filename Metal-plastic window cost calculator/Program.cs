using Metal_plastic_window_cost_calculator.Models;
using Metal_plastic_window_cost_calculator.Presenters;
using Metal_plastic_window_cost_calculator.Repository;

namespace Metal_plastic_window_cost_calculator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            
            Window_CalculatorContext context = new Window_CalculatorContext();
            Window_CalculatorRepository rep = new(context);

            User us = new User();


            FormLog log = new FormLog();
            Window_CalcPresenter pres = new Window_CalcPresenter(us, rep, log);//form
            
            Form1 form = new Form1();
            Admin_Form admin_Form = new Admin_Form();
            Window_CalculatorPresenter presenter = new Window_CalculatorPresenter(/*us,*/ rep, form/*, admin_Form*/);//form

            log.Show();
            //form.Show();

            Application.Run();
        }
    }
}