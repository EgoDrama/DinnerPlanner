﻿using System;
using System.Collections.Generic;

namespace DinnerPlanner.Domain.Model
{
    public class DinnerParty : AggregateRoot
    {
        public IEnumerable<Attendant> Attendants { get; set; }
        public DateTime Date { get; set; }
        public Dinner Dinner { get; set; }
        public Wine Wine { get; set; }
    }
}