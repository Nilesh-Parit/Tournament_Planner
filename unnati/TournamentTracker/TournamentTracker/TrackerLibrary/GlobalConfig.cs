using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public const string PrizesFile = "PrizeModels.csv";
        public const string PeopleFile = "PersonModels.csv";
        public const string TeamFile = "TeamModels.csv";
        public const string TournamentFile = "TournamentModels.csv";
        public const string MatchupFile = "MatchupModel.csv";
        public const string MatchupEntryFile = "MatchupEntryModel.csv";

        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnection(DatabaseType db)
        {
            if (db == DatabaseType.Sql) {
            // -- create SQL Connection
            //TODO -- set sql connector properly
            SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            //we don't use else if bcuz we may reqd both if we have
            else if (db == DatabaseType.TextFile) {
            //TODO -- create textfile connection
            TextConnetor text = new TextConnetor();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        { 
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}