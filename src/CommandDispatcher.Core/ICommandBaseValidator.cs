using CommandDispatcher.Core.Validators;

namespace CommandDispatcher.Core
{
    public interface ICommandBaseValidator<in TCommand, in TValidationData> where TValidationData : IValidationData, new()
    {
        ValidatorResponse Validate(TCommand command, TValidationData validationData);
        ValidatorResponse ValidateHandler(TCommand command, TValidationData validationData);
    }
}