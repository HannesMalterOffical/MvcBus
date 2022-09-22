using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcBus.Models
{
    public class BusSeatViewModel
    {
            public List<Bus> Buses { get; set; }
            public SelectList Seats { get; set; }
            public string BusSeats { get; set; }
            public string SearchString { get; set; }
    }
}
