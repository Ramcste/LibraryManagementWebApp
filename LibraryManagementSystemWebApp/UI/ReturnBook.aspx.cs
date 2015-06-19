using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryManagementSystemWebApp.BAL;

namespace LibraryManagementSystemWebApp
{
    public partial class ReturnBook : System.Web.UI.Page
    {
        BookManager book=new BookManager();
        BorrowManager borrowManager=new BorrowManager();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void returnBookButton_OnClick(object sender, EventArgs e)
        {
            string bookname = borrowedbooklist.SelectedItem.Text;

            int memberid = int.Parse(memberNoTextBox.Text);

            int value = borrowManager.ReturnOperation(memberid,bookname);

          

            if (value > 0)
            {
                label4.Text = "Sucessfully returned";
            }
            else
            {
                 label4.Text = "Operation Failed";
            }
        }

        protected void showBorrowedBooksList_OnClick(object sender, EventArgs e)
        {
            int id =int.Parse(memberNoTextBox.Text);

            borrowedbooklist.DataSource = borrowManager.GetBooksName(id);
            borrowedbooklist.DataTextField = "Title";
            borrowedbooklist.DataValueField = "Id";
            borrowedbooklist.DataBind();
        }


        
        }
    }
