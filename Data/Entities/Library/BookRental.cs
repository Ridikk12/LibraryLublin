using Data.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class BookRental : Entity
    {
        [Key]
        public int RentalId { get; set; }
        public virtual Book RentedBook { get; set; }
        public virtual User User { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime PredictedReturnDate { get; set; } 
        public DateTime? ReturnDate { get; set; }
        public bool Returned { get; set; }

        public BookRental()
        {

        }

        public BookRental(Book book, User user, DateTime rentDate, DateTime predictedReturnDate)
        {
            RentedBook = book;
            User = user;
            RentDate = rentDate;
            PredictedReturnDate = predictedReturnDate;
            Returned = false;
        }

    }
}
