using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryManagementSystemWebApp.DAL;
using LibraryManagementSystemWebApp.Model;

namespace LibraryManagementSystemWebApp.BAL
{
    public class BorrowManager
    {
        BorrowGateway borrowGateway=new BorrowGateway();
        Borrow borrow=new Borrow();
        public string Save(Borrow borrow)
        {
            if (borrow.MemberId.ToString()== string.Empty)
            {
                return "Memeber Id is missing";
            }

            else if (borrowGateway.HasThisMemberTakenBook(borrow.MemberId,borrow.BookId))
            {
                return "This Memeber has already taken book.";
            }
           
            else
            {
                int value = borrowGateway.Save(borrow);

                if (value > 0)
                {
                    return "Borrow Information Saved Successfully";
                }

                else
                {
                    return "Operation Failed";
                }
            }
        }


        public List<Book> GetBooksName(int id)
        {
           return borrowGateway.GetLoadBorrowedBooks(id);
        }

        public int ReturnOperation(int id,string name)
        {

            return borrowGateway.RemoveFromBorrowList(id,name);
        }

       
    }
}