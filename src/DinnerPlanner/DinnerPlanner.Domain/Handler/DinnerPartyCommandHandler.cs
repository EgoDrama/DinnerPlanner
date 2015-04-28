using System;
using Common.Repository;
using DinnerPlanner.Domain.Application.Commands;
using DinnerPlanner.Domain.Domain.Model;

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

            var aggregate = new DinnerParty
            {
                AggregateRootId = Guid.NewGuid(),
                Version = -1
            };

            _repository.Save(aggregate, aggregate.Version);
        }
    }
}