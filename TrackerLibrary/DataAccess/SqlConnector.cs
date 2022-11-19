using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    { //TODO- make the createPrize method actually save to the database.
        /// <summary>
        /// Saves a new prize to database.
        /// </summary>
        /// <param name="model"> The prize information</param>
        /// <returns>The prize information, including the unique identifier</returns>
        /// <exception cref="NotImplementedException"></exception>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = 
                new System.Data.SqlClient.SqlConnection(
                    GlobalConfig.cnnString("Tournaments"))
                {
                    
                }
        }
    }
}
