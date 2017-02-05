using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Queries.Library.QueryResult
{
    public class UserBookListDto
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string PublishingHouse { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool Returned { get; set; }

        public UserBookListDto(BookRental rentedBook)
        {
            BookId = rentedBook.RentedBook.BookId;
            BookName = rentedBook.RentedBook.BookName;
            BookAuthor = rentedBook.RentedBook.BookAuthor;
            PublishingHouse = rentedBook.RentedBook.PublishingHouse;
            RentDate = rentedBook.RentDate;
            ReturnDate = rentedBook.ReturnDate;
            Returned = rentedBook.Returned;
        }
    }
}
