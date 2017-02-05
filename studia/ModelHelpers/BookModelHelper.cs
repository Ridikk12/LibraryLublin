using Data.Commands.Books;
using Data.Queries.Books.QueryResults;
using Library.ViewModels.Book;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Library.ModelHelpers
{
    public class BookModelHelper : IModelHelper
    {

        public BookCreateCommand ToCreateCommand(BookCreateViewModel vm)
        {


            BookCreateCommand command = new BookCreateCommand(vm.BookName, vm.BookSize, vm.BookAuthor, vm.PublishingHouse,vm.Quantity);
            command.Image = PrepareImage(vm.Image);

            return command;
        }

        private byte[]  PrepareImage(HttpPostedFileBase vm)
        {
            byte[] image;
            using (Stream inputStream = vm.InputStream)
            {
                MemoryStream memoryStream = inputStream as MemoryStream;
                if (memoryStream == null)
                {
                    memoryStream = new MemoryStream();
                    inputStream.CopyTo(memoryStream);
                }
                image = memoryStream.ToArray();
            }
            return image;
        }
        public List<BookListViewModel> ToViewModel(List<BookListDto> dto, bool showRentButton=true)
        {
            
            if (!showRentButton)
            {
              var vm = dto.Select(x => new BookListViewModel(x)).ToList();
                vm.ForEach(x =>
                {
                    x.RentAvaible = false;
                });
                return vm;
            }
            return dto.Select(x => new BookListViewModel(x)).ToList();
        }

        public List<BookListViewModel> ToViewModel(List<RecentlyAddedBookDto> dto)
        {
            return dto.Select(x => new BookListViewModel(x)).ToList();
        }

        public List<BookListViewModel> ToViewModel(List<BookListDto> dto,string searchString)
        {
            return dto.Select(x => new BookListViewModel(x))
                .Where(x=> x.BookName.StartsWith(searchString) || x.BookAuthor.StartsWith(searchString) || x.PublishingHouse.StartsWith(searchString)).ToList();
        }

        public BookDetailsViewModel ToDetailsViewModel(BookDetailsDto dto)
        {
            return new BookDetailsViewModel(dto);
        }
    }
}