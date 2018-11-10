namespace CommandDispatcher.Core.Validators
{
    public abstract class CommandLastValidator<TCommand, TValidationData> : ICommandBaseValidator<TCommand, TValidationData>, ICommandLastValidator where TValidationData : IValidationData, new()
    {
        public ValidatorResponse Validate(TCommand command, TValidationData validationData)
        {
            return ValidateHandler(command, validationData);
        }

        public abstract ValidatorResponse ValidateHandler(TCommand command, TValidationData validationData);
    }
}