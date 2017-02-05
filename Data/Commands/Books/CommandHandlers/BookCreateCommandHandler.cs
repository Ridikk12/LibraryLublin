using Data.Commands;
using Data.Entities;
using Data.Repositories.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Commands.Books.CommandHandlers
{
    class BookCreateCommandHandler : ICommandHandler<BookCreateCommand>
    {
        private readonly IBookReposiotry _bookRepository;
        public BookCreateCommandHandler(IBookReposiotry bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public CommandResult Handle(BookCreateCommand command)
        {
            try
            {
                Book newBook = new Book();
                newBook.Edit(command);
                _bookRepository.Add(newBook);
                _bookRepository.CommitChanges();
                return new CommandResult("Book has been added", CommandResultEnum.Succes);
            }
            catch(Exception Ex)
            {
                return new CommandResult("Problem when tried to add book", CommandResultEnum.Error);
                throw Ex;
            }
        }
    }
}
