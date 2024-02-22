using Day2Assignment3.DataAccess.Abstract;
using Day2Assignment3.Entities.Concrete;

namespace Day2Assignment3.DataAccess.Concrete;

public class InstructorDal : IEntityDal<Instructor>
{
    List<Instructor> _instructors;
    public InstructorDal()
    {
        _instructors = new List<Instructor>()
        {
            new Instructor(){ Id=1, FirstName="Engin", LastName="Demirog" },
            new Instructor(){ Id=2, FirstName="Halit Enes", LastName="Kalaycı" }
        };
    }

    public void Add(Instructor entity)
    {
        _instructors.Add(entity);
    }

    public void Delete(Instructor entity)
    {
        _instructors.Remove(entity);
    }

    public List<Instructor> GetAll()
    {
        return _instructors;
    }

    public void Update(int id, Instructor entity)
    {
        var result = _instructors.FindIndex(c => c.Id == id);
        if (result != -1)
        {
            _instructors[result] = entity;
        }
    }
}
