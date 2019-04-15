using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsEventManagement.Service.Interface
{
   public interface IUnitOfWork
    {
        IStudentRepository StudentRepository { get;  }

        void Commit();
    }
}
