namespace Hotel.Models.Interfaces
{
    public interface IAmenities
    {
        //Create
        Task<Amenities> Create(Amenities amenities);

        //Get All
        Task<List<Amenities>> GetAmenities();

        //Get by Id
        Task<Amenities> GetAmenitie(int id);

        //Update
        Task<Amenities> UpdateAmenitie(int id, Amenities amenities);
        //Delete
        Task Delete(int id);
    }
}
