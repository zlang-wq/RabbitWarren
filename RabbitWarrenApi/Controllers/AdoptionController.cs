using Microsoft.AspNetCore.Mvc;
using RabbitWarrenApi.Models;

namespace RabbitWarrenApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdoptionController : ControllerBase
    {
        private static readonly Dictionary<Guid, AdoptionRequest> Store = new();

        /// <summary>
        /// Submit a new rabbit adoption request.
        /// </summary>
        [HttpPost]
        public IActionResult Create([FromBody] AdoptionRequestCreateDto dto)
        {
            var id = Guid.NewGuid();
            var request = new AdoptionRequest(
                id,
                dto.AdopterName,
                dto.ContactEmail,
                dto.Phone,
                dto.PreferredSize,
                dto.PreferredColor,
                dto.PreferredAge,
                dto.Priority ?? "normal",
                "Pending");

            Store[id] = request;

            return CreatedAtAction(nameof(GetById), new { id }, new { id });
        }

        /// <summary>
        /// Get the status of an existing adoption request.
        /// </summary>
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Store.TryGetValue(id, out var request) ? Ok(request) : NotFound();
        }        
    }
} 