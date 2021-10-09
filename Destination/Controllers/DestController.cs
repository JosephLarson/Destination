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
        public IEnumerable<DestDto> GetDest()
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

        // POST /destination
        [HttpPost]
        public ActionResult<DestDto> CreateDest(CreateDestDto destDto)
        {
            Dest dest = new(){
                Destination = destDto.Name,
                List = destDto.List
            };
            repository.CreateDest(dest);

            return CreatedAtAction(nameof(GetDest), dest.AsDto());
        }
        /*
        // PUT /destination/{name}
        [HttpPut("{name}")]
        public ActionResult UpdateDest(string name, UpdateDestDto destDto)
        {
            // Find existing destination
            var existingDest = repository.GetDest(name);
            if(existingDest is null)
            {
                return NotFound();
            }

            // Adjust existing destination with passed in updated destination
            // Making a copy of it, why we can modify
            Dest updatedDest = existingDest with {
                Name = destDto.Name,
                Path = destDto.Path
            };
            
            // Update the repository
            repository.UpdateDest(updatedDest);
            return NoContent();
        }
        */

        // Delete /destination/{name}
        [HttpDelete]
        public ActionResult DeleteDest(string name)
        {
            // Find existing destination
            var existingDest = repository.GetDest(name);
            if(existingDest is null)
            {
                return NotFound();
            }

            repository.DeleteDest(name);
            return NoContent();
        }
    }
}