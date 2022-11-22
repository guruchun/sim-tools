namespace SimCogen
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
            //Application.Run(new Day1());
            //Application.Run(new Day2());
            //Application.Run(new Day3());
            Application.Run(new Day4());
            //Application.Run(new Final());
        }
    }
}