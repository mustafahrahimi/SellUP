using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellUp.Models
{
    public class Film : Product
    {
        public Film() { }
        public string? Format { get; set; }
        public double RunningTime { get; set; }
    }
}
