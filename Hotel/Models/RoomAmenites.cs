
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class RoomAmenites
    {
        [Key]
        public int AmenitiesID { get; set; }
        public int RoomID { get; set; }
        public Rooms Room { get; set; }
    }
}
