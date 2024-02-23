using Day2Assignment3.Business.Abstract;
using Day2Assignment3.DataAccess.Abstract;
using Day2Assignment3.Entities.Concrete;

namespace Day2Assignment3.Business.Concrete;

public class CourseManager : ICourseService
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Delete(Course course)
    {
        _courseDal.Delete(course);
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public Course GetById(int id)
    {
        return _courseDal.GetById(id);
    }

    public void Update(int id, Course course)
    {
        _courseDal.Update(id, course);
    }
}
