using System.Collections.Generic;

namespace Destination.Entities
{
    /// <summary> Destination object to hold data on name of destination and path to it </summary>
    public record Dest
    {
        /// <summary> Constructor to get the name or a Constructor to get and initialize the of Destination</summary>
        public string Destination {get; init;}

        /// <summary> Constructor to get destination path or a Constructor to get and initialize destination path</summary>
        public List<string> List {get; init;}
    }
}