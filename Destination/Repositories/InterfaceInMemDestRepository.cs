using System.Collections.Generic;
using Destination.Entities;


// Interface: Creating a abstraction to avoid dependency
// Generating one instance of repository at startup
// Benefits: Allows for unique ID's to be assigned and easier to 
// modify and adjust code
namespace Destination.Repositories
{
    public interface InterfaceInMemDestRepository
    {
        /// <summary> Interface method to get all the Dest objects for destinations </summary>
        /// <return> Returns all the current destinations </return>
        Dest GetDest(string name);

        /// <summary> Interface method to find a specific Dest object for a destination </summary>
        /// <param name ="name"> string of the destination to look for </param>
        /// <return> Returns the Dest object for that specific destination </return>
        IEnumerable<Dest> GetDests();
    }
}