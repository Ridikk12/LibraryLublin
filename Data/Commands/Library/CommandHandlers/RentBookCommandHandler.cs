using Data.Commands.Library.Commands;
using Data.Entities;
using Data.Repositories.Books;
using Data.Repositories.Library;
using Data.Repositories.UserRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Commands.Library.CommandHandlers
{
    public class RentBookCommandHandler : ICommandHandler<RentBookCommand>
    {
        private readonly IBookReposiotry _bookRepository;
        private readonly ILibraryRepository _libraryRepository;
        private readonly IUserRepository _userRepository;
        public RentBookCommandHandler(IUserRepository userRepository,IBookReposiotry bookRepository, ILibraryRepository libraryRepository)
        {
            _bookRepository = bookRepository;
            _libraryRepository = libraryRepository;
            _userRepository = userRepository;

        }

        public CommandResult Handle(RentBookCommand command)
        {
            var book = _bookRepository.Find(command.BookId);
            book.Quantity--;
            var user = _userRepository.GetUser(command.UserId);
            BookRental toRent = new BookRental(book,user,DateTime.Now, DateTime.Now.AddDays(12));
            _libraryRepository.Add(toRent);
            _libraryRepository.CommitChanges();
            return new CommandResult("Book has been rented. Please return it max after 2 weeks from today.", CommandResultEnum.Succes);
        }
    }
}
