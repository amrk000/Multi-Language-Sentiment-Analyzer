namespace sentiment_analyzer
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //application configuration: https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}