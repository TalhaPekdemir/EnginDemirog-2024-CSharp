using Intro.DataAccess.Abstracts;
using Intro.Entities;

namespace Intro.DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> courses;
    public CourseDal()
    {
        Course course1 = new Course()
        {
            Id = 1,
            Name = "C# Zero-to-Hero",
            Description = ".NET 8",
            Price = 19.99
        };

        Course course2 = new Course()
        {
            Id = 2,
            Name = "Data Science with Python",
            Description = "TensorFlow 2.15",
            Price = 99.99
        };

        Course course3 = new Course()
        {
            Id = 3,
            Name = "Java is not legacy code!!",
            Description = "Java 17",
            Price = 29.99
        };

        courses = new List<Course> { course1, course2, course3 };
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }

    public List<Course> GetAll()
    {
        return courses;
    }
}