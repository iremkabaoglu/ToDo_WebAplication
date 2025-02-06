using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToDo_WebAplication.Models;

namespace ToDo_WebAplication.Controllers
{
    public class HomeController : Controller
    {
        private ToDoContext context;
        public HomeController(ToDoContext ctx) => context = ctx;

        public IActionResult Index(string id)
        {
            var filters = new Filters(id);
            ViewBag.Filter = filters;


            return View();
        }

       
    }
}
