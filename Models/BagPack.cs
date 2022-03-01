using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Models
{
    public class BagPack
    {
        public int Id { get; set; }
        public List<Stock> Stock { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
