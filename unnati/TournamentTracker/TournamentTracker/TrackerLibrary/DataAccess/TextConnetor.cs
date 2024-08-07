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
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";
        private const string TeamFile = "TeamModels.csv";
        private const string TournamentFile = "TournamentModels.csv";
        private const string MatchupFile = "MatchupModel.csv";
        private const string MatchupEntryFile = "MatchupEntryModel.csv";

        public PersonModel createPerson(PersonModel person)             //Person
        {
            // 1) Load the text file and convert the text to list<prizeModel>
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();
            
            int currentId = 1;

            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }
            person.Id = currentId;


            // Add the new record with the new ID (max + 1)
            people.Add(person);

            people.SaveToPeopleFile(PeopleFile);
            //convert the prizes to list<string>
            //save the list<string> to the text file

            return person;

        }

        public PrizeModel createPrize(PrizeModel model)                 //Prize
        {
            // Load the text file and convert the text to list<prizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();

            // Find the Max ID
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;


            // Add the new record with the new ID (max + 1)
            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);
            //convert the prizes to list<string>
            //save the list<string> to the text file

            return model;
        }

       public TeamModel createTeam(TeamModel model)                    //Team
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);

            // Find the Max ID
            int currentId = 1;

            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            teams.Add(model);

            teams.SaveToTeamFile(TeamFile);
            
            return model;
        }

        public List<PersonModel> getPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();
        }

        public List<TeamModel> getTeam_All()
        {
            return TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
        }

        public void createTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = 
                                            TournamentFile
                                            .FullFilePath()
                                            .LoadFile()
                                            .ConvertToTournamentModel(TeamFile,PeopleFile,PrizesFile);

            int currentId = 1;

            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            model.SaveRoundsToFile(MatchupFile, MatchupEntryFile);

            tournaments.Add(model);

            tournaments.SaveToTournamentFile(TournamentFile);
        }
    }
}
