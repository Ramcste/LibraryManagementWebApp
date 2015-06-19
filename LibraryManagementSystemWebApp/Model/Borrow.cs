using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystemWebApp.Model
{
    public class Borrow
    {
        public int Id { get; set; }

        public int MemberId { get; set; }


        public int BookId { get; set; }
    }
}