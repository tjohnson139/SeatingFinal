﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seating.Models
{
    public class Lunch
    {
        public DateTime LunchTime { get; set; }
        public int LunchID { get; set; }
        public int EmployeeID { get; set; }
        public int PositionID { get; set; }
        public bool LongerLunch { get; set; }
        public bool Double { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Position Position { get; set; }
    }
}