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
    public class BookListQueryHandler : IQueryHandler<BookListQuery, List<BookListDto>>
    {
        private readonly IBookReposiotry _bookRepository;


        public BookListQueryHandler(IBookReposiotry bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public List<BookListDto> Execute(BookListQuery query)
        {
            var books = _bookRepository.FindAll();
            return books.Select(x => new BookListDto(x)).OrderBy(x=> x.BookAuthor).ToList();

        }
    }
}
