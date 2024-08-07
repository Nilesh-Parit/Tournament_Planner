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
        PersonModel createPerson(PersonModel person);

        // to save the prize object create from ui in PrizeModel. 
        PrizeModel createPrize(PrizeModel model);

        TeamModel createTeam(TeamModel model);

        void createTournament(TournamentModel model);

        List<PersonModel> getPerson_All();
        
        List<TeamModel> getTeam_All();

        

    }
}
