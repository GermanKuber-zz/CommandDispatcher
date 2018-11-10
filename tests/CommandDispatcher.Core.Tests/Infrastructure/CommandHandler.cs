using System.Collections.Generic;
using CommandDispatcher.Test.Infrastructure.Validators;

namespace CommandDispatcher.Test.Infrastructure
{
    public abstract class CommandHandler<TCommand, TValidationData> where TValidationData : IValidationData, new()
    {
        private readonly TValidationData _validationData = new TValidationData();
        private readonly List<ICommandBaseValidator<TCommand, TValidationData>> _validatorList;


        public CommandHandler(List<ICommandBaseValidator<TCommand, TValidationData>> validatorsList)
        {
            _validatorList = validatorsList;
        }

        public ValidatorCommandResponse Execute(TCommand command)
        {
            var success = true;
            var responseList = new List<ValidatorResponse>();
            foreach (var commandValidator in _validatorList)
            {
                var response = commandValidator.ValidateHandler(command, _validationData);
                responseList.Add(response);
                if (!response.Success)
                {
                    success = false;
                    if (commandValidator is ICommandLastValidator)
                        return ValidatorCommandResponse.Fail(responseList);
                }
            }
            ExecuteHandler(command, _validationData);
            if (success)
                return ValidatorCommandResponse.Ok(responseList);
            return ValidatorCommandResponse.Ok(responseList);
        }
        protected abstract void ExecuteHandler(TCommand command, TValidationData validationData);
    }

}