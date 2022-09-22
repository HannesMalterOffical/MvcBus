using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBus.Models
{
    public class Bus
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime Arrival { get; set; }
        public string Seats { get; set; }
        public decimal Price { get; set; }
    }
}
