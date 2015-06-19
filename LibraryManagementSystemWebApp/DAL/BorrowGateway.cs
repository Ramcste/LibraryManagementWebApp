using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using LibraryManagementSystemWebApp.Model;

namespace LibraryManagementSystemWebApp.DAL
{
    public class BorrowGateway
    {

        BookGateway bookGateway=new BookGateway();

        private string connectionstring =
            WebConfigurationManager.ConnectionStrings["LibraryWebConString"].ConnectionString;

        public int Save(Borrow borrow)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "INSERT INTO Borrow_Return VALUES('"+borrow.MemberId+"','"+borrow.BookId+"')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowsAffected = command.ExecuteNonQuery();

            connection.Close();
            return rowsAffected;
        }


        public List<Book> GetrInfo(int id)
        {
            List<Book>books=new List<Book>();

            SqlConnection connection = new SqlConnection(connectionstring);

            string query = "SELECT Author,Publisher FROM BOOK WHERE Id='"+id+"'";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Book book = new Book();
                book.AuthorName = reader["Author"].ToString();
                book.Publisher = reader["Publisher"].ToString();
                books.Add(book);
            }

            reader.Close();
            connection.Close();

            return books;
        }



        public bool HasThisMemberTakenBook(int memberid ,int bookid)
        {

            bool memberbook = false;

            SqlConnection connection = new SqlConnection(connectionstring);

            string query = "SELECT Member_Id,Book_Id FROM Borrow_Return WHERE Member_Id='" +memberid + "' AND Book_Id='"+bookid+"'";

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                memberbook = true;
                break;
            }

            return memberbook;

        }



        public List<Book> GetLoadBorrowedBooks(int num)
        {
            List<Book> books=new List<Book>();
                

            SqlConnection connection = new SqlConnection(connectionstring);

            string query = "SELECT b.Title FROM Book as b JOIN Borrow_Return as br on b.Id=br.Book_Id join Member as m on m.Number=br.Member_Id WHERE m.Number='" + num + "' ";

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
               Book book=new Book();

                book.Title = reader["Title"].ToString();
                books.Add(book);
            }

            return books;
        }


        public int RemoveFromBorrowList(int mid,string bookname)
        {
            int bookid = bookGateway.GetBookId(bookname);

            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "DELETE FROM Borrow_Return WHERE Book_Id='"+bookid+"' AND Member_Id='"+mid+"'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowsAffected = command.ExecuteNonQuery();

            connection.Close();
            return rowsAffected;

        }
    }
}