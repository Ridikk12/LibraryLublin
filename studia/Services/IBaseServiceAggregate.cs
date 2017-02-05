using Library.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Services
{
    public interface IBaseServiceAggregate
    {
        Func<ICommandProcessor> CommandProcessor { get; }
        Func<IQueryProcessor> QueryProcessor { get; }

    }
}