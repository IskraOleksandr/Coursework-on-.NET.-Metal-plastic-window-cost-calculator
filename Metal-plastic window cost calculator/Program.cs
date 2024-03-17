using Metal_plastic_window_cost_calculator.Models;
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
            User us = new User();
            Form1 form = new Form1();
            Window_CalculatorContext context = new Window_CalculatorContext();
            Window_CalculatorRepository rep = new(context);
            Window_CalculatorPresenter presenter = new Window_CalculatorPresenter(us, rep, form);
            Application.Run(form);
        }
    }
}