using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data.Commands
{
    public interface ICommandHandler<in T> : IHandler where T: ICommand
    {
        CommandResult Handle(T command);
    }
}