using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcBus.Models
{
    public class BusSeatViewModel
    {
        public List<Bus> Buses { get; set; }
        public SelectList Seats { get; set; }

        [Display(Name = "Type")]
        public string BusSeats { get; set; }

        [Display(Name = "Seats")]
        public string SearchString { get; set; }
    }
}
