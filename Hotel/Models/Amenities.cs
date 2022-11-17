using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Amenities
    {
        public int ID{ get; set; }
        [DisplayName("Amenities")]
        public string Name { get; set; }
        public RoomAmenites RoomAmenites { get; set; }
    }
}
