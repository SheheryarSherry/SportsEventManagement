using SportsEventManagement.DbModels.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsEventManagement.DbModels
{
    public class SportsEventContext:DbContext
    {
        public SportsEventContext():base("DefaultConnection")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Event> Events  { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Score> scores { get; set; }
        public DbSet<Sports> Sports { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamManagment> TeamManagments { get; set; }
    }
}
