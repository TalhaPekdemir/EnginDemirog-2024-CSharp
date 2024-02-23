using Day2Assignment3.Entities.Concrete;

namespace Day2Assignment3.Business.Abstract;

public interface ICourseService
{
    List<Course> GetAll();
    Course GetById(int id);
    void Add(Course course);
    void Delete(Course course);
    void Update(int id, Course course);
}
