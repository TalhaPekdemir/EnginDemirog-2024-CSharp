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
        // iş kodları validasyon vs.
        return base.GetAll();
    }

    public override void Add(Instructor entity)
    {
        // iş kodları validasyon vs.
        base.Add(entity);
    }

    public override void Delete(Instructor entity)
    {
        // iş kodları validasyon vs.
        base.Delete(entity);
    }

    public override void Update(int id, Instructor entity)
    {
        // iş kodları validasyon vs.
        base.Update(id, entity);
    }

    public override Instructor GetById(int id)
    {
        return base.GetById(id);
    }
}
