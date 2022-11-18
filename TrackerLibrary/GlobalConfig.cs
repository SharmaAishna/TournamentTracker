﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{ //Static means you cant instantiate the global Config.
  //A class is like a blue print of house so whoever uses has to use the class
  //but static class is not a blue print its actually a house
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(bool database, bool TextFiles)
        {
            if (database)
            {
                //TODO- Set up sql connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if (TextFiles)
            {
                //TODO- create the text connection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
