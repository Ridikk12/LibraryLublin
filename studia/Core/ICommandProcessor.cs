using Data.Commands;


namespace Library.Core
{
    public interface ICommandProcessor
    {
        CommandResult Run<TCommand>(TCommand command) where TCommand: ICommand;
        CommandResult Run(ICommand command);
    }
}