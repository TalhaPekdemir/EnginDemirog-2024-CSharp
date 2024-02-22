using Day2Assignment3.Entities.Abstarct;

namespace Day2Assignment3.Entities.Concrete;

public class Course : IEntity
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public int InstructorId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Image { get; set; }
    public int PercentDone { get; set; }
}
