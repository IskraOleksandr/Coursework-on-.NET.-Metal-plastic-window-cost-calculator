using Metal_plastic_window_cost_calculator.Models;
using Metal_plastic_window_cost_calculator.Presenters; 

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

            FormLog log = new FormLog();
            Form1 form = new Form1();
            Admin_Form admin_Form = new Admin_Form();
            Window_CalcPresenter presenter = new Window_CalcPresenter(context, log, form);//form

            log.Show();

            Application.Run();
        }
    }
}