using System.ComponentModel;

namespace Hotel.Models
{
    public class Rooms
    {
        public int ID { get; set; }
        [DisplayName("Full Name")]
        public string Name { get; set; }
        public int Layout { get; set; }
        public RoomAmenites Amenite { get; set; }
    }
}
