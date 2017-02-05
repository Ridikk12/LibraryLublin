using Data.Queries.Library.QueryResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Queries.Library.Queries
{
   public class UserBookListQuery : IQuery<List<UserBookListDto>>
    {
        public string UserId { get; set; }

        public UserBookListQuery(string userId)
        {
            UserId = userId;
        }
    }
}
