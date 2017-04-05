using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolHouseRock
{
    class Department
    {
        public Department(SqlDataReader reader)
        {
            this.Id = (int)reader["Id"];
            this.Name = reader["Name"].ToString();
            this.HeadInstructorId = (int)reader["HeadInstructorId"];
            this.DeptCode = (int)reader["DeptCode"];
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int HeadInstructorId { get; set; }
        public int DeptCode { get; set; }
    }
}
