using CommandDispatcher.Core.Validators;

namespace CommandDispatcher.Test.Create.Validators
{
    public class CreateCommandValidatorName : CommandValidator<CreateCommand, CreateCommandData>
    {
        public override ValidatorResponse ValidateHandler(CreateCommand command, CreateCommandData validationData)
        {
            if (command.Name == "A")
            {
                validationData.Name = command.Name;
                return ValidatorResponse.Ok(nameof(command.Name));
            }
            return ValidatorResponse.Fail(nameof(command.Name),"Age Error");
        }

        public CreateCommandValidatorName()
        {
            
        }
    }
}