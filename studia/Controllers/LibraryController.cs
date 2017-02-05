using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Services;
using Library.ViewModels.Book;
using Data.Queries.Library.Queries;
using Microsoft.AspNet.Identity;
using Data.Queries.Library.QueryResult;
using Library.ModelHelpers;
using System.Web.Mvc;
using Data.Commands.Library.Commands;

namespace Library.Controllers
{
    public class LibraryController : BaseController
    {
        private LibraryModelHelper _libraryModelHelper;

        public LibraryController(LibraryModelHelper modelHelper,IBaseServiceAggregate servicesAggregate) : base(servicesAggregate)
        {
            _libraryModelHelper = modelHelper;
        }

        [HttpGet]
        public JsonResult UserBooks()
        {
            UserBookListQuery query = new UserBookListQuery(User.Identity.GetUserId());
            var result = QueryProcessor.Run<UserBookListQuery, List<UserBookListDto>>(query);
            var vm = _libraryModelHelper.ToViewModel(result);
            return Json(vm, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Rent(BookDetailsViewModel model)
        {
            RentBookCommand command = new RentBookCommand(model.BookId, User.Identity.GetUserId());
            var result = CommandProcessor.Run(command);
            SetModalConfirmMessage(result.OutcomeMessage);
            return RedirectToAction("MyBooks","Book");
        }

    }
}