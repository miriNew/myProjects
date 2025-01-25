namespace OurApi.Models;

public class MiPizza
{
    public int Id { get; set; }

    public string Name { get; set; }

    public bool IsGlutenFree {get; set;}
    
    public bool IsVegan {get; set;}
}