using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace Survey.Controllers
{
    public class mycontrollers : Controller
    {
        [Route("")]
        public ViewResult Survey()
        {
            return View();
        }
        [HttpPost]
        [Route("process")]
        public IActionResult Process( string name, string location, string language, string comment)
        {
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comment = comment;
            return View("summary");
        }
    }
}