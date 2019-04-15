using SportsEventManagement.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsEventManagement.Data.Infrastructure
{
   public interface IDbFactory
    {
        SportsEventContext Init();
    }
}
