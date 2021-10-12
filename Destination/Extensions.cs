using Destination.Dtos;
using Destination.Entities;

namespace Destination
{
    public static class Extensions{

        /// <summary> Function to return a Dest object as a DestDto, Data transfer object used to hide business logic </summary>
        /// <param Dest ="dest"> Dest object to be turned into a DestDto </param>
        /// <return> Returns a Dto of the passed in Dest </return>
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