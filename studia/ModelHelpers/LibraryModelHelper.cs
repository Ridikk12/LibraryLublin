using Data.Queries.Library.QueryResult;
using Library.ViewModels.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.ModelHelpers
{
    public class LibraryModelHelper : IModelHelper
    {

        public List<UserBookListViewModel> ToViewModel(List<UserBookListDto> dto)
        {
            return dto.Select(x => new UserBookListViewModel(x)).ToList();
        }

    }
}