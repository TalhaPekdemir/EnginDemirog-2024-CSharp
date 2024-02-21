namespace Assignment1;

public class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine("Added " + person.FirstName);
    }
    
    public void Update(IPerson person)
    {
        Console.WriteLine("Updated " + person.FirstName);
    }
}
