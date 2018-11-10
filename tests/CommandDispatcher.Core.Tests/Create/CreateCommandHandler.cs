using System;
using System.Collections.Generic;
using CommandDispatcher.Core;

namespace CommandDispatcher.Test.Create
{
    public class CreateCommandHandler: CommandHandler<CreateCommand, CreateCommandData> 
    {
        public CreateCommandHandler(List<ICommandBaseValidator<CreateCommand, CreateCommandData>> validatorsList) : base(validatorsList)
        {
            
        }

        protected override void ExecuteHandler(CreateCommand command, CreateCommandData validationData)
        {
            Console.WriteLine($"Command Age: {command.Age}, Validation Data Age: {validationData.Age}");
            Console.WriteLine($"Command Name: {command.Name}, Validation Data Name : {validationData.Name}");
        }
    }
}