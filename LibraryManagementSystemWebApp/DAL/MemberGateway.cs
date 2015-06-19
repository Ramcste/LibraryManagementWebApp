using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using LibraryManagementSystemWebApp.Model;

namespace LibraryManagementSystemWebApp.DAL
{
    public class MemberGateway
    {
        private string connectionstring =
            WebConfigurationManager.ConnectionStrings["LibraryWebConString"].ConnectionString;



        public int Save(Member member)
        {
            SqlConnection connection=new SqlConnection(connectionstring);
            string query = "INSERT INTO Member VALUES('"+member.MemberId+"','"+member.Name+"')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowsAffected = command.ExecuteNonQuery();

            return rowsAffected;
        }


        public bool HasThisNumberExists(int num)
        {
            bool numberexists = false;

            SqlConnection connection=new SqlConnection(connectionstring);

            string query = "SELECT Number FROM Member WHERE Number='"+num+"'";

            connection.Open();

            SqlCommand command=new SqlCommand(query,connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                numberexists = true;
                break;
            }

            return numberexists;
        }
    }
}