using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsEventManagement.DbModels.EF
{
   public class TeamManagment
    {
        public int Id { get; set; }
        public Team Team { get; set; }
        public int TeamId { get; set; }
        public Competition Competition { get; set; }
        public int CompetitionId { get; set; }
        public bool IsActive { get; set; }
    }
}
