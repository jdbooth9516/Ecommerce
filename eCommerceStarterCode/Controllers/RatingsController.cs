using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;


namespace eCommerceStarterCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        private ApplicationDbContext _context;
       
        public RatingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // <baseurl/api/ratings/>
        [HttpGet]
        public IActionResult Get()
        {
            var ratings = _context.Ratings;
            return Ok(ratings);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Rating value)
        {
            _context.Ratings.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
    }
}
