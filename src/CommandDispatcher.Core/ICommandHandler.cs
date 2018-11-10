using CommandDispatcher.Core.Validators;

namespace CommandDispatcher.Core
{
    public interface ICommandHandler<TCommand>
    {
        ValidatorCommandResponse Execute(TCommand command);
    }
}