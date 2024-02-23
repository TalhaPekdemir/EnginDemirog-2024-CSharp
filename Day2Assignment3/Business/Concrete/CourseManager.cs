using Day2Assignment3.Business.Abstract;
using Day2Assignment3.DataAccess.Abstract;
using Day2Assignment3.Entities.Concrete;

namespace Day2Assignment3.Business.Concrete;

public class CourseManager : BaseEntityService<Course>
{
    public CourseManager(IEntityDal<Course> entityDal) : base(entityDal)
    { }

    public override void Add(Course entity)
    {
        // iş kodları validasyon vs.
        base.Add(entity);
    }

    public override void Delete(Course entity)
    {
        // iş kodları validasyon vs.
        base.Delete(entity);
    }

    public override List<Course> GetAll()
    {
        // iş kodları validasyon vs.
        return base.GetAll();
    }

    public override void Update(int id, Course entity)
    {
        // iş kodları validasyon vs.
        base.Update(id, entity);
    }

    public override Course GetById(int id)
    {
        return base.GetById(id);
    }
}
