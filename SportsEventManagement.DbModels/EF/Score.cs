using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsEventManagement.DbModels.EF
{
   public class Score
    {
        public int Id { get; set; }
        public Match Match { get; set; }
        public int MatchId { get; set; }
        public Participant Participant { get; set; }
        public int ParticipantId { get; set; }
        public int score { get; set; }

    }
}
