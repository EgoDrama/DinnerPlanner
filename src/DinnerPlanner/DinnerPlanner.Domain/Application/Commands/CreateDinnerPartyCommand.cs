using System;
using System.Collections.Generic;
using DinnerPlanner.Domain.Domain.Model;

namespace DinnerPlanner.Domain.Application.Command
{
    public class CreateDinnerPartyCommand : Command
    {
        public DateTime Date { get; set; }
        public IEnumerable<Attendant> Attendatns { get; set; }
        public Dinner Dinner { get; set; }
        public Wine Wine { get; set; }

        public CreateDinnerPartyCommand(Guid id, int version, DinnerParty dinnerParty) : base(id, version)
        {
            Date = dinnerParty.Date;
            Attendatns = dinnerParty.Attendants;
            Dinner = dinnerParty.Dinner;
            Wine = dinnerParty.Wine;
        }
    }
}