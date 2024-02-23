using Day2Assignment3.Entities.Concrete;

namespace Day2Assignment3.Business.Abstract;

public interface ICategoryService
{
    List<Category> GetAll();
    Category GetById(int id);
    void Add(Category category);
    void Delete(Category category);
    void Update(int id, Category category);
}
