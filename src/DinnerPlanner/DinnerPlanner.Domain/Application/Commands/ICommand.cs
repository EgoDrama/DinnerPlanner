using System;

namespace DinnerPlanner.Domain.Application.Command
{
    public interface ICommand
    {
        Guid Id { get; } 
    }
}