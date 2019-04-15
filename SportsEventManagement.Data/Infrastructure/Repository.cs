using SportsEventManagement.DbModels;
using SportsEventManagement.Service.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SportsEventManagement.Data.Infrastructure
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private SportsEventContext _dbContext;
        private DbSet<T> dbset;
        protected IDbFactory DbFactory
        {
            get;
            private set;
        }
        public SportsEventContext DbContext
        {
            get
            {
                return _dbContext ?? (_dbContext = DbFactory.Init());
            }
        }
        public Repository(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            dbset = DbContext.Set<T>();
        }
        public void Add(T entity)
        {
            dbset.Add(entity);
        }

        public void AddRange(IEnumerable<T> entitylist)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
