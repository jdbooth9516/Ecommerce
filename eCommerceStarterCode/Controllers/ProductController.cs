using System;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        //<baseurl>/api/products
        [HttpPost]
        public IActionResult PostProduct([FromBody]Product value)
        {
            _context.Products.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _context.Products;
            return Ok(products);
        }

        [HttpPost("category")]
        public IActionResult GetProductsByCategory([FromBody]int categoryId)
        {
            var products = _context.Products;
            var filteredProducts = products.Where(p => p.CategoryId == categoryId);
            return Ok(filteredProducts);
        }

        [HttpGet("search/{searchText}")]
        public IActionResult GetProductsByName(string searchText)
        {
            var products = _context.Products;
            var filteredProducts = products.Where(p => p.Name.Contains(searchText));
            return Ok(filteredProducts);
        }
    }
}
