namespace CommandDispatcher.Test.Infrastructure.Validators
{
    public abstract class CommandValidator<TCommand, TValidationData> : ICommandBaseValidator<TCommand, TValidationData>, ICommandValidator where TValidationData : IValidationData, new()
    {
        public CommandValidator()
        {

        }
        public ValidatorResponse Validate(TCommand command, TValidationData validationData)
        {
            return ValidateHandler(command, validationData);
        }
        public abstract ValidatorResponse ValidateHandler(TCommand command, TValidationData validationData);
    }
}