using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        void createPerson(PersonModel person);

        // to save the prize object create from ui in PrizeModel. 
        void createPrize(PrizeModel model);

        void createTeam(TeamModel model);

        void createTournament(TournamentModel model);

        void UpdateMatchup(MatchupModel model);

        void CompleteTournament(TournamentModel model);

        List<PersonModel> getPerson_All();
        
        List<TeamModel> getTeam_All();

        List<TournamentModel> GetTournament_All();
    }
}
