using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellUp.Models
{
    public class ComputerGame : Product
    {
        public ComputerGame() { }
        public string? platform {  get; set; }
    }
}
