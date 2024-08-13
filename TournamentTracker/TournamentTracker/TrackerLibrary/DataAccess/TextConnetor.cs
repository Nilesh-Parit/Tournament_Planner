using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelper;
using System.Reflection;

namespace TrackerLibrary.DataAccess
{
    public class TextConnetor : IDataConnection
    {
        public void createPerson(PersonModel person)             //Person
        {
            // 1) Load the text file and convert the text to list<prizeModel>
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();
            
            int currentId = 1;

            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }
            person.Id = currentId;


            // Add the new record with the new ID (max + 1)
            people.Add(person);

            people.SaveToPeopleFile();
            //convert the prizes to list<string>
            //save the list<string> to the text file
        }

        public void createPrize(PrizeModel model)                 //Prize
        {
            // Load the text file and convert the text to list<prizeModel>
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();

            // Find the Max ID
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;


            // Add the new record with the new ID (max + 1)
            prizes.Add(model);

            prizes.SaveToPrizeFile();
            //convert the prizes to list<string>
            //save the list<string> to the text file
        }

       public void createTeam(TeamModel model)                    //Team
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();

            // Find the Max ID
            int currentId = 1;

            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            teams.Add(model);

            teams.SaveToTeamFile();
        }

        public List<PersonModel> getPerson_All()
        {
            return GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();
        }

        public List<TeamModel> getTeam_All()
        {
            return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
        }

        public void createTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments =
                                            GlobalConfig.TournamentFile
                                            .FullFilePath()
                                            .LoadFile()
                                            .ConvertToTournamentModel();

            int currentId = 1;

            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            model.SaveRoundsToFile();

            tournaments.Add(model);

            tournaments.SaveToTournamentFile();

            TournamentLogic.UpdateTournamentResults(model);
        }

        public List<TournamentModel> GetTournament_All()
        {
            return GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModel();
        }

        public void UpdateMatchup(MatchupModel model)
        {
            model.UpdateMatchupToFile();
        }

        public void CompleteTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments =
                                            GlobalConfig.TournamentFile
                                            .FullFilePath()
                                            .LoadFile()
                                            .ConvertToTournamentModel();

            tournaments.Remove(model);

            tournaments.SaveToTournamentFile();

            TournamentLogic.UpdateTournamentResults(model);
        }
    }
}
