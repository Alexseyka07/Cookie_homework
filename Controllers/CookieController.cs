using Microsoft.AspNetCore.Mvc;

namespace progtime_hm.Controllers
{
    public class CookieController : Controller
    {
        public IActionResult Index()
        {
            var cookies = Request.Cookies;
            return View(cookies);
        }


        public IActionResult CreateCookie(string name, string value)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(value))
            {
                Response.Cookies.Append(name, value);
            }
            return RedirectToAction("Index");
        }

        public IActionResult EditCookie(string name, string newValue)
        {
            if (Request.Cookies.ContainsKey(name) && !string.IsNullOrEmpty(newValue))
            {
                Response.Cookies.Delete(name); 
                Response.Cookies.Append(name, newValue); 
            }
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCookie(string name)
        {
            if (Request.Cookies.ContainsKey(name))
            {
                Response.Cookies.Delete(name);
            }
            return RedirectToAction("Index");
        }
    }
}
