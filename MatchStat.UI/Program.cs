using MatchStat.DataModel.DataModels;
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

            var context = new FootballInfoContext();
            context.Database.Migrate();

            var nowString = DateTime.Now.ToString("yyy-MM-dd hh:mm");
            var todayString = DateTime.Now.ToString("yyy-MM-dd hh:mm");

            Application.Run(new MainForm());
        }
    }
}