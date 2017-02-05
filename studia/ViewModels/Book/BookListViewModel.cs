using Data.Queries.Books.QueryResults;
using System;

namespace Library.ViewModels.Book
{
    public class BookListViewModel
    {
        public string BookName { get; set; }
        public int BookSize { get; set; }
        public string BookAuthor { get; set; }
        public string PublishingHouse { get; set; }
        public string BookImageUrl;
        public int BookId { get; set; }
        public bool RentAvaible { get; set; } = true;

        public BookListViewModel(BookListDto dto)
        {
            BookName = dto.BookName;
            BookAuthor = dto.BookAuthor;
            PublishingHouse = dto.PublishingHouse;
            BookImageUrl = System.Convert.ToBase64String(dto.Image);
            BookId = dto.BookId;
        }

         public BookListViewModel(RecentlyAddedBookDto dto)
        {
            BookName = dto.BookName;
            BookAuthor = dto.BookAuthor;
            PublishingHouse = dto.PublishingHouse;
            BookImageUrl = Convert.ToBase64String(dto.Image);
            BookId = dto.BookId;
        }
    }
}