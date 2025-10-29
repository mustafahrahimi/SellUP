using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellUp.Models
{
    public class ProductHistoryLog
    {
        public int ProductId { get; set; }
        public string? ProductType { get; set; }
        public DateTime Timestamp { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}
