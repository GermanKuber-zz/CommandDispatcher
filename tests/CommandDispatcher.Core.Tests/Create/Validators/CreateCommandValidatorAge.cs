using CommandDispatcher.Test.Infrastructure.Validators;

namespace CommandDispatcher.Test.Create.Validators
{
    public class CreateCommandValidatorAge : CommandLastValidator<CreateCommand, CreateCommandData>
    {
        public override ValidatorResponse ValidateHandler(CreateCommand command, CreateCommandData validationData)
        {
            if (command.Age > 18)
            {
                validationData.Age = command.Age;
                return ValidatorResponse.Ok(nameof(command.Age));
            }
            return ValidatorResponse.Fail(nameof(command.Age),"Age Error");

        }
    }
}