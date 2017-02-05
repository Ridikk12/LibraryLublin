using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Commands.Library.Commands
{
   public class RentBookCommand : ICommand
    {
        public int BookId { get; set; }
        public string UserId { get; set; }

        public RentBookCommand(int bookId, string userId)
        {
            BookId = bookId;
            UserId = userId;
        }

    }
}
