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

        public class usersController: ControllerBase
        {

      private IusersService usersServices;
        public usersController(IusersService usersService)
        {
            this.usersServices = usersService;
        }
           [HttpGet]
        public ActionResult<List<Users>> GetAll() =>
            usersServices.GetAll();


        [HttpGet("{id}")]
        public ActionResult<Users> Get(int id)
        {
            var user = usersServices.Get(id);

            if (user == null)
                return NotFound();

            return user;
        }

        [HttpPost] 
        public IActionResult Create(Users user)
        {
            usersServices.Add(user);
            return CreatedAtAction(nameof(Create), new {id=user.Id}, user);

        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Users user)
        {
            if (id != user.Id)
                return BadRequest();

            var existingusers = usersServices.Get(id);
            if (existingusers is null)
                return  NotFound();

            usersServices.Update(user);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = usersServices.Get(id);
            if (user is null)
                return  NotFound();

            usersServices.Delete(id);

            return Content(usersServices.Count.ToString());
        }

   
    }
        
}