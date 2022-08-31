namespace Molie_SuperMarket
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.h
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new CategoryForm());
        }
    }
}