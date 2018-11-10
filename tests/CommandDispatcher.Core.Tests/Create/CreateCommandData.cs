using CommandDispatcher.Core;

namespace CommandDispatcher.Test.Create
{
    public class CreateCommandData: IValidationData
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}