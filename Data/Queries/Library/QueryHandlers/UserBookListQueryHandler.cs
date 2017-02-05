using Data.Queries.Library.Queries;
using Data.Queries.Library.QueryResult;
using Data.Repositories.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Queries.Library.QueryHandlers
{
    public class UserBookListQueryHandler : IQueryHandler<UserBookListQuery, List<UserBookListDto>>
    {
        private readonly ILibraryRepository _libraryRepository;
        public UserBookListQueryHandler(ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }

        public List<UserBookListDto> Execute(UserBookListQuery query)
        {
            var RentedBooks = _libraryRepository.FindForUser(query.UserId);
            return RentedBooks.Select(x => new UserBookListDto(x)).ToList();
        }
    }
}
