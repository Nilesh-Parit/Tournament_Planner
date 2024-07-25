using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the Matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents one Matchup that this team came from as a winner
        /// </summary>
        public double Score { get; set; }
       
        /// <summary>
        /// 
        /// </summary>        
        public MatchupModel ParentMatchup { get; set; }

    }
}
