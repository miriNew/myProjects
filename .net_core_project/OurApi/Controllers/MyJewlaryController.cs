using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using OurApi.Models;
using System.Collections.Generic;
using System.Linq;
using OurApi.services;
using OurApi.Interfaces;

namespace OurApi.Controllers
{

[ApiController]
[Route("[controller]")]

        public class MyJewlaryController: ControllerBase
        {

      private MyJewlaryService MyJewlaryServices;
        public MyJewlaryController(MyJewlaryService myJewlaryServices)
        {
            this.MyJewlaryServices = myJewlaryServices;
        }
           [HttpGet]
        public ActionResult<List<MyJewlary>> GetAll() =>
            MyJewlaryServices.GetAll();


        [HttpGet("{id}")]
        public ActionResult<MyJewlary> Get(int id)
        {
            var myJewlary = MyJewlaryServices.Get(id);

            if (myJewlary == null)
                return NotFound();

            return myJewlary;
        }

        [HttpPost] 
        public IActionResult Create(MyJewlary myJewlary)
        {
            MyJewlaryServices.Add(myJewlary);
            return CreatedAtAction(nameof(Create), new {id=myJewlary.Id}, myJewlary);

        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, MyJewlary myJewlary)
        {
            if (id != myJewlary.Id)
                return BadRequest();

            var existingMyJewlry = MyJewlaryServices.Get(id);
            if (existingMyJewlry is null)
                return  NotFound();

            MyJewlaryServices.Update(myJewlary);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var myJewlary = MyJewlaryServices.Get(id);
            if (myJewlary is null)
                return  NotFound();

            MyJewlaryServices.Delete(id);

            return Content(MyJewlaryServices.Count.ToString());
        }

   
    }
        
}
