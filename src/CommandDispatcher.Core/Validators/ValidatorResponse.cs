namespace CommandDispatcher.Core.Validators
{
    public class ValidatorResponse
    {
        public string Message { get; }
        public bool Success { get; }
        public string FieldName { get; }

        public static ValidatorResponse Ok(string fieldName) => new ValidatorResponse(true, fieldName);
        public static ValidatorResponse Fail(string fieldName, string message) => new ValidatorResponse(false, fieldName, message);

        protected ValidatorResponse(bool success, string fieldName, string message = "")
        {
            Message = message;
            Success = success;
            FieldName = fieldName;
        }

    }
}