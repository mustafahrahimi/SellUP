using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellUp.Models
{
   public abstract class Product
   {
        public Product() { }
        public required int Id { get; set; }
        public required string? Name { get; set; }
        public double Price { get; set; }
        public int Stock {  get; set; }
   }
}
