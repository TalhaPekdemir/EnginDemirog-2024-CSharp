using Day2Assignment3.Business.Abstract;
using Day2Assignment3.DataAccess.Abstract;
using Day2Assignment3.Entities.Concrete;

namespace Day2Assignment3.Business.Concrete;

public class CourseManager : BaseEntityService<Course>
{
    public CourseManager(IEntityDal<Course> entityDal) : base(entityDal)
    {
    }
}
