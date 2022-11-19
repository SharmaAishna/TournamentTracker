using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{ /// <summary>
  /// Represents one match in the tournament
  /// </summary>
    public class MatchUpModel
    {
        /// <summary>
        /// The set of teams that are involved in this match.
        /// </summary>
        public List<MatchUpEntryModel> Entries { get; set; } = new List<MatchUpEntryModel>();
        /// <summary>
        /// The winner of the match.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Which round this match is a part of.
        /// </summary>
        public int MatchUpRound { get; set; }
    }
}
