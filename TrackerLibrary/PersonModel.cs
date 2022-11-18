using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{ /// <summary>
  /// Represents one person.
  /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The First Name of the Person.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The Last Name of the Person.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The email address of the Person.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// The Phone No. of Person.
        /// </summary>
        public string Phone { get; set; }
    }
}
