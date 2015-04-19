namespace DinnerPlanner.Domain.Handler
{
    public interface ICommandHandler<TCommand> where TCommand : Command.Command
    {
        void Execute(TCommand command);
    }
}