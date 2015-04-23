using System;
using Common.Repository;
using DinnerPlanner.Domain.Application.Command;
using DinnerPlanner.Domain.Domain.Model;
using DinnerPlanner.Domain.Handler;
using Moq;
using NUnit.Framework;

namespace DinnerPlanner.Domain.Tests.Handler
{
    [TestFixture]
    public class DinnerPartyCommandHandlerTests
    {
        [Test]
        public void Aggreagate_is_saved_when_command_is_received()
        {
            // arrange
            var dinnerPartyRepository = new Mock<IRepository<DinnerParty, IAggregate>>();
            var dinnerPartyCommandHandler = new DinnerPartyCommandHandler(dinnerPartyRepository.Object);
            var dinnerParty = new DinnerParty();
            var createDinnerPartyCommand = new CreateDinnerPartyCommand(Guid.Empty, -1, dinnerParty);

            // act
            dinnerPartyCommandHandler.Execute(createDinnerPartyCommand);

            //assert
            dinnerPartyRepository.Verify(x => x.Save(It.IsAny<DinnerParty>(), It.IsAny<int>()), Times.Once);
        }
    }
}