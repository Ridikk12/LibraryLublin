using Library.Core;
using Library.Services;
using System.Web.Mvc;

namespace Library.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly ICommandProcessor CommandProcessor;
        protected readonly IQueryProcessor QueryProcessor;

        public BaseController(IBaseServiceAggregate servicesAggregate)
        {
            CommandProcessor = servicesAggregate.CommandProcessor();
            QueryProcessor = servicesAggregate.QueryProcessor();
        }

     
        public virtual ActionResult Index()
        {
            PrepareModalForShowIfMessageExist();
            return View();
        }

        protected void SetModalConfirmMessage(string message)
        {
            TempData["ModalData"] = message;
            PrepareModalForShowIfMessageExist();

        }

        [HttpGet]
        public void PrepareModalForShowIfMessageExist()
        {
            if (TempData["ModalData"]!= null && !string.IsNullOrEmpty(TempData["ModalData"].ToString()))
            {
                ViewData["ModalMessage"] = TempData["ModalData"].ToString();
            }
        }
    }
}