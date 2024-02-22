using Day2Assignment3.Business.Abstract;
using Day2Assignment3.DataAccess.Abstract;
using Day2Assignment3.Entities.Concrete;

namespace Day2Assignment3.Business.Concrete;

public class InstructorManager : BaseEntityService<Instructor>
{
    public InstructorManager(IEntityDal<Instructor> entityDal) : base(entityDal)
    {
    }

    public override List<Instructor> GetAll()
    {
        return base.GetAll();
    }

    public override void Add(Instructor entity)
    {
        base.Add(entity);
    }

    public override void Delete(Instructor entity)
    {
        base.Delete(entity);
    }

    public override void Update(int id, Instructor entity)
    {
        base.Update(id, entity);
    }
}
