using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;
        public Service(IUnitOfWork unitOfWork)
        {
            this._repository = unitOfWork.Repository<T>();
            this._unitOfWork = unitOfWork;
        }
        public virtual void Add(T entity)
        {
            this._repository.Add(entity);

        }
        public virtual void Update(T entity)
        {
            this._repository.Update(entity);
        }
        public virtual void Delete(T entity)
        {
            this._repository.Delete(entity);
        }
        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            this._repository.Delete(where);
        }
        public virtual T GetById(object id)
        {
            return this._repository.GetById(id);
        }
        public virtual IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> filter = null)
        {
            return this._repository.GetMany(filter);
        }
        public virtual T Get(Expression<Func<T, bool>> where)
        {
            return this._repository.Get(where);
        }
        public void Commit()
        {
            try
            {
                this._unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        T IService<T>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
