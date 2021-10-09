using System.Collections.Generic;

namespace Destination.Entities
{
    public record Dest
    {
        public string Destination {get; init;}

        public List<string> List {get; init;}
    }
}