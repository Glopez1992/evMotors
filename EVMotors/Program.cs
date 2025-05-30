using MainFormEVMotors;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.ThreadException += (sender, args) =>
            {
                MessageBox.Show("An unexpected error occurred. Retrying connection...", "Error");
            };
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}