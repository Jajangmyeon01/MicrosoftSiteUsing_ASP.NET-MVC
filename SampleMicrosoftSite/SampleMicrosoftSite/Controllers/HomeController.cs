using SampleMicrosoftSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMicrosoftSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id, string pageType)
        {
            var featuredPosts = new List<FeaturedViewModel>
            {
                new FeaturedViewModel()
                {
                    Id = "visualstudio 2022",
                    Header = "Developer Tools",
                    Title = "Visual Studio 2022",
                    PostedDate = DateTime.Now,
                    Description = @"The ""Visual Studio IDE"" is a creative launching pad that you can use to edit, debug, and build code, and then publish an app. Over and above the standard editor and debugger that most IDEs provide, Visual Studio includes compilers, code completion tools, graphical designers, and many more features to enhance the software development process.",
                    ImageUrl = "VS2022.png"
                },
                new FeaturedViewModel()
                {
                    Id = "visualstudio code",
                    Header = "Developer Tools",
                    Title = "Visual Studio Code",
                    PostedDate = DateTime.Now,
                    Description = @"The ""Visual Studio Code"" is a lightweight but powerful source code editor which runs on your desktop and is available for Windows, macOS and Linux. It comes with built-in support for JavaScript, TypeScript and Node.js and has a rich ecosystem of extensions for other languages and runtimes (such as C++, C#, Java, Python, PHP, Go, .NET).",
                    ImageUrl = "VScode.jpg"
                }
            };
            return View(featuredPosts);
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Privacy()
        {
            return View("Private");
        }
        public class MicrosoftController: Controller
        {
            public ActionResult Microsoft()
            {
                return View();
            }
        }

        
    }
}