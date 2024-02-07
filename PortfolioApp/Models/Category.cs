using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortfolioApp.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Project> Projects { get; set; }


    }
}