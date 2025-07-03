using OurApi.Models;
using OurApi.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace OurApi.services
{
    public class usersService :IusersService
    {
        List<Users> users { get; }
        int nextId = 3;
        public usersService()
        {
            users = new List<Users>
            {
                new Users { Id = 1, Name = "miri",IsExist=true, IsNew = false },
                new Users { Id = 2, Name = "dassy", IsExist = false, IsNew=true }
            };
        }

        public List<Users> GetAll() => users;

        public Users Get(int id) => users.FirstOrDefault(p => p.Id == id);

        public void Add(Users user)
        {
            user.Id = nextId++;
            users.Add(user);
        }

        public void Delete(int id)
        {
            var user = Get(id);
            if(user is null)
                return;

            users.Remove(user);
        }

        public void Update(Users user)
        {
            var index = users.FindIndex(p => p.Id == user.Id);
            if(index == -1)
                return;

            users[index] = user;
        }

        public int Count { get =>  users.Count();}
    }
}