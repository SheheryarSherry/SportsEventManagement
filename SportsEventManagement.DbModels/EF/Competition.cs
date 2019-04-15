﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsEventManagement.DbModels.EF
{
   public class Competition
    {
        public int Id { get; set; }
        public Event Event { get; set; }
        public int EventId { get; set; }
        public string Name { get; set; }
        public bool ISActive{ get; set; }
    }
}
