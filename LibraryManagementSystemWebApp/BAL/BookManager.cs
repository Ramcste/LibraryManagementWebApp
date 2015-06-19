using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryManagementSystemWebApp.DAL;
using LibraryManagementSystemWebApp.Model;

namespace LibraryManagementSystemWebApp.BAL
{
    public class BookManager
    {
        BookGateway bookGateway=new BookGateway();
        public string Save(Book book)
        {
            if (book.Title == string.Empty)
            {
                return "Book Title is missing";
            }

            else if (book.AuthorName== string.Empty)
            {
                return "Author Name is missing";
            }
            else if (book.Publisher == string.Empty)
            {
                return "Book Publication is missing";
            }

            else if (bookGateway.HasThisTitleExists(book.Title))
            {
                return "Sorry,Book Already Exists";
            }

            else
            {
                int value = bookGateway.Save(book);

                if (value > 0)
                {
                    return "Book Saved Successfully";
                }

                else
                {
                    return "Operation Failed";
                }
            }
        }

        public List<Book> GetAllBooks()
        {
            return bookGateway.GetBookName();
        }


        public int GetBookInfo(string name)
        {
            return bookGateway.GetBookId(name);
        }

        public Book GetBookDetails(int id)
        {
            return bookGateway.GetBookInfo(id);
        }
    }
}