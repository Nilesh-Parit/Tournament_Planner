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
        // to save the prize object create from ui in PrizeModel. 
        PrizeModel createPrize(PrizeModel model);

    }
}
