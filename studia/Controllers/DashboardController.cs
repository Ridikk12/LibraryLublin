using Library.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Services;
using System.Web.Mvc;
using Data.Queries.Books.Queries;
using Data.Queries.Books.QueryResults;
using Library.ModelHelpers;

namespace Library.Controllers.Abstract
{
    [Authorize]
    public class DashboardController : BaseController
    {

        private readonly BookModelHelper _bookModelHelper;
        public DashboardController(BookModelHelper modelHelper,IBaseServiceAggregate servicesAggregate) : base(servicesAggregate)
        {
            _bookModelHelper = modelHelper;
        }

        public override ActionResult Index()
        {

            RecentlyAddedBookQuery query = new RecentlyAddedBookQuery();
            var result = QueryProcessor.Run<RecentlyAddedBookQuery, List<RecentlyAddedBookDto>>(query);
            var vm = _bookModelHelper.ToViewModel(result);
            PrepareModalForShowIfMessageExist();
            return View(vm);
        }

        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult AddBook()
        {
           return RedirectToAction("Create", "Book");
        }

        public ActionResult BookList()
        {
            return RedirectToAction("List", "Book");
        }

        public ActionResult MyBooks()
        {
            return RedirectToAction("MyBooks", "Book");
        }
    }
}