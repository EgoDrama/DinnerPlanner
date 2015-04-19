using System;

namespace DinnerPlanner.Domain.Command
{
    public class LogInCommand : Command
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public LogInCommand(Guid id, int version, string username, string password) : base(id, version)
        {
            Username = username;
            Password = password;
        }
    }
}