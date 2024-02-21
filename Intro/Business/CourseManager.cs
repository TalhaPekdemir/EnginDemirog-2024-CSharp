using Intro.Entities;

namespace Intro.Business;

public class CourseManager
{
    Course[] courses;
    public CourseManager()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C# Zero-to-Hero";
        course1.Description = ".NET 8";
        course1.Price = 19.99;

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

        courses = [course1, course2, course3];
    }

    public Course[] GetAll()
    {
        return courses;
    }
}
