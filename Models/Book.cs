using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellUp.Models
{
    public class Book : Product
    {
        public Book() { }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public string? Format {  get; set; }
        public string? Language { get; set; }
    }
}
