using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Commands.Books
{
   public class BookCreateCommand : ICommand
    {
        public string BookName { get; set; }
        public int BookSize { get; set; }
        public string BookAuthor { get; set; }
        public string PublishingHouse { get; set; }
        public byte[] Image { get; set; }
        public int Quantity { get; set; }

        public BookCreateCommand(string name, int size, string author, string publishingHouse, int quantity)
        {
            BookName = name;
            BookAuthor = author;
            BookSize = size;
            PublishingHouse = publishingHouse;
            Quantity = quantity;
           
        }
    }
}
