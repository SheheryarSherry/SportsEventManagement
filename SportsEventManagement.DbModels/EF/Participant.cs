﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SportsEventManagement.DbModels.EF
{
   public class Participant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

    }
}
