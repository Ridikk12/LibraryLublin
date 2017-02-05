using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Context;
using Data.Entities;
using Data.Repositories.Abstract;

namespace Data.Repositories.Books
{
    class BookRepository : RepositoryBase,IBookReposiotry
    {
        public BookRepository(AppContextEF dbContext) : base(dbContext)
        {
        }

        public void Add(Book entity)
        {
            _context.Books.Add(entity);
        }

        public void CommitChanges()
        {
            _context.SaveChanges();
        }

        public void Delte(Book entity)
        {
            _context.Books.Remove(entity);
        }

        public Book Find(int bookId)
        {
           return _context.Books.Where(x => x.BookId == bookId).First();
        }

        public List<Book> FindAll()
        {
            return _context.Books.ToList();
        }

        public List<Book> RecentlyAdded()
        {
            DateTime dateFrom = DateTime.Now.AddDays(-7);
            return _context.Books.Where(X => X.CreatedDate >= dateFrom).ToList();
        }
    }
}
