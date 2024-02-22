using Day2Assignment3.Entities.Abstarct;

namespace Day2Assignment3.Entities.Concrete;

public class Instructor : IEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
