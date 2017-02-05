using Data.Queries.Books.Queries;
using Data.Queries.Books.QueryResults;
using Data.Repositories.Books;
using Data.Repositories.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Queries.Books.QueryHandlers
{
    public class MyBookQueryHandler : IQueryHandler<MyBookQuery, List<BookListDto>>
    {
        private readonly ILibraryRepository _libraryRepository;
        public MyBookQueryHandler(ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }

        public List<BookListDto> Execute(MyBookQuery query)
        {
            var books = _libraryRepository.FindForUser(query.UserId);
            return books.Select(x => new BookListDto(x)).ToList();
        }
    }
}
