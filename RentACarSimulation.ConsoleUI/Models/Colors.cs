

namespace RentACarSimulation.ConsoleUI.Models;

public sealed class Colors : Entity<int>
{
    public Colors()
    {
        
    }
    public Colors(int id , string name)
    {
        Id = id;
        Name = name;
    }
    public string? Name { get; set; }

    public override string ToString()
    {
        return $"Id : {Id} , Name : {Name}";
    }

}
