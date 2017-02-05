using Data.Queries.Books.QueryResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.ViewModels.Book
{
    public class BookDetailsViewModel
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int BookSize { get; set; }
        public string BookAuthor { get; set; }
        public string PublishingHouse { get; set; }
        public string Image { get; set; }
        public bool Avalible { get; set; }
        public DateTime? PredictedReturnData { get; set; }

        public BookDetailsViewModel(BookDetailsDto dto)
        {
            BookName = dto.BookName;
            BookSize = dto.BookSize;
            BookAuthor = dto.BookAuthor;
            PublishingHouse = dto.PublishingHouse;
            Image = Convert.ToBase64String(dto.Image);
            Avalible = dto.Avalibe;
            BookId = dto.BookId;
            PredictedReturnData = dto.PredictedBookReturn;
        }
        public BookDetailsViewModel() { }

    }
}