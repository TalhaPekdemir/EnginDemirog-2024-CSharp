using Day2Assignment3.Entities.Abstarct;

namespace Day2Assignment3.Entities.Concrete;

public class Category : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
}
