using SportsEventManagement.Data.Repositories;
using SportsEventManagement.DbModels;
using SportsEventManagement.Service.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsEventManagement.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbFactory _dbFactory;
        private SportsEventContext _dbContext;


        public UnitOfWork()
        {
            this._dbFactory = new DbFactory();
        }
        public SportsEventContext DbContext
        {
            get
            {
                return _dbContext ?? (_dbContext = _dbFactory.Init());
            }
        }

        IStudentRepository _studentRepository;
        public IStudentRepository StudentRepository
        {
            get { return _studentRepository ?? (_studentRepository = new StudentRepository(_dbFactory)); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
