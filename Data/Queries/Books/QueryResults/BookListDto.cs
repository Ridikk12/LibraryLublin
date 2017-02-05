using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Queries.Books.QueryResults
{
    public class BookListDto
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string PublishingHouse { get; set; }
        public byte [] Image { get; set; }
        public BookListDto(Book book)
        {
            BookId = book.BookId;
            BookName = book.BookName;
            BookAuthor = book.BookAuthor;
            PublishingHouse = book.PublishingHouse;
            Image = book.Image;

        }
        public BookListDto(BookRental book)
        {
            BookId = book.RentedBook.BookId;
            BookName = book.RentedBook.BookName;
            BookAuthor = book.RentedBook.BookAuthor;
            PublishingHouse = book.RentedBook.PublishingHouse;
            Image = book.RentedBook.Image;
        }
    }
}
