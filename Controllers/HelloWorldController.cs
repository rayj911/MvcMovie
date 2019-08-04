using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET: /HelloWorld/
        public IActionResult Index()
        {
            // return "This is my default acti8on....";
           return View();
        }

        //GET: /HelloWorld/Welcome/

        // public string Welcome(string name, int ID =1)
        // {
        //     // return "This is the Welcome action method";
        //     // return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //     return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        // }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"]="Hello " + name;
            ViewData["NumTimes"] = numTimes * 3;
            return View();
        }
    }
}