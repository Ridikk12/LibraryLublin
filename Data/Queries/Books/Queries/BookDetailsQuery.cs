using Data.Queries.Books.QueryResults;

namespace Data.Queries.Books.Queries
{
    public class BookDetailsQuery : IQuery<BookDetailsDto>
    {
        public int BookId { get; set; }
        public BookDetailsQuery(int  bookId)
        {
            BookId = bookId;
        }
    }
}
