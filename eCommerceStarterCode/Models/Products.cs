using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public double Price { get; set; }
        public string Photo { get; set; }
        public double AvgRating { get; set; }
        [ForeignKey ("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { set; get; }
        public Category Category { set; get; }
    }
}
