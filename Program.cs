namespace UEServerDummy
{
    internal static class Program
    {

        static string[] args = new string[10];
        public static string MyIPAdress = "Undefined";
        public static string MyPort = "Undefined";
        public static DateTime StartTime;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] _args)
        {
            StartTime = DateTime.Now;
            args = _args;
            if(args.Length > 1 ) {
                MyIPAdress = args[0];
                MyPort = args[1];
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
