using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReactApp1.Server.Data;
using ReactApp1.Server.Models;

namespace ReactApp1.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlacesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PlacesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Places
        [HttpGet]
        [EnableCors("Policy1")]
        public async Task<ActionResult<IEnumerable<Place>>> Get()
        {
            return await _context.Places.ToListAsync();
        }

        // GET: api/Places/5
        [HttpGet("{id}")]
        [EnableCors("Policy1")]
        public async Task<ActionResult<Place>> GetPlace(int id)
        {
            var place = await _context.Places.FindAsync(id);

            if (place == null)
            {
                return NotFound();
            }

            return place;
        }

        
    }
}
