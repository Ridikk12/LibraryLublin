using Data.Commands.Books;
using Data.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
   public class Book : Entity
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int BookSize { get; set; }
        public string BookAuthor { get; set; }
        public string PublishingHouse { get; set; }
        public byte[] Image { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }

        public void Edit(BookCreateCommand command)
        {
            BookAuthor = command.BookAuthor;
            BookName = command.BookName;
            BookSize = command.BookSize;
            PublishingHouse = command.PublishingHouse;
            Image = command.Image;
            Quantity = command.Quantity;
            CreatedDate = DateTime.Now;
        }
    }
}
