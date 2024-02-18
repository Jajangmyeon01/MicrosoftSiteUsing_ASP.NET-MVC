using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMicrosoftSite.Models
{
    public class DeveloperToolsModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        
        // The Dates of Released //
        public string ReleasedDates{ get; set; }

        // Images for Developer Tools //
        public string DeveloperToolsImage { get; set; }

        // For List of Description on Developer Tools Controller //
        public string listOfDescription { get; set; }
        public string listOfDescription2 { get; set; }
        public string listOfDescription3 { get; set; }
        public string listOfDescription4 { get; set;}

    }
}