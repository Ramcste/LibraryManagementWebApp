using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using LibraryManagementSystemWebApp.Model;

namespace LibraryManagementSystemWebApp.DAL
{
    public class BookGateway
    {
        private string connectionstring =
            WebConfigurationManager.ConnectionStrings["LibraryWebConString"].ConnectionString;

        public int Save(Book book)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "INSERT INTO Book VALUES('" + book.Title + "','" + book.AuthorName + "','"+book.Publisher+"')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowsAffected = command.ExecuteNonQuery();

            connection.Close();
            return rowsAffected;
        }

        public bool HasThisTitleExists(string title)
        {
            bool titleexists = false;

            SqlConnection connection = new SqlConnection(connectionstring);

            string query = "SELECT Title FROM Book WHERE Title='" + title + "'";

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                titleexists = true;
                break;
            }

            return titleexists;
        }


        public List<Book> GetBookName()
        {
            List<Book> books=new List<Book>();

            SqlConnection connection = new SqlConnection(connectionstring);

            string query = "SELECT * FROM Book";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Book book =new Book();

                book.Id = int.Parse(reader["Id"].ToString());
                book.Title = reader["Title"].ToString();
                book.AuthorName = reader["Author"].ToString();
                book.Publisher = reader["Publisher"].ToString();
                books.Add(book);
            }

            reader.Close();
            connection.Close();

            return books;
        }

        public int GetBookId(string title)
        {
            int id=0 ;
            SqlConnection connection = new SqlConnection(connectionstring);

            string query = "SELECT Id FROM Book WHERE Title='"+title+"'";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
              

                id = int.Parse(reader["Id"].ToString());
               
            }

            reader.Close();
            connection.Close();
            return id;
        }


        public Book GetBookInfo(int id)
        {
           

            SqlConnection connection = new SqlConnection(connectionstring);

            string query = "SELECT * FROM Book WHERE Id='"+id+"'";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            
            Book book = new Book();

            while (reader.Read())
            {

                book.Id = int.Parse(reader["Id"].ToString());
                book.Title = reader["Title"].ToString();
                book.AuthorName = reader["Author"].ToString();
                book.Publisher = reader["Publisher"].ToString();
                
            }

            reader.Close();
            connection.Close();

            return book;
        }

      
    }
}