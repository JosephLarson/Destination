using System.Collections.Generic;
using System.Linq;
using Destination.Entities;

namespace Destination.Repositories
{
    public class InMemDestRepository : InterfaceInMemDestRepository
    {
        /// <summary> Read only data used in API. For paths to destination. </summary>
        /// <returns> A list of Dest objects containing destination and path to destination </returns>
        private readonly List<Dest> dest = new()
        {
            new Dest { Destination = "CAN", List = new List<string> {"USA", "CAN"}},
            new Dest { Destination = "USA", List = new List<string> {"USA"}},
            new Dest { Destination = "MEX", List = new List<string> {"USA", "MEX"}},
            new Dest { Destination = "BLZ", List = new List<string> {"USA", "MEX", "BLZ"}},
            new Dest { Destination = "GTM", List = new List<string> {"USA", "MEX", "GTM"}},
            new Dest { Destination = "SLV", List = new List<string> {"USA", "MEX", "GTM", "SLV"}},
            new Dest { Destination = "HND", List = new List<string> {"USA", "MEX", "GTM", "HND"}},
            new Dest { Destination = "NIC", List = new List<string> {"USA", "MEX", "GTM", "HND", "NIC"}},
            new Dest { Destination = "CRI", List = new List<string> {"USA", "MEX", "GTM", "HND", "NIC", "CRI"}},
            new Dest { Destination = "PAN", List = new List<string> {"USA", "MEX", "GTM", "HND", "NIC", "CRI", "PAN"}},
        };
        
        /// <summary> Gets all the Dest objects for destinations </summary>
        /// <return> Returns all the current destinations </return>
        public IEnumerable<Dest> GetDests()
        {
            return dest;
        }

        /// <summary> Function to find a specific Dest object for a destination </summary>
        /// <param name ="name"> string of the destination to look for </param>
        /// <return> Returns the Dest object for that specific destination </return>
        public Dest GetDest(string name)
        {
            return dest.Where(dest => dest.Destination == name).SingleOrDefault();
        }
    }
}