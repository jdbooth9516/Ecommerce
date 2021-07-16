using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Mvc;
using eCommerceStarterCode.Models;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/categories")]
    [ApiController]

    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        //<baseurl>/api/examples/user
        [HttpGet]
        public IActionResult Get()
        {
            var category = _context.Categories;
            return Ok(category);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Category value)
        {
            _context.Categories.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
    }
}
