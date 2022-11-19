using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchUpEntryModel
    {
        /// <summary>
        /// Represents One team in the MatchUp.
        /// </summary>
        public TeamModel TeamCompleting { get; set; }
        /// <summary>
        /// Represents the score for this particular team.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the matchup this team came from as the winner.
        /// </summary>
        public MatchUpModel ParentMatchUp { get; set; }
    }
}
