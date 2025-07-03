using OurApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace OurApi.Interfaces
{
    public interface IusersService
    {
        List<Users> GetAll();

        Users Get(int id);

        void Add(Users user);

        void Delete(int id);

        void Update(Users user);

        int Count { get;}
    }
}