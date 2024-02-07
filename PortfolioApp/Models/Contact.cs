using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortfolioApp.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string NameSurname { get; set; }

        public string Email { get; set; }
        public DateTime Date { get; set; }

    }
}