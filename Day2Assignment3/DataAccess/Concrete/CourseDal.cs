using Day2Assignment3.DataAccess.Abstract;
using Day2Assignment3.Entities.Concrete;

namespace Day2Assignment3.DataAccess.Concrete;

public class CourseDal : ICourseDal
{ 
    List<Course> _courses;
    public CourseDal()
    {
        _courses = new List<Course>()
        {
            new Course(){ Id=1, CategoryId=1, InstructorId=1, Name="Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)", Description="Senior Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.", Price=0, Image="image.png", PercentDone=0},
            new Course(){ Id=2, CategoryId=1, InstructorId=1, Name="Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)", Description="2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.", Price=0, Image="image.png", PercentDone=0},
            new Course(){ Id=3, CategoryId=1, InstructorId=2, Name="(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium", Description="Python & Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.", Price=0, Image="image.png", PercentDone=0},
        };
    }

    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public void Delete(Course course)
    {
        _courses.Remove(course);
    }

    public List<Course> GetAll()
    {
        return _courses;
    }

    public Course GetById(int id)
    {
        return _courses.Find(c=> c.Id == id);
    }

    public void Update(int id, Course course)
    {
        var result = _courses.FindIndex(c => c.Id == id);
        if (result != -1)
        {
            _courses[result] = course;
        }
    }
}
