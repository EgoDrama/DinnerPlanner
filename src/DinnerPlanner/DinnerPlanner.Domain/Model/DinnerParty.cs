using System.Collections.Generic;

namespace DinnerPlanner.Domain.Model
{
    public class DinnerParty : AggregateRoot
    {
        public IEnumerable<Attendant> Attendants { get; set; }
    }
}