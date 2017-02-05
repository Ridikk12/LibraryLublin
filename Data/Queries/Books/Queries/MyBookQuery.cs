using Data.Queries.Books.QueryResults;
using System.Collections.Generic;

namespace Data.Queries.Books.Queries
{
    public class MyBookQuery : IQuery<List<BookListDto>>
    {
        public string UserId { get; set; }
        public MyBookQuery(string userId)
        {
            UserId = userId;
        }

    }
}
