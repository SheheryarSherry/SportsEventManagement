using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsEventManagement.DbModels;

namespace SportsEventManagement.Data.Infrastructure
{
    public class DbFactory : IDbFactory
    {
        public SportsEventContext _dbContext;
        public DbFactory()
        {
            Init();
        }
        public SportsEventContext Init()
        {
            return _dbContext ?? (_dbContext = new SportsEventContext());
        }
    }
}
