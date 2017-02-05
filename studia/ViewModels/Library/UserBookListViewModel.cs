using Data.Queries.Library.QueryResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.ViewModels.Book
{
    public class UserBookListViewModel
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string PublishingHouse { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool Returned { get; set; }

        public UserBookListViewModel(UserBookListDto dto)
        {
            BookId = dto.BookId;
            BookName = dto.BookName;
            BookAuthor = dto.BookAuthor;
            PublishingHouse = dto.PublishingHouse;
            RentDate = dto.RentDate;
            ReturnDate = ReturnDate;
            Returned = dto.Returned;
        }
    }
}