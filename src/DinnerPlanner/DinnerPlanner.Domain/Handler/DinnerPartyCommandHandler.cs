using System;
using DinnerPlanner.Domain.Command;
using DinnerPlanner.Domain.Model;
using DinnerPlanner.Domain.Repository;

namespace DinnerPlanner.Domain.Handler
{
    public class DinnerPartyCommandHandler : ICommandHandler<CreateDinnerPartyCommand>
    {
        private readonly IRepository<DinnerParty> _repository;

        public DinnerPartyCommandHandler(IRepository<DinnerParty> repository)
        {
            _repository = repository;
        }

        public void Execute(CreateDinnerPartyCommand command)
        {
            if (command == null) { throw new ArgumentNullException("command"); }

            var dinnerParty = new DinnerParty
            {
                AggregateRootId = Guid.NewGuid(),
                Version = -1,
                Attendants = command.Attendatns,
                Date = command.Date,
                Dinner = command.Dinner,
                Wine = command.Wine
            };

            _repository.Save(dinnerParty, dinnerParty.Version);
        }
    }
}