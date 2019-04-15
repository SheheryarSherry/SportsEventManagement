using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsEventManagement.DbModels.EF
{
   public class Event
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Sports Sports { get; set; }
        public bool IsActive { get; set; }

    }
}
