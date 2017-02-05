using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Queries.Books.QueryResults
{
    public class RecentlyAddedBookDto
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string PublishingHouse { get; set; }
        public byte[] Image { get; set; }
        public DateTime CreatedDate { get; set; }

        public RecentlyAddedBookDto(Book book)
        {
            BookId = book.BookId;
            BookName = book.BookName;
            BookAuthor = book.BookAuthor;
            PublishingHouse = book.PublishingHouse;
            Image = book.Image;
            CreatedDate = book.CreatedDate;
        }
    }
}
