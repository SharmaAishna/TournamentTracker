﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{ //Static means you cant instantiate the global Config.
  //A class is like a blue print of house so whoever uses has to use the class
  //but static class is not a blue print its actually a house
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; } 
        public static void InitializeConnections(DatabaseType db)
        {
            if (db==DatabaseType.sql)
            {
                //TODO- Set up sql connector properly
                SqlConnector sql = new SqlConnector();
                Connection=sql;
            }
            else if (db==DatabaseType.Textfile)
            {
                //TODO- create the text connection
                TextConnector text = new TextConnector();
                Connection=text;
            }
        }
        public static string cnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
