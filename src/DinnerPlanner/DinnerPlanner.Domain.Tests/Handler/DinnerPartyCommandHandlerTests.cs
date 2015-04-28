using System;
using System.Collections.Generic;
using Common.Repository;
using DinnerPlanner.Domain.Application.Commands;
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
            var dinnerPartyRepository = new Mock<IRepository<DinnerParty>>();
            var dinnerPartyCommandHandler = new DinnerPartyCommandHandler(dinnerPartyRepository.Object);
            
            var date = DateTime.Now;
            var attendants = new List<Attendant>();
            var dinner = new Dinner();
            var wine = new Wine();
            var createDinnerPartyCommand = new CreateDinnerPartyCommand(Guid.Empty, -1, date, attendants, dinner, wine);

            // act
            dinnerPartyCommandHandler.Execute(createDinnerPartyCommand);

            //assert
            dinnerPartyRepository.Verify(x => x.Save(It.IsAny<DinnerParty>(), It.IsAny<int>()), Times.Once);
        }
    }
}