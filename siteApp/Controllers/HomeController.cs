using Microsoft.AspNetCore.Mvc;

namespace siteApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        #region Costa
        public IActionResult Costa()
        {
            return View();
        }
        public IActionResult TimeLine()
        {
            return LocalRedirect("/home/costa/#timeline");
        }
        public IActionResult Recognition()
        {
            return LocalRedirect("/home/costa/#recognition");
        }
        public IActionResult SocialResponsability()
        {
            return LocalRedirect("/home/costa/#socialresponsability");
        }
        public IActionResult People()
        {
            return LocalRedirect("/home/costa/#people");
        }
        public IActionResult Addresses()
        {
            return LocalRedirect("/home/costa/#addresses");
        }
        #endregion
        #region Advogados
        public IActionResult Lawyers()
        {
            return View();
        }
        #endregion
        #region Atuacao
        public IActionResult Actuation()
        {
            return View();
        }
        #endregion
        #region Acontece
        public IActionResult Covid19()
        {
            return View();
        }
        public IActionResult Publications()
        {
            return View();
        }
        public IActionResult News()
        {
            return View();
        }
        public IActionResult Press()
        {
            return View();
        }
        public IActionResult Events()
        {
            return View();
        }
        public IActionResult Videos()
        {
            return View();
        }
        #endregion
        #region Carreira
        public IActionResult Profession()
        {
            return View();
        }
        #endregion
        #region Contato
        public IActionResult Contact()
        {
            return View();
        }
        #endregion
    }
}
