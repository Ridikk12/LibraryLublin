using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Queries.Books.QueryResults
{
    public class BookDetailsDto
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string PublishingHouse { get; set; }
        public byte[] Image { get; set; }
        public bool Avalibe { get; set; }
        public int BookSize { get; set; }
        public DateTime? PredictedBookReturn {get; set;}

        public BookDetailsDto(Book book, DateTime? predictedBookReturn)
        {
            BookId = book.BookId;
            BookName = book.BookName;
            BookAuthor = book.BookAuthor;
            PublishingHouse = book.PublishingHouse;
            Image = book.Image;
            Avalibe = book.Quantity > 0;
            BookSize = book.BookSize;
            PredictedBookReturn = predictedBookReturn;


        }
    }
}
