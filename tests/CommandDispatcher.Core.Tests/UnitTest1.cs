using System.Collections.Generic;
using Autofac;
using CommandDispatcher.Test.Create;
using CommandDispatcher.Test.Create.Validators;
using CommandDispatcher.Test.Infrastructure;
using CommandDispatcher.Test.Infrastructure.Validators;
using Xunit;

namespace CommandDispatcher.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var builder = new ContainerBuilder();
            builder.RegisterGeneric(typeof(CommandHandler<,>))
                .As(typeof(CommandHandler<,>))
                .InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(CommandValidator<,>))
                .As(typeof(CommandValidator<,>))
                .InstancePerLifetimeScope();
            var container = builder.Build();

            var command = new CreateCommand("A", 19);

            var handler = new CreateCommandHandler(new List<ICommandBaseValidator<CreateCommand, CreateCommandData>> { new CreateCommandValidatorAge(), new CreateCommandValidatorName() });

            var response = handler.Execute(command);
        }
    }
}
