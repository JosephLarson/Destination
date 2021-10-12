using System.Collections.Generic;
using System.Linq;
using Destination.Dtos;
using Destination.Entities;
using Destination.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Destination.Controller
{
    // GET /destination
    [ApiController]
    [Route("destination")]
    public class DestController : ControllerBase
    {
        private readonly InterfaceInMemDestRepository repository;
        public DestController(InterfaceInMemDestRepository repository)
        {
            this.repository = repository;
        }

        /// <summary> Gets all the Dest objects for destinations </summary>
        /// <return> Returns all the current destinations </return>
        // GET /destination
        [HttpGet]
        public IEnumerable<DestDto> GetDests()
        {
            var dests = repository.GetDests().Select(dest => dest.AsDto());
            return dests;
        }

        /// <summary> Function to find a specific Dest object for a destination </summary>
        /// <param name ="name"> string of the destination to look for </param>
        /// <return> Returns the Dest object for that specific destination </return>
        // GET /destination{name}
        [HttpGet("{name}")]
        public ActionResult<DestDto> GetDest(string name)
        // ActionResult, used to allow for NotFound return type
        {
            var dest = repository.GetDest(name);
            if (dest is null)
            {
                return NotFound();
            }
            return dest.AsDto();
        }
    }
}