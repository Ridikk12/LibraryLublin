using Autofac;
using Data.Commands;
using System;

namespace Library.Core
{
    public class CommandProcessor : ICommandProcessor
    {
        private ILifetimeScope _lifeTimeScope;

        public CommandProcessor(ILifetimeScope scope)
        {
            if (scope == null)
                throw new ArgumentException("Lifetimescope null");
            _lifeTimeScope = scope;
        }

        public CommandResult Run<TCommand>(TCommand command) where TCommand : ICommand
        {
            var _resolvedHandlers = _lifeTimeScope.Resolve<ICommandHandler<TCommand>>();
           return _resolvedHandlers.Handle(command);
        }

        public CommandResult Run(ICommand command)
        {
            Type commandHandlerType = typeof(ICommandHandler<>).MakeGenericType(command.GetType());
            dynamic handler = _lifeTimeScope.Resolve(commandHandlerType);
            return handler.Handle((dynamic)command);
        }

    }
}