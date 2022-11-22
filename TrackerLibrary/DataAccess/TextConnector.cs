using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelper;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModel.csv";
        //Load the text File. Convert the text to List<PrizeModel>

        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().Loadfile().ConvertToPrizeModels();
            //Find the max ID.
            int currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            model.Id = currentId;
            currentId = +1;
            //Add the new record with the new ID(max+1).
            prizes.Add(model);
            //Convert the prizes to list<string>
            //Save the list<string> to the text file.
            prizes.SaveToPrizeFile(PrizesFile);
            return model;
        }
    }
}
