using Ardalis.GuardClauses;
using Microsoft.AspNetCore.Mvc;
using RabbitWarrenApi.Data;
using RabbitWarrenApi.DTOs;
using RabbitWarrenApi.Models;

namespace RabbitWarrenApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdoptionController : ControllerBase
    {
        private readonly RabbitWarrenContext _context;

        public AdoptionController(RabbitWarrenContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Submit a new rabbit adoption request.
        /// </summary>
        [HttpPost]
        public IActionResult Create([FromBody] AdoptionRequestCreateDto dto)
        {
            Guard.Against.NullOrEmpty(dto.AdopterName, nameof(dto.AdopterName));
            Guard.Against.NullOrEmpty(dto.Phone, nameof(dto.Phone));
            
            var id = Guid.NewGuid();
            var request = new AdoptionRequest(
                id,
                dto.AdopterName,
                dto.ContactEmail,
                dto.Phone,
                dto.PreferredSize ?? PreferredSize.NoPreference,
                dto.PreferredColor ?? PreferredColor.NoPreference,
                dto.PreferredAge ?? PreferredAge.NoPreference,
                dto.Priority ?? Priority.Normal,
                AdoptionStatus.Pending);

            _context.AdoptionRequests.Add(request);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id }, new { id });
        }

        /// <summary>
        /// Get the status of an existing adoption request.
        /// </summary>
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var request = _context.AdoptionRequests.Find(id);
            return request is not null ? Ok(request) : NotFound();
        }        
    }
} 