using Data.Commands;
using Data.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Core
{
    public interface IQueryProcessor
    {
        TResult Run<TQuery, TResult>(TQuery query) where TQuery : IQuery<TResult>;

    }
}