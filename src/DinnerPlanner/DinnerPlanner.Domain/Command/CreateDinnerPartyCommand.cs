using System;

namespace DinnerPlanner.Domain.Command
{
    public class CreateDinnerPartyCommand : Command
    {
       public CreateDinnerPartyCommand(Guid id, int version) : base(id, version)
        {
        }
    }
}