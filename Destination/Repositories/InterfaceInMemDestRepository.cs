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
        Dest GetDest(string name);

        IEnumerable<Dest> GetDests();
    }
}