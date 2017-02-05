using Data.Queries.Books.Queries;
using Data.Queries.Books.QueryResults;
using Data.Repositories.Books;
using Data.Repositories.Library;

namespace Data.Queries.Books.QueryHandlers
{
    class BookDetailsQueryHandler : IQueryHandler<BookDetailsQuery, BookDetailsDto>
    {
        private readonly IBookReposiotry _bookRepository;
        private readonly ILibraryRepository _libraryRepository;
        public BookDetailsQueryHandler(ILibraryRepository libraryRepository,IBookReposiotry bookRepository)
        {
            _bookRepository = bookRepository;
            _libraryRepository = libraryRepository;
        }

        public BookDetailsDto Execute(BookDetailsQuery query)
        {
            var book = _bookRepository.Find(query.BookId);
            var predictedReturnDate = _libraryRepository.GetPredictedReturnDate(query.BookId);

            return new BookDetailsDto(book, predictedReturnDate);
        }
    }
}
