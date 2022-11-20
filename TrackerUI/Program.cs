﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Initialize the database connection
            TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.sql);
            Application.Run(new CreatePrizeForm());
            //  Application.Run(new TournamentDashBoardForm());
        }    }
}
