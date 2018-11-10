namespace CommandDispatcher.Test.Create
{
    public class CreateCommand
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public CreateCommand()
        {
            
        }
        public CreateCommand(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}