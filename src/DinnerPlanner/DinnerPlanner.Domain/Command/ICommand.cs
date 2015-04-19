using System;

namespace DinnerPlanner.Domain.Command
{
    public interface ICommand
    {
        Guid Id { get; } 
    }
}