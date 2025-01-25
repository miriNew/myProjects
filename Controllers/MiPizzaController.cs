using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using OurApi.Models;

namespace OurApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MiPizzaController : ControllerBase
{
    private readonly ILogger<MiPizzaController> _logger;
    private static List<MiPizza> arr;
    public MiPizzaController(ILogger<MiPizzaController> logger)
    {
        _logger = logger;
    }
    static MiPizzaController()
    {
        arr = new List<MiPizza>
        {
            new MiPizza {Id = 1, Name="Regular"},
            new MiPizza {Id = 2, Name="Vegan", IsVegan = true},
            new MiPizza {Id = 3, Name="Gluten Free", IsGlutenFree = true},
        };
    }

    [HttpGet()]
    public ActionResult<IEnumerable<MiPizza>> Get()
    {
        return arr;
    }

    private bool get(int id, out MiPizza pizza)
    {
        pizza = arr.FirstOrDefault(p => p.Id == id);
        if (pizza == null)
                return false;
        return true;
    }
    
    [HttpGet("{id}")]
    public ActionResult<MiPizza> Get(int id)
    {
        MiPizza pizza;
        if (get(id, out pizza))
        {
            return pizza;
        }
        return NotFound();
    }

    [HttpPost]
    public ActionResult Post(MiPizza newItem)
    {
        int maxId = arr.Max(p => p.Id);
        newItem.Id = maxId;
        arr.Add(newItem);
        return CreatedAtAction("Post", new { id = maxId }, newItem);
    }

    [HttpPut("{id}")]
    public ActionResult Put(int id, MiPizza newItem)
    {
        if (id != newItem.Id 
            || !get(id , out MiPizza pizza))
        {
            return BadRequest();
        }
        arr[arr.IndexOf(pizza)] = newItem;
        return NoContent();
    }   

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        if (!get(id , out MiPizza pizza))
        {
            return BadRequest();
        }
        arr.RemoveAt(arr.IndexOf(pizza));
        return NoContent();
    } 
}
