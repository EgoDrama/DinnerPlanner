using System;
using System.Collections.Generic;
using Common.Domain.Model;

namespace DinnerPlanner.Domain.Domain.Model
{
    public class DinnerParty : AggregateRoot
    {
        public IEnumerable<Attendant> Attendants { get; set; }
        public DateTime Date { get; set; }
        public Dinner Dinner { get; set; }
        public Wine Wine { get; set; }
        public Grade Grade { get; set; }
    }
}