using System;

namespace DinnerPlanner.Domain.Application.Commands
{
    public interface ICommand
    {
        Guid Id { get; } 
    }
}