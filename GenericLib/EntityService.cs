using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLib
{
    public interface IService
    {
    }
    public interface IEntityService<T> : IService
    where T : BaseEntity
    {
        void Create(T entity);
        //void Delete(T entity);
        //IEnumerable<T> GetAll();
        //void Update(T entity);
    }
    public abstract class EntityService<T> : IEntityService<T> where T : BaseEntity
    {
        IUnitOfWork _unitOfWork;
        IGenericRepository<T> _repository;

        public EntityService(IUnitOfWork unitOfWork, IGenericRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public void Create(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
