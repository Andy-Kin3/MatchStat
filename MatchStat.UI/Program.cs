using MatchStat.Core;
using MatchStat.Database;
using Microsoft.EntityFrameworkCore;

namespace MatchStat.UI
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

            var context = new FootballInfoContext();
            context.Database.Migrate();

            GlobalFunctions.IsRunTime = true;

            Application.Run(new MainForm());
        }
    }
}