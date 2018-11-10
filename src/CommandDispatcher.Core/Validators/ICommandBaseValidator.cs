namespace CommandDispatcher.Core.Validators
{
    public interface ICommandBaseValidator<TCommand, TValidationData> where TValidationData : IValidationData, new()
    {
        ValidatorResponse Validate(TCommand command, TValidationData validationData);
        ValidatorResponse ValidateHandler(TCommand command, TValidationData validationData);
    }
}