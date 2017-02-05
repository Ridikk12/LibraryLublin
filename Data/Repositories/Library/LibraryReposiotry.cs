using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Context;
using Data.Entities;
using Data.Repositories.Abstract;

namespace Data.Repositories.Library
{
    class LibraryRepository : RepositoryBase, ILibraryRepository
    {
        public LibraryRepository(AppContextEF dbContext) : base(dbContext)
        {
        }

        public void Add(BookRental entity)
        {
            _context.Library.Add(entity);
        }

        public void CommitChanges()
        {
            _context.SaveChanges();
        }

        public void Delte(BookRental entity)
        {
            _context.Library.Remove(entity);
        }

        public List<BookRental> FindForUser(string userId)
        {
            return _context.Library.Where(x => x.User.Id == userId).ToList();
        }

        public DateTime? GetPredictedReturnDate(int bookId)
        {
           var bookRental =  _context.Library.Where(x => x.PredictedReturnDate > DateTime.Now && x.RentedBook.BookId==bookId).OrderBy(x => x.PredictedReturnDate).FirstOrDefault();
            if (bookRental != null)
                return bookRental.PredictedReturnDate;
            return null;
        }
    }
}
