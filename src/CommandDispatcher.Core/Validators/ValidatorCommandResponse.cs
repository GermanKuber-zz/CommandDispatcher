using System.Collections.Generic;

namespace CommandDispatcher.Core.Validators
{
    public class ValidatorCommandResponse
    {
        public IReadOnlyCollection<ValidatorResponse> ValidatorResponses => _validatorResponses.AsReadOnly();

        private readonly List<ValidatorResponse> _validatorResponses;
        public bool Success { get; set; }

        public static ValidatorCommandResponse Ok(List<ValidatorResponse> validatorResponses) => new ValidatorCommandResponse(true, validatorResponses);
        public static ValidatorCommandResponse Fail(List<ValidatorResponse> validatorResponses) => new ValidatorCommandResponse(false, validatorResponses);

        protected ValidatorCommandResponse(bool success, List<ValidatorResponse> validatorResponses)
        {
            _validatorResponses = validatorResponses;
            Success = success;
        }

    }
}