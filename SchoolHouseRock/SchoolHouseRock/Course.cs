using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolHouseRock
{
    class Course
    {
        public Course(SqlDataReader reader)
        {
            this.Id = (int)reader["Id"];
            this.Title = reader["Title"].ToString();
            this.InstructorId = (int)reader["InstructorId"];
            this.CourseNumber = (int)reader["CourseNumber"];
            this.DepartmentId = (int)reader["DepartmentId"];
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public int InstructorId { get; private set; }
        public int CourseNumber { get; private set; }
        public int DepartmentId { get; private set; }
    }
}
