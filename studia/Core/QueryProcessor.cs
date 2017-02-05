using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data.Queries;

namespace Library.Core
{
    public class QueryProcessor : IQueryProcessor
    {

        private ILifetimeScope _lifeTimeScope;

        public QueryProcessor(ILifetimeScope lifeTimeScope)
        {
            _lifeTimeScope = lifeTimeScope;
        }

        public TResult Run<TQuery, TResult>(TQuery query) where TQuery : IQuery<TResult>
        {
            var queryHandler = _lifeTimeScope.Resolve<IEnumerable<IQueryHandler<TQuery, TResult>>>();
            return queryHandler.First().Execute(query);
        }
    }
}