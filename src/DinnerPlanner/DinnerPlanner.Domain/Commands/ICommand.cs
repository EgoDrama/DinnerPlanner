using System;

namespace DinnerPlanner.Domain.Commands
{
    public interface ICommand
    {
        Guid Id { get; } 
    }
}