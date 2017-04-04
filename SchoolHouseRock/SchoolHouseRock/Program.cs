using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolHouseRock
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString =
                @"Server=localhost\SQLEXPRESS;Database=DotNetUniversity;Trusted_Connection=True;";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Connected");
                connection.Close();
            }
        }
    }
}
