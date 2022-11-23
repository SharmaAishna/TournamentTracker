using Dapper;
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
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(
                GlobalConfig.cnnString("Tournaments")))
            {
                var p= new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName",model.LastName);
                p.Add("@Email", model.Email);
                p.Add("@Phone", model.Phone);
                p.Add("@Id", 0, DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spPerson_Insert", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@Id");
                return model;
            }
        }

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
                    GlobalConfig.cnnString("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@Id",0,dbType:DbType.Int32,direction:ParameterDirection.Output);
                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@Id");
                return model;
            }
        }
    }
}
