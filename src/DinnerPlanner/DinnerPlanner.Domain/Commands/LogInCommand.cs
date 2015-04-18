using System;

namespace DinnerPlanner.Domain.Commands
{
    public class LogInCommand : Command
    {
        public LogInCommand(Guid id, int version, string username, string password) : base(id, version)
        {
        }
    }
}