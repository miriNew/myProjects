using OurApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace OurApi.Interfaces
{
    public interface MyJewlaryService
    {
        List<MyJewlary> GetAll();

        MyJewlary Get(int id);

        void Add(MyJewlary myJewlary);

        void Delete(int id);

        void Update(MyJewlary myJewlary);

        int Count { get;}
    }
}