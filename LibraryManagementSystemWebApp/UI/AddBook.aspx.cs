using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryManagementSystemWebApp.BAL;
using LibraryManagementSystemWebApp.Model;

namespace LibraryManagementSystemWebApp
{
    public partial class AddBook : System.Web.UI.Page
    {
        private Book book = new Book();

        BookManager bookManager=new BookManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveBookButton_OnClick(object sender, EventArgs e)
        {
            book.Title = titleNameTextBox.Text;
            book.AuthorName = authorNameTextBox.Text;
            book.Publisher = publisherNameTextBox.Text;

            string message = bookManager.Save(book);
            label4.Text = message;
               GetBookTextBoxesClear();
        }

        public void GetBookTextBoxesClear()
        {
            titleNameTextBox.Text = "";
            authorNameTextBox.Text = "";
            publisherNameTextBox.Text = "";
        }
    }
}