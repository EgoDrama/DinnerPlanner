using DinnerPlanner.Domain.Application.Commands;

namespace DinnerPlanner.Domain.Handler
{
    public interface ICommandHandler<TCommand> where TCommand : Command
    {
        void Execute(TCommand command);
    }
}