using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Destination.Dtos
{
    public record UpdateDestDto
    {
        [Required]
        public string Name {get; init;}

        [Required]
        public List<string> List {get; init;}
    }
}