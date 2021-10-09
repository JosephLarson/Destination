using System.Collections.Generic;
using System.Linq;
using Destination.Entities;

namespace Destination.Repositories
{
    public class InMemDestRepository : InterfaceInMemDestRepository
    {
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

        public IEnumerable<Dest> GetDests()
        {
            return dest;
        }

        public Dest GetDest(string name)
        {
            return dest.Where(dest => dest.Destination == name).SingleOrDefault();
        }

        public void CreateDest(Dest destination)
        {
            dest.Add(destination);
        }

        /*
        public void UpdateDest(Dest destination)
        {
            var index = dest.FindIndex(existingDest => existingDest.Name == destination.Name);
            dest[index] = destination;
        }
        */

        public void DeleteDest(string name)
        {
            var index = dest.FindIndex(existingDest => existingDest.Destination == name);
            dest.RemoveAt(index);
        }
    }
}