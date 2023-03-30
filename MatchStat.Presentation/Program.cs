using MatchStat.Core;
using MatchStat.Database;
using MatchStat.Interfaces.Database;
using MatchStat.UI;

namespace MatchStat.Presentation
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


            GlobalFunctions.RegisterDependencies();

            var context = GlobalFunctions.GetInstance<IFootballInfoContext>();
            //var context = new FootballInfoContext();
            context.MigrateDatabase();

            RuntimeChecker.IsRunTime = true;

            Application.Run(new MainForm());
        }
    }
}