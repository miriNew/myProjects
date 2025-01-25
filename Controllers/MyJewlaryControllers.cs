using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using OurApi.Models;

namespace OurApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MyJewlaryController : ControllerBase
{
    private readonly ILogger<MyJewlaryController> _logger;
    private static List<MyJewlary> arr;
    public MyJewlaryController(ILogger<MyJewlaryController> logger)
    {
        _logger = logger;
    }
    static MyJewlaryController()
    {
        arr = new List<MyJewlary>
        {
            new MyJewlary {Id = 1, Name="chain"},
            new MyJewlary {Id = 2, Name="bracelet", IsBracelet = true},
            new MyJewlary {Id = 3, Name="ring", IsRing = true},
        };
    }

    [HttpGet()]
    public ActionResult<IEnumerable<MyJewlary>> Get()
    {
        return arr;
    }

    private bool get(int id, out MyJewlary jewlary)
    {
        jewlary = arr.FirstOrDefault(p => p.Id == id);
        if (jewlary == null)
                return false;
        return true;
    }
    
    [HttpGet("{id}")]
    public ActionResult<MyJewlary> Get(int id)
    {
        MyJewlary jewlary;
        if (get(id, out jewlary))
        {
            return jewlary;
        }
        return NotFound();
    }

    [HttpPost]
    public ActionResult Post(MyJewlary newItem)
    {
        int maxId = arr.Max(p => p.Id);
        newItem.Id = maxId;
        arr.Add(newItem);
        return CreatedAtAction("Post", new { id = maxId }, newItem);
    }

    [HttpPut("{id}")]
    public ActionResult Put(int id, MyJewlary newItem)
    {
        if (id != newItem.Id 
            || !get(id , out MyJewlary jewlary))
        {
            return BadRequest();
        }
        arr[arr.IndexOf(jewlary)] = newItem;
        return NoContent();
    }   

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        if (!get(id , out MyJewlary jewlary))
        {
            return BadRequest();
        }
        arr.RemoveAt(arr.IndexOf(jewlary));
        return NoContent();
    } 
}