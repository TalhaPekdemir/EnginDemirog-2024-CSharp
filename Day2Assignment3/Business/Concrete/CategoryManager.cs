using Day2Assignment3.Business.Abstract;
using Day2Assignment3.DataAccess.Abstract;
using Day2Assignment3.Entities.Concrete;

namespace Day2Assignment3.Business.Concrete;

public class CategoryManager : BaseEntityService<Category>
{
    public CategoryManager(IEntityDal<Category> entityDal) : base(entityDal)
    { }

    public override void Add(Category entity)
    {
        // iş kodları validasyon vs.
        base.Add(entity);
    }

    public override void Delete(Category entity)
    {
        // iş kodları validasyon vs.
        base.Delete(entity);
    }

    public override List<Category> GetAll()
    {
        // iş kodları validasyon vs.
        return base.GetAll();
    }

    public override void Update(int id, Category entity)
    {
        // iş kodları validasyon vs.
        base.Update(id, entity);
    }

    public override Category GetById(int id)
    {
        return base.GetById(id);
    }
}
