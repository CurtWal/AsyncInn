using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Hotel.Models
{
    public class Inn
    {
        public int Id{ get; set; }
        [DisplayName("Full Name")]
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public HotelRooms HotelRoom { get; set; }
    }
}
