using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Queries
{
    public interface IQueryHandler<TQuery, out TResult> : IQueryHandler where TQuery : IQuery
    {
        TResult Execute(TQuery query);
    }

    public interface IQueryHandler
    {


    }
}
