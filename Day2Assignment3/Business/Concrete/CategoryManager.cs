using Day2Assignment3.Business.Abstract;
using Day2Assignment3.DataAccess.Abstract;
using Day2Assignment3.Entities.Concrete;

namespace Day2Assignment3.Business.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        this._categoryDal = categoryDal;
    }

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public void Delete(Category category)
    {
        _categoryDal.Delete(category);
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public Category GetById(int id)
    {
        return _categoryDal.GetById(id);
    }

    public void Update(int id, Category category)
    {
        _categoryDal.Update(id, category);
    }
}
