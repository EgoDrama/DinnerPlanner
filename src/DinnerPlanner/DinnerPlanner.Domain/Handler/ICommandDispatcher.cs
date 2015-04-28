using DinnerPlanner.Domain.Application.Commands;

namespace DinnerPlanner.Domain.Handler
{
    public interface ICommandDispatcher
    {
        void Dispatch(ICommand command);
    }
}