using Library.ViewModels;
using System.Web;
using System.Web.Mvc;
using Library.Services;
using Microsoft.AspNet.Identity;
using studia.Services.Identity;
using Microsoft.AspNet.Identity.Owin;
using Data.Entities;

namespace Library.Controllers
{
    public class AccountController : BaseController
    {
        private AppSignInManager _signInManager;
        private AppUserManager _userManager;

        public AccountController(IBaseServiceAggregate servicesAggregate) : base(servicesAggregate)
        {


        }



        public AppSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<AppSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public AppUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<AppUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public override ActionResult Index()
        {

            return RedirectToAction("Login");
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult SignIn(UserLogInViewModel model)
        {
            return Redirect("/");
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            PrepareModalForShowIfMessageExist();
            return View(new UserLogInViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
 
        public ActionResult Login(UserLogInViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            var result =  SignInManager.PasswordSignIn(model.UserName, model.UserPassword,false,false);
            switch (result)
            {
                case SignInStatus.Success:
                    SetModalConfirmMessage("Login succesfull");
                    return RedirectToAction("Index", "Dashboard");
                case SignInStatus.LockedOut:
                    return View("Lockout");
                case SignInStatus.Failure:
                default:
                    ModelState.AddModelError("", "Invalid user name or password.");
                    return View(model);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View(new UserRegistryViewModel());
        }


        [HttpPost]
        [AllowAnonymous]
        public ActionResult Register(UserRegistryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User { UserName = model.UserName, Email = model.UserEmail};
                var result = UserManager.Create(user, model.UserPassword);
                if (result.Succeeded)
                {
                   SignInManager.SignIn(user, isPersistent: false, rememberBrowser: false);
                   SetModalConfirmMessage("You have been registered!");
                   return RedirectToAction("Login", "Account");
                }
            }
            return View(model);
        }

        public ActionResult Logout()
        {
            var authetication = HttpContext.GetOwinContext().Authentication;
            authetication.SignOut();
            return Index();
        }



    }
}