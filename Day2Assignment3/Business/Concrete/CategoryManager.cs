using Day2Assignment3.Business.Abstract;
using Day2Assignment3.DataAccess.Abstract;
using Day2Assignment3.Entities.Concrete;

namespace Day2Assignment3.Business.Concrete;

public class CategoryManager : BaseEntityService<Category>
{
    public CategoryManager(IEntityDal<Category> entityDal) : base(entityDal)
    {
    }
}
