using Day2Assignment3.DataAccess.Abstract;
using Day2Assignment3.Entities.Concrete;

namespace Day2Assignment3.DataAccess.Concrete;

public class CategoryDal : IEntityDal<Category>
{
    List<Category> _categories;
    public CategoryDal()
    {
        _categories = new List<Category>()
        {
            new Category(){ Id=1, Name="Programlama" }
        };
    }

    public void Add(Category entity)
    {
        _categories.Add(entity);
    }

    public void Delete(Category entity)
    {
        _categories.Remove(entity);
    }

    public List<Category> GetAll()
    {
        return _categories;
    }

    public void Update(int id, Category entity)
    {
        var result = _categories.FindIndex(c => c.Id == id);
        if (result != -1)
        {
            _categories[result] = entity;
        }
    }
}
