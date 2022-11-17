using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class HotelRooms
    {
        [Key]
        public int HotelID { get; set; }
        public int RoomNumber { get; set; }
        public int RoomID { get; set; }
        public decimal Rate { get; set; }
        public bool PetFriendly { get; set; }
        public Inn Hotel { get; set; }
        public Rooms Room { get; set; }

    }
}
