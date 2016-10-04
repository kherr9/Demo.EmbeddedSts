using System;
using System.IdentityModel.Services;
using System.Web.Mvc;

namespace Demo.EmbeddedSts.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Login()
        {
            return RedirectToAction("Index");
        }

        public ActionResult Logout()
        {
            FederatedAuthentication.WSFederationAuthenticationModule.SignOut();
            return RedirectToAction("Index");

            //SignOutRequestMessage so = new SignOutRequestMessage(new Uri(FederatedAuthentication.WSFederationAuthenticationModule.Issuer));
            //return Redirect(so.WriteQueryString());
        }
    }
}