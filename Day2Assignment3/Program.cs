using Day2Assignment3.Business.Abstract;
using Day2Assignment3.Business.Concrete;
using Day2Assignment3.DataAccess.Concrete;
using Day2Assignment3.Entities.Abstarct;
using Day2Assignment3.Entities.Concrete;

namespace Day2Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instructor operations
            Console.WriteLine("--------Instructor--------");
            
            Instructor instructor = new Instructor()
            {
                Id = 3,
                FirstName = "Test",
                LastName = "Test2",
                Image = "default.png"
            };

            BaseEntityService<Instructor> instructorManager = new InstructorManager(new InstructorDal());
            
            // insructor ekle
            instructorManager.Add(instructor);
            ListInstructors(instructorManager.GetAll());
            
            // instructor güncelle
            int instrucotrId = 3;
            instructorManager.Update(instrucotrId, new Instructor() { Id= instrucotrId, FirstName="Ali", LastName="Cengiz", Image="alicengiz.png" });
            ListInstructors(instructorManager.GetAll());

            // instructor sil
            instructorManager.Delete(instructorManager.GetById(1));
            ListInstructors(instructorManager.GetAll());


            // category operations
            Console.WriteLine("\n--------Category--------");
            
            Category category = new Category()
            {
                Id = 2,
                Name = "Test Ctg"
            };

            BaseEntityService<Category> categoryManager = new CategoryManager(new CategoryDal());
            
            // category ekle
            categoryManager.Add(category);
            ListCategories(categoryManager.GetAll());

            // category güncelle
            var categoryToUpdate = categoryManager.GetById(2);
            if(categoryToUpdate != null)
            {
            categoryManager.Update(categoryToUpdate.Id, new Category() { Id= categoryToUpdate.Id, Name="Data Science" });
            }
            ListCategories(categoryManager.GetAll());

            // category sil
            categoryManager.Delete(categoryManager.GetById(1));
            ListCategories(categoryManager.GetAll());

            // course operations
            Console.WriteLine("\n--------Course--------");

            Course course = new Course()
            {
                Id = 4,
                CategoryId = 2,
                InstructorId = 3,
                Name = "Python ile Veri Bilimine Giriş",
                Description = "Python TensorFlow ...",
                Price = 10,
                Image = "coursepyvb.png",
                PercentDone = 0
            };

            BaseEntityService<Course> courseService = new CourseManager(new CourseDal());

            // course ekle
            courseService.Add(course);
            ListCourses(courseService.GetAll());

            // course güncelle
            var courseToUpdate = courseService.GetById(4);
            courseToUpdate.PercentDone = 35;
            courseService.Update(courseToUpdate.Id, courseToUpdate);
            ListCourses(courseService.GetAll());

            // course sil
            courseService.Delete(courseToUpdate);
            ListCourses(courseService.GetAll());
        }

        public static void ListInstructors(List<Instructor> instructors)
        {
            Console.WriteLine("\nInstructors: ");
            foreach (var item in instructors)
            {
                Console.WriteLine(item.Id + " " + item.FirstName + " " + item.LastName + " " + item.Image);
            }
        }

        public static void ListCategories(List<Category> categories)
        {
            Console.WriteLine("\nCategories: ");
            foreach (var item in categories)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
        }

        public static void ListCourses(List<Course> courses)
        {
            Console.WriteLine("\nCourses: ");
            foreach (var item in courses)
            {
                Console.WriteLine(item.Id + " " 
                    + item.CategoryId + " " 
                    + item.InstructorId + " " 
                    + item.Name + " " 
                    + item.Description + " " 
                    + item.Price + " " 
                    + item.Image + " " 
                    + item.PercentDone);
            }
        }
    }
}
