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
    [Route("api/shoppingcart")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private ApplicationDbContext _context;
        
        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }

        // <baseurl/api/shoppingcart/>
        [HttpGet]
        public IActionResult Get()
        {
            var shoppingCarts = _context.ShoppingCarts;
            return Ok(shoppingCarts);
        }

        // POST <baseurl/api/shoppingcart/>
        [HttpPost]
        public IActionResult Post([FromBody] ShoppingCart value)
        {
            _context.ShoppingCarts.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        [HttpGet("user/{userId}")]
        public IActionResult GetShoppingCartByUser(string userId)
        {
            var shoppingCarts = _context.ShoppingCarts;
            var userShoppingCart = shoppingCarts.Where(s => s.UserId == userId);
            return Ok(userShoppingCart);
        }

      

        [HttpDelete("{shoppingCartId:int}")]
        public IActionResult DeleteShoppingCart(int shoppingCartId)
        {
            var shoppingCart = _context.ShoppingCarts.Where(s => s.ShoppingCartId == shoppingCartId).SingleOrDefault();
            _context.ShoppingCarts.Remove(shoppingCart);
            _context.SaveChanges();
            return Ok("ShoppingCart Deleted");
        }
    }
}
