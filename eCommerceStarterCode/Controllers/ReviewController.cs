using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Linq;
using System.Threading.Tasks;
using eCommerceStarterCode.Models;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/reviews")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ReviewController(ApplicationDbContext context)
        {
            _context = context;
        }
        // <baseurl>/api/reviews/
        [HttpGet]
        public IActionResult Get()
        {
            var reviews = _context.Reviews;
            return Ok(reviews);
        }

        //POST <baseurl>/api/reviews

        [HttpPost]

        public IActionResult Post([FromBody] Review value)
        {
            _context.Reviews.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        [HttpGet("product/{productId}")]
        public IActionResult GetShoppingCartByUser(int productId)
        {
            var reviews = _context.Reviews;
            var productReviews = reviews.Where(r => r.ProductId == productId);
            return Ok(productReviews);
        }
    }
}