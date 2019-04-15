using SportsEventManagement.Data.Infrastructure;
using SportsEventManagement.DbModels.EF;
using SportsEventManagement.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsEventManagement.Data.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(IDbFactory context):base(context)
        {

        }
        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
