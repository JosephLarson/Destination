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

        // GET /destination
        [HttpGet]
        public IEnumerable<DestDto> GetDests()
        {
            var dests = repository.GetDests().Select(dest => dest.AsDto());
            return dests;
        }

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