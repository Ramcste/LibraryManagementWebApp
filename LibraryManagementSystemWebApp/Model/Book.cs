using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystemWebApp.Model
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string AuthorName { get; set; }
        public string  Publisher { get; set; }
    }
}