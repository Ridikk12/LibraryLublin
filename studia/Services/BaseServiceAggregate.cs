using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Core;

namespace Library.Services
{
    public class BaseServiceAggregate : IBaseServiceAggregate
    {
        public Func<ICommandProcessor> CommandProcessor { get; }

        public Func<IQueryProcessor> QueryProcessor { get; }

        public BaseServiceAggregate(Func<ICommandProcessor> commandProcessor, Func<IQueryProcessor> queryProcessor)
        {
            CommandProcessor = commandProcessor;
            QueryProcessor = queryProcessor;
        }
    }
}