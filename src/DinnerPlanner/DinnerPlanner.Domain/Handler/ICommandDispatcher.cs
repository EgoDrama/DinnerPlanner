using DinnerPlanner.Domain.Command;

namespace DinnerPlanner.Domain.Handler
{
    public interface ICommandDispatcher
    {
        void Dispatch(ICommand command);
    }
}