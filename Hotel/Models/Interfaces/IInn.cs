using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models.Interfaces
{
    public interface IInn
    {
        //Create
        Task<Inn> Create(Inn inn);

        //Get All
        Task<List<Inn>> GetInns();

        //Get by Id
        Task<Inn> GetInn(int id);

        //Update
        Task<Inn> UpdateInn(int id, Inn inn);
        //Delete
        Task Delete(int id);
    }
}
