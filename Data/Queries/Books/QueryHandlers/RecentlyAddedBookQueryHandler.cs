using Data.Queries.Books.Queries;
using Data.Queries.Books.QueryResults;
using Data.Repositories.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Queries.Books.QueryHandlers
{
    public class RecentlyAddedBookQueryHandler : IQueryHandler<RecentlyAddedBookQuery, List<RecentlyAddedBookDto>>
    {
        private IBookReposiotry _bookRepository;

        public RecentlyAddedBookQueryHandler(IBookReposiotry bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public List<RecentlyAddedBookDto> Execute(RecentlyAddedBookQuery query)
        {
            var books = _bookRepository.RecentlyAdded();
            return books.Select(x => new RecentlyAddedBookDto(x)).ToList();
        }
    }
}
