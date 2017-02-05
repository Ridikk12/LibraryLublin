using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Services;
using System.Web.Mvc;
using Library.ViewModels.Book;
using Library.ModelHelpers;
using Data.Commands.Books;
using Data.Queries.Books.Queries;
using Data.Queries.Books.QueryResults;
using Microsoft.AspNet.Identity;

namespace Library.Controllers
{
    [Authorize]
    public class BookController : BaseController
    {
        private readonly BookModelHelper _bookModelHelper;

        public BookController(BookModelHelper bookModelHelper, IBaseServiceAggregate servicesAggregate) : base(servicesAggregate)
        {
            _bookModelHelper = bookModelHelper;
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new BookCreateViewModel());
        }

        [HttpPost]
        public ActionResult Create(BookCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                BookCreateCommand command = _bookModelHelper.ToCreateCommand(model);
                var result = CommandProcessor.Run(command);
                SetModalConfirmMessage(result.OutcomeMessage);
                ModelState.Clear();
                return View(new BookCreateViewModel());
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult List()
        {
            BookListQuery query = new BookListQuery();
            var result = QueryProcessor.Run<BookListQuery, List<BookListDto>>(query);
            var vm = _bookModelHelper.ToViewModel(result);
            return View(vm);
        }

        [HttpGet]
        public JsonResult GetBooks()
        {
            BookListQuery query = new BookListQuery();
            var result = QueryProcessor.Run<BookListQuery,List<BookListDto>>(query);
            var vm = _bookModelHelper.ToViewModel(result);
            return Json(vm, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Search(string serachString)
        {
            BookListQuery query = new BookListQuery();
            var result = QueryProcessor.Run<BookListQuery, List<BookListDto>>(query);
            var vm = _bookModelHelper.ToViewModel(result,serachString);
            return View("List",vm);
        }

        [HttpGet]
        public ActionResult Details(int bookId)
        {
            BookDetailsQuery query = new BookDetailsQuery(bookId);
            var result = QueryProcessor.Run<BookDetailsQuery, BookDetailsDto>(query);
            var vm = _bookModelHelper.ToDetailsViewModel(result);
            return View(vm);
        }

        [HttpGet]
        public ActionResult MyBooks()
        {
            MyBookQuery query = new MyBookQuery(User.Identity.GetUserId());
            var result = QueryProcessor.Run<MyBookQuery, List<BookListDto>>(query);
            var vm = _bookModelHelper.ToViewModel(result,false);
            return View("MyBooks", vm);



        }


    }
}