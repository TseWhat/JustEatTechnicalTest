using JustEatTechnicalTest.APIAccess.Interfaces;
using System.Web.Mvc;

namespace JustEatTechnicalTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAPIRepository _apiRepository;

        public HomeController(IAPIRepository apiRepository)
        {
            _apiRepository = apiRepository;
        }

        public ActionResult Index()
        {          
            return View();
        }

        public JsonResult GetRestaurants(string outcode)
        {
            var restaurants = _apiRepository.GetRestaurants(outcode);

            return Json(restaurants, JsonRequestBehavior.AllowGet);
        }
    }
}