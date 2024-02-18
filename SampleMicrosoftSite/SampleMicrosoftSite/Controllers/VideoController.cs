using SampleMicrosoftSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace SampleMicrosoftSite.Controllers
{
    public class VideoController : Controller
    {
        // GET: Video
        public ActionResult Index()
        {
            var videos = new List<VideoModel>()
            {
                new VideoModel()
                { 
                   Id = "visualstudio2022",
                   Name = "Visual Studio 2022",
                   ReleasedDates = @"Released Date: ""November 8, 2021""",
                   Description = @"The most comprehensive IDE for .NET and C++ developers on Windows. Fully packed with a sweet array of tools and features to elevate and enhance every stage of software development.",
                   VideoUrl = "https://www.youtube.com/embed/wu3BIeP1WD8",
                   TitleNameVideo = "VS22 - Feature Highlights",
                   VideoUrl2 = "https://www.youtube.com/embed/hZ1DASYd9rk",
                   TitleNameVideo2 = "VS Studio 2022 ASP.NetCore MVC Course"
                },
                new VideoModel()
                {
                    Id = "visualstudio code",
                    Name = "Visual Studio Code",
                    ReleasedDates = @"Released Date: ""November 18, 2015""",
                    Description = @"A standalone source code editor that runs on Windows, macOS, and Linux. The top pick for JavaScript and web developers, with extensions to support just about any programming language.",
                    VideoUrl = "https://www.youtube.com/embed/SYRwSyjD8oI",
                    TitleNameVideo = "VS Code - Setup and Basics",
                    VideoUrl2 = "https://www.youtube.com/embed/UTQp6mvhb0Y",
                    TitleNameVideo2= "Visual Studio Code Full Course"

                },
                new VideoModel()
                {
                    Id = "microsoft 365",
                    Name = "Microsoft 365",
                    ReleasedDates = @"Released Date: ""April 21, 2021""",
                    Description = @"Office 365 is now ""Microsoft 365"". Microsoft 365 is designed to help you achieve more with innovative apps, intelligent cloud services, and world-class security.",
                    VideoUrl = "https://www.youtube.com/embed/qKG8r1NERl4",
                    TitleNameVideo = "Introducing Windows 365",
                    VideoUrl2 = "https://www.youtube.com/embed/ySKjhmg9RRo",
                    TitleNameVideo2= "Microsoft 365 Basics Full Course"
                }
            };
     
            return View(videos);
        }
    }
}