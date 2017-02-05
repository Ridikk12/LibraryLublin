using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Books
{
    public interface IBookReposiotry : IRepository<Book>
    {
        List<Book> FindAll();
        List<Book> RecentlyAdded();
        Book Find(int bookId);
        

    }
}
