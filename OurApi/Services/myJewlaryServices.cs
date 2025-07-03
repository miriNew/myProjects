using OurApi.Models;
using OurApi.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace OurApi.services
{
    public class myJewlaryServices :MyJewlaryService
    {
        List<MyJewlary> jewlarys { get; }
        int nextId = 3;
        public myJewlaryServices()
        {
            jewlarys = new List<MyJewlary>
            {
                new MyJewlary { Id = 1, Name = "gold ring", IsGold = true, IsSilver = false  },
                new MyJewlary { Id = 2, Name = "silver ring", IsGold = false, IsSilver = true }
            };
        }

        public List<MyJewlary> GetAll() => jewlarys;

        public MyJewlary Get(int id) => jewlarys.FirstOrDefault(p => p.Id == id);

        public void Add(MyJewlary myJewlary)
        {
            myJewlary.Id = nextId++;
            jewlarys.Add(myJewlary);
        }

        public void Delete(int id)
        {
            var myJewlary = Get(id);
            if(myJewlary is null)
                return;

            jewlarys.Remove(myJewlary);
        }

        public void Update(MyJewlary myJewlary)
        {
            var index = jewlarys.FindIndex(p => p.Id == myJewlary.Id);
            if(index == -1)
                return;

            jewlarys[index] = myJewlary;
        }

        public int Count { get =>  jewlarys.Count();}
    }
}