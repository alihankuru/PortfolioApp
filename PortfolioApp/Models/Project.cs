using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortfolioApp.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string ProjectUrl { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}