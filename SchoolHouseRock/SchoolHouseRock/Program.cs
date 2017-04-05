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
                Console.WriteLine("Connected");
                SeeAllCourses(connection);
               
            }
        }  

        public static void SeeAllCourses(SqlConnection connection)
        {
            var allcourses = new List<Course>();
            var MyCommand = new SqlCommand(@"SELECT * FROM Course JOIN Instructors ON Course.InstructorId = Instructors.Id", connection);
            connection.Open();

            var reader = MyCommand.ExecuteReader();

            while (reader.Read())
            {
                var coursecontainer = new Course(reader);
                allcourses.Add(coursecontainer);
            }
            foreach(var eachclass in allcourses)
            {
                Console.WriteLine(eachclass.Title);
            }
           
            connection.Close();
        }

    }
}
