using System.Collections.Generic;
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

        // GET /destination
        [HttpGet]
        public IEnumerable<Dest> GetDest()
        {
            var dests = repository.GetDests();
            return dests;
        }

        // GET /destination{name}
        [HttpGet("{name}")]
        public ActionResult<Dest> GetDest(string name)
        // ActionResult, used to allow for NotFound return type
        {
            var dest = repository.GetDest(name);
            if (dest is null)
            {
                return NotFound();
            }
            return dest;
        }
    }
}