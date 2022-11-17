namespace Hotel.Models.Interfaces
{
    public interface IRoom
    {
        Task<Rooms> Create(Rooms room);

        //Get All
        Task<List<Rooms>> GetRooms();

        //Get by Id
        Task<Rooms> GetRoom(int id);

        //Update
        Task<Rooms> UpdateRoom(int id, Rooms room);

        //Delete
        Task Delete(int id);
    }
}
