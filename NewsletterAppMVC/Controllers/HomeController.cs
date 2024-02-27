using NewsletterAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public int FirstName { get; private set; }

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)

        {                   
                   
            
            
            
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress)) 
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
               
                string queryString = @"INSERT INTO dbo.SignUps(FirstName, LastName, EmailAddress) VALUES (@FirstName, @LastName, @EmailAddress)";
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", System.Data.SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", System.Data.SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", System.Data.SqlDbType.VarChar);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;

                    connection.Open();
                    
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return View("Success");
            }
        }
        
        public ActionResult Admin()
        {
            string queryString= @"SELECT Id, FirstName, LastName, EmailAddress from Signups";
            List<NewsletterSignUp> signups = new List<NewsletterSignUp>();

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command= new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var signup = new NewsletterSignUp();
                    signup.Id = Convert.ToInt32(reader["Id"]);
                    signup.FirstName = reader["FirstName"].ToString();
                    signup.LastName = reader["LastName"].ToString();
                    signup.EmailAddress = reader["EmailAddress"].ToString();
                    signups.Add(signup);
                }
            }

            return View(signups);
        }
    }
}