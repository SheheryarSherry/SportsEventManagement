using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsEventManagement.DbModels.EF
{
   public class Match
    {
        public int Id { get; set; }
        public Team Team { get; set; } 
        public int teamId { get; set; }
        public bool IsActive { get; set; }
    }
}
