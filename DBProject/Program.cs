namespace DBProject
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
            Application.Run(new SignIN());
            //Application.Run(new SignUP());
            //Application.Run(new CheckoutForm());
            //Application.Run(new AdminForm());
            //Application.Run(new addProduct());
        }
    }
}