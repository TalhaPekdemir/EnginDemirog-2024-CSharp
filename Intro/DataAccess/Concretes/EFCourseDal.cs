using Intro.DataAccess.Abstracts;
using Intro.Entities;

namespace Intro.DataAccess.Concretes;

public class EFCourseDal : ICourseDal
{
    List<Course> courses;
    public EFCourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "JavaScript";
        course1.Description = "ES6";
        course1.Price = 39.99;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "Data Science with Python";
        course2.Description = "TensorFlow 2.15";
        course2.Price = 99.99;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "Java is not legacy code!!";
        course3.Description = "Java 17";
        course3.Price = 29.99;

        courses = new List<Course> { course1, course2, course3 };
    }

    public List<Course> GetAll()
    {
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
}
