using System;
using System.Collections.Generic;
using DinnerPlanner.Domain.Domain.Model;

namespace DinnerPlanner.Domain.Application.Commands
{
    public class CreateDinnerPartyCommand : Command
    {
        public DateTime Date { get; set; }
        public IEnumerable<Attendant> Attendatns { get; set; }
        public Dinner Dinner { get; set; }
        public Wine Wine { get; set; }

        public CreateDinnerPartyCommand(Guid id, int version, DateTime date, IEnumerable<Attendant> attendants, Dinner dinner, Wine wine) : base(id, version)
        {
            Date = date;
            Attendatns = attendants;
            Dinner = dinner;
            Wine = wine;
        }
    }
}