using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryManagementSystemWebApp.BAL;
using LibraryManagementSystemWebApp.Model;

namespace LibraryManagementSystemWebApp
{
    public partial class BorrowBook : System.Web.UI.Page
    {
        BookManager bookManager =new BookManager();

        Book book=new Book();

        Borrow borrow=new Borrow();

        BorrowManager borrowManager =new BorrowManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDataInDropDownList();

                book = bookManager.GetBookDetails(int.Parse(bookTitleDropDownList.SelectedValue.ToString()));

                authorNameTextBox.Text = book.AuthorName;

                borrowPublisherNameTextBox.Text = book.Publisher;
            }


        }

        protected void borrowBookButton_OnClick(object sender, EventArgs e)
        {
            borrow.MemberId= int.Parse(memberNoTextBox.Text);

            book.Title = bookTitleDropDownList.SelectedItem.Text;

            book.Publisher = borrowPublisherNameTextBox.Text;

            borrow.BookId = bookManager.GetBookInfo(book.Title);

            string message = borrowManager.Save(borrow);

            label4.Text = message;

        }

        protected void bookTitleDropDownList_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            book = bookManager.GetBookDetails(int.Parse(bookTitleDropDownList.SelectedValue.ToString()));

            authorNameTextBox.Text = book.AuthorName;

            borrowPublisherNameTextBox.Text = book.Publisher;
            borrowPublisherNameTextBox.Text = book.Publisher;

            
        }


        public void LoadDataInDropDownList()
        {
            bookTitleDropDownList.DataSource = bookManager.GetAllBooks();
            bookTitleDropDownList.DataTextField = "Title";
            bookTitleDropDownList.DataValueField = "Id";
            bookTitleDropDownList.DataBind();
        }

        
    }
}