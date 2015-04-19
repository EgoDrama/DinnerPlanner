using System;
using DinnerPlanner.Domain.Command;
using DinnerPlanner.Domain.Security;

namespace DinnerPlanner.Domain.Handler
{
    public class LogInCommandHandler : ICommandHandler<LogInCommand>
    {
        private readonly ILoginManager _loginManager;

        public LogInCommandHandler(ILoginManager loginManager)
        {
            _loginManager = loginManager;
        }

        public void Execute(LogInCommand command)
        {
            if (command == null) { throw new ArgumentNullException("command"); }

            var credentialsIsCorrect = _loginManager.Login(command.Username, command.Password);
        }
    }
}