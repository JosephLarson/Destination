using System.Collections.Generic;
using System.Linq;
using Destination.Entities;

namespace Destination.Repositories
{
    public class InMemDestRepository : InterfaceInMemDestRepository
    {
        private readonly List<Dest> dest = new()
        {
            new Dest { Name = "CAN", Path = new List<string> {"USA", "CAN"}},
            new Dest { Name = "USA", Path = new List<string> {"USA"}},
            new Dest { Name = "MEX", Path = new List<string> {"USA", "MEX"}},
            new Dest { Name = "BLZ", Path = new List<string> {"USA", "MEX", "BLZ"}},
            new Dest { Name = "GTM", Path = new List<string> {"USA", "MEX", "GTM"}},
            new Dest { Name = "SLV", Path = new List<string> {"USA", "MEX", "GTM", "SLV"}},
            new Dest { Name = "HND", Path = new List<string> {"USA", "MEX", "GTM", "HND"}},
            new Dest { Name = "NIC", Path = new List<string> {"USA", "MEX", "GTM", "HND", "NIC"}},
            new Dest { Name = "CRI", Path = new List<string> {"USA", "MEX", "GTM", "HND", "NIC", "CRI"}},
            new Dest { Name = "PAN", Path = new List<string> {"USA", "MEX", "GTM", "HND", "NIC", "CRI", "PAN"}},
        };

        public IEnumerable<Dest> GetDests()
        {
            return dest;
        }

        public Dest GetDest(string name)
        {
            return dest.Where(dest => dest.Name == name).SingleOrDefault();
        }
    }
}