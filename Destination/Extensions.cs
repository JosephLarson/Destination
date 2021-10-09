using Destination.Dtos;
using Destination.Entities;

namespace Destination
{
    public static class Extensions{
        // Extension to provide easier use of DTO. 
        // Operates on current dest object, to return DTO version
        public static DestDto AsDto(this Dest dest)
        {
            return new DestDto
            {
                Destination = dest.Destination,
                List = dest.List
            };
        }
    }
}