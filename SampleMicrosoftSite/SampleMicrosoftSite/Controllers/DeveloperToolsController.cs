using SampleMicrosoftSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMicrosoftSite.Controllers
{
    public class DeveloperToolsController : Controller
    {
        // GET: DeveloperTools
        public ActionResult Index()
        {
            var developertoolscontroller = new List<DeveloperToolsModel>
            {
                new DeveloperToolsModel()
                {
                    Id = "visualstudio2022",
                    Name = "VIsual Studio 2022",
                    ReleasedDates = @"Released Date: ""November 8, 2021""",
                    Description = @"The most comprehensive IDE for .NET and C++ developers on Windows. Fully packed with a sweet array of tools and features to elevate and enhance every stage of software development.",
                    ImageUrl = "VS2022.png",
                    listOfDescription = "Visual Studio Community 2022",
                    listOfDescription2 = "Visual Studio Professional 2022",
                    listOfDescription3 = "Visual Studio Enterprise 2022",
                    DeveloperToolsImage = "VSInterface.jpg"
                    
                },
                new DeveloperToolsModel()
                {
                    Id = "visualstudio code",
                    Name = "Visual Studio Code",
                    ReleasedDates = @"Released Date: ""November 18, 2015""",
                    Description = @"A standalone source code editor that runs on Windows, macOS, and Linux. The top pick for JavaScript and web developers, with extensions to support just about any programming language.",
                    ImageUrl = "VScode.jpg",
                    listOfDescription = "Available on Windows",
                    listOfDescription2 = "Available on Mac",
                    listOfDescription3 = "Available on Linux",
                    DeveloperToolsImage = "VScodeInterface.jpg"
                },
                new DeveloperToolsModel()
                {
                    Id = "microsoft 365",
                    Name = "Microsoft 365",
                     ReleasedDates = @"Released Date: ""April 21, 2021""",
                    Description = @"Office 365 is now ""Microsoft 365"". Microsoft 365 is designed to help you achieve more with innovative apps, intelligent cloud services, and world-class security.",
                    ImageUrl = "Microsoft365logo.png",
                    listOfDescription = "For Home",
                    listOfDescription2 = "For Business",
                    listOfDescription3 = "For Enterprise",
                    listOfDescription4 = "For Education",
                    DeveloperToolsImage = "365Interface.jpg"
                }
            };
            return View(developertoolscontroller);
        }
    }
}