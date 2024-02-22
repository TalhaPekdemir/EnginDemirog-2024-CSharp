using Day2Assignment3.Business.Abstract;
using Day2Assignment3.Business.Concrete;
using Day2Assignment3.DataAccess.Concrete;
using Day2Assignment3.Entities.Concrete;

namespace Day2Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instructor operations
            Instructor instructor = new Instructor()
            {
                Id = 3,
                FirstName = "Test",
                LastName = "Test2",
            };

            BaseEntityService<Instructor> instructorManager = new InstructorManager(new InstructorDal());
            
            instructorManager.Add(instructor);
            var instructorResult = instructorManager.GetAll();

            foreach (var item in instructorResult)
            {
                Console.WriteLine(item.Id + " " + item.FirstName + " " + item.LastName);
            }


            // category operations
            Category category = new Category()
            {
                Id = 2,
                Name = "Test Category"
            };

            BaseEntityService<Category> categoryManager = new CategoryManager(new CategoryDal());
            categoryManager.Add(category);
            var categoryResult = categoryManager.GetAll();

            foreach (var item in categoryResult)
            {
                Console.WriteLine(item.Id + " " +item.Name);
            }

            categoryManager.Update(1, category);

            Console.WriteLine("Updated Categories:");
            foreach (var item in categoryResult)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
        }
    }
}
