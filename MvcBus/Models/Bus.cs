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

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Scheduled Arrival")]
        [DataType(DataType.Date)]
        public DateTime Arrival { get; set; }

        [Range(1, 24)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Range(10, 100)]
        [Required]
        public string Seats { get; set; }

        [Range(25, 100)]
        [Required]
        public decimal Speed { get; set; }
    }
}
