using System.Collections.Generic;

// DTO = Data Transfer Object, using DTO to hide data information.
// For current project I believe this is unnecessary, since the current GET requests
// will expose all of the data. (name, path). But if miles, gas costs, etc were to be
// added we shouldn't expose/provide that data during GET requests unless needed.
namespace Destination.Dtos
{
    public record DestDto
    {
        public string Name {get; init;}

        public List<string> Path {get; init;}
    }
}