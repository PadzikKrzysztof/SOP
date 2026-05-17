using SOP_Administration.HttpConnection;

namespace SOP_Administration
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
            HttpHandler.Create();
            HttpHandler.Authorize(SOP_ETOLibrary.SystemRole.None);
            Thread.Sleep(10000);
            Application.Run(new FormSOP());
        }
    }
}