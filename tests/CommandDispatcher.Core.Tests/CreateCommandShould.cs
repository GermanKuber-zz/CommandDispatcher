using System.Collections.Generic;
using Autofac;
using CommandDispatcher.Core;
using CommandDispatcher.Core.Validators;
using CommandDispatcher.Test.Create;
using CommandDispatcher.Test.Create.Validators;
using FluentAssertions;
using Xunit;

namespace CommandDispatcher.Test
{
    public class CreateCommandShould
    {
        [Fact]
        public void Success()
        {

            var command = new CreateCommand("A", 19);

            var handler = new CreateCommandHandler(new List<ICommandBaseValidator<CreateCommand, CreateCommandData>> { new CreateCommandValidatorAge(), new CreateCommandValidatorName() });

            var response = handler.Execute(command);
            response.Success.Should().Be(true);
        }

        [Fact]
        public void Fail_One_Error()
        {

            var command = new CreateCommand("A", 17);

            var handler = new CreateCommandHandler(new List<ICommandBaseValidator<CreateCommand, CreateCommandData>> { new CreateCommandValidatorAge(), new CreateCommandValidatorName() });

            var response = handler.Execute(command);

            response.Success.Should().Be(false);
            response.ValidatorResponses.Count.Should().Be(1);
        }


        //[Fact]
        //public void Injection()
        //{
        //    var builder = new ContainerBuilder();
        //    builder.RegisterGeneric(typeof(CommandHandler<,>))
        //        .As(typeof(CommandHandler<,>))
        //        .InstancePerLifetimeScope();
        //    builder.RegisterGeneric(typeof(CommandValidator<,>))
        //        .As(typeof(ICommandBaseValidator<,>))
        //        .InstancePerLifetimeScope();
        //    var container = builder.Build();
        //    using (var scope = container.BeginLifetimeScope())
        //    {
        //        var reader = scope.Resolve<ICommandBaseValidator<CreateCommand, CreateCommandData>>();
        //    }
        //}

     
    }
}
