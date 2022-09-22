using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBus.Models
{
    public class Bus
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [Display(Name = "Scheduled Arrival")]
        [DataType(DataType.Date)]
        public DateTime Arrival { get; set; }
        public string Seats { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Display(Name = "Speed (kph)")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Speed { get; set; }
    }
}
