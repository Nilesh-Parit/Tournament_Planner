using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using System.Data.SqlClient;
using Dapper;
using System.Reflection;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "Tournament";
        public void createPerson(PersonModel person)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", person.FirstName);
                p.Add("@LastName", person.LastName);
                p.Add("@EmailAddress", person.EmailAddress);
                p.Add("@Cellphone", person.CellPhoneNo);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPerson_Insert", p, commandType: CommandType.StoredProcedure);

                person.Id = p.Get<int>("@id");
            }
        }

        //save the prize in database
        //TODO -make createprize method which actually save in the database
        public void createPrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }

        }

        public void createTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("TeamName", model.TeamName);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@Id");

                foreach(PersonModel tm in model.TeamMembers)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamId", model.Id);
                    p.Add("PersonId", tm.Id);

                    connection.Execute("dbo.spTeamMember_Insert", p, commandType: CommandType.StoredProcedure);
                }
            }
        }

        public void createTournament(TournamentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                SaveTournament(connection, model);
                SaveTournamentPrizes(connection, model);
                SaveTournamentEntries(connection, model);
                SaveTournamentRounds(connection, model);

                TournamentLogic.UpdateTournamentResults(model);
            }
        }

        private void SaveTournament(IDbConnection connection, TournamentModel model)
        {
            var p = new DynamicParameters();
            p.Add("@TournamentName", model.TournamentName);
            p.Add("@EntryFee", model.EntryFee);
            p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTournaments_Insert", p, commandType: CommandType.StoredProcedure);

            model.Id = p.Get<int>("@Id");
        }

        private void SaveTournamentPrizes(IDbConnection connection, TournamentModel model)
        {
            var p = new DynamicParameters();

            foreach (PrizeModel pz in model.Prize)
            {
                p = new DynamicParameters();
                p.Add("@TournamentID", model.Id);
                p.Add("@PrizeID", pz.Id);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        private void SaveTournamentEntries(IDbConnection connection, TournamentModel model)
        {
            foreach (TeamModel tm in model.EnteredTeam)
            {
                var p = new DynamicParameters();
                p = new DynamicParameters();
                p.Add("@TournamentId", model.Id);
                p.Add("@TeamId", tm.Id);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        private void SaveTournamentRounds(IDbConnection connection, TournamentModel model)
        {
            // save List<List<MatchupModel>> Rounds
            // save List <MatchupEntryModel> Entries
            

            //loop through the rounds
            //loop through the matchups
            //save the matchup
            //loop through the entries and save them

            foreach(List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    var p = new DynamicParameters();
                    p.Add("@TournamentId", model.Id);
                    p.Add("@MatchupRound", matchup.MatchupRound);
                    p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spMatchups_Insert", p, commandType: CommandType.StoredProcedure);

                    matchup.Id = p.Get<int>("@Id");

                    foreach(MatchupEntryModel entry in matchup.Entries)
                    {
                        p = new DynamicParameters();

                        p.Add("@MatchupID", matchup.Id);

                        if (entry.ParentMatchup == null)
                        {
                            p.Add("@ParentMatchupID", null);
                        }
                        else
                        {
                            p.Add("@ParentMatchupID", entry.ParentMatchup.Id);
                        }

                        if(entry.TeamCompeting ==null)
                        {
                            p.Add("TeamCompetingID", null);
                        }
                        else
                        {
                            p.Add("TeamCompetingID", entry.TeamCompeting.Id);
                        }
                                                
                        p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                        connection.Execute("dbo.spMatchupEntries_Insert", p, commandType: CommandType.StoredProcedure);
                    }
                }
            }
        }

        public List<PersonModel> getPerson_All()
        {
            List<PersonModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();

            }
            return output;
        }

        public List<TeamModel> getTeam_All()
        {
            List<TeamModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();

                foreach (TeamModel team in output)
                {
                    var p = new DynamicParameters();
                    p.Add("TeamId", team.Id);
                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
                }

            }
            return output;
        }

        public List<TournamentModel> GetTournament_All()
        {
            List<TournamentModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TournamentModel>("dbo.spTournament_GetAll").ToList();
                
                foreach(TournamentModel t in output)
                {
                    // Populate Prizes
                    var r = new DynamicParameters();
                    r.Add("@TournamentId", t.Id);

                    t.Prize = connection.Query<PrizeModel>("dbo.spPrizes_GetByTournament", r, commandType: CommandType.StoredProcedure).ToList();

                    // Populate Teams
                    var n = new DynamicParameters();
                    n.Add("@TournamentId", t.Id);
                    t.EnteredTeam = connection.Query<TeamModel>("dbo.spTeam_GetByTournament", n, commandType: CommandType.StoredProcedure).ToList();

                    foreach(TeamModel team in t.EnteredTeam)
                    {
                        var s = new DynamicParameters();
                        s.Add("@TeamId",team.Id);

                        team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", s, commandType: CommandType.StoredProcedure).ToList();
                    }

                    //Populate Rounds
                    var p = new DynamicParameters();
                    p.Add("@TournamentId", t.Id);

                    List<MatchupModel> matchups = connection.Query<MatchupModel>("dbo.spMatchups_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();
                    
                    foreach(MatchupModel m in matchups)
                    {
                        p = new DynamicParameters();
                        p.Add("@MatchupId", m.Id);

                        m.Entries = connection.Query<MatchupEntryModel>("dbo.spMatchupEntries_GetByMatchup", p, commandType: CommandType.StoredProcedure).ToList();

                        // (1) populate each Entry(2 models);
                        // (2) populate each matchup(1 model);

                        List<TeamModel> allTeams = getTeam_All();

                        if(m.WinnerId > 0)          // (2)
                        {
                            m.Winner = allTeams.Where(x => x.Id == m.WinnerId).First();
                        }

                        foreach (var me in m.Entries)   // (1)
                        {
                            if(me.TeamCompetingId > 0)
                            {
                                me.TeamCompeting = allTeams.Where(x => x.Id == me.TeamCompetingId).First();
                            }

                            if(me.ParentMatchupId > 0)
                            {
                                me.ParentMatchup = matchups.Where(x => x.Id == me.ParentMatchupId).First();
                            }
                        }
                    }

                    // List<List<MatchupModel>>
                    List<MatchupModel> currRow = new List<MatchupModel>();
                    int currRound = 1;

                    foreach (MatchupModel m in matchups)
                    {
                        if(m.MatchupRound > currRound)
                        {
                            t.Rounds.Add(currRow);
                            currRow = new List<MatchupModel>();
                            currRound += 1;
                        }
                        currRow.Add(m);
                    }
                    t.Rounds.Add(currRow); 
                }
            }
            return output;
        }

        public void UpdateMatchup(MatchupModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();

                if(model.Winner != null)
                {
                    p.Add("@Id", model.Id);
                    p.Add("@WinnerId", model.Winner.Id);

                    connection.Execute("dbo.spMatchups_Update", p, commandType: CommandType.StoredProcedure);
                }

                foreach (MatchupEntryModel me in model.Entries)
                {
                   if(me.TeamCompeting != null)
                   {
                        p = new DynamicParameters();
                        p.Add("@Id", me.Id);
                        p.Add("@TeamCompetingId", me.TeamCompeting.Id);
                        p.Add("@Score", me.Score);

                        connection.Execute("dbo.spMatchupEntries_Update", p, commandType: CommandType.StoredProcedure);
                   }
                }
            }
        }

        public void CompleteTournament(TournamentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@Id",model.Id);

                connection.Execute("dbo.spTournament_Complete", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
