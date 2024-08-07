using TrackerLibrary;

namespace TrackerUI
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

            //initialise the database connection
            //TrackerLibrary.GlobalConfig.InitializeConnection(DatabaseType.Sql);
            TrackerLibrary.GlobalConfig.InitializeConnection(DatabaseType.TextFile);

            //Application.Run(new CreatePrizeForm());
            // Application.Run(new TournamentDashboardForm());
            //Application.Run(new CreateTeamForm());
           Application.Run(new CreateTournamentForm());
        }
    }
}