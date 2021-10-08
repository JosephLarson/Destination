using System.Collections.Generic;

namespace Destination.Entities
{
    public record Dest
    {
        public string Name {get; init;}

        public List<string> Path {get; init;}
    }
}