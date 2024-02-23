using Day2Assignment3.Entities.Concrete;

namespace Day2Assignment3.Business.Abstract;

public interface IInstructorService
{
    List<Instructor> GetAll();
    Instructor GetById(int id);
    void Add(Instructor instructor);
    void Delete(Instructor instructor);
    void Update(int id, Instructor instructor);
}
