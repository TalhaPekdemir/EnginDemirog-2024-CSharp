using Day2Assignment3.DataAccess.Abstract;

namespace Day2Assignment3.Business.Abstract
{
    public abstract class BaseEntityService<T>
    {
        private readonly IEntityDal<T> _entityDal;

        public BaseEntityService(IEntityDal<T> entityDal)
        {
            _entityDal = entityDal;
        }

        public virtual List<T> GetAll()
        {
            return _entityDal.GetAll();
        }

        public virtual void Add(T entity)
        {
            _entityDal.Add(entity);
        }

        public virtual void Delete(T entity)
        {
            _entityDal.Delete(entity);
        }

        public virtual void Update(int id, T entity)
        {
            _entityDal.Update(id, entity);
        }

        public virtual T GetById(int id)
        {
            return  _entityDal.GetById(id);
        }
    }
}
