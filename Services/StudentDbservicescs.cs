using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;

namespace APBDTUT3.Services
{
    public class StudentDbservicescs:IStudentsDbService
    {
        public IActionResult enroll() {
           
            using (var sqlConnection = new SqlConnection(@"Data Source=db-mssql.pjwstk.edu.pl;Initial Catalog=s20035;Integrated Security=True"))
            {

                sqlConnection.Open();
                
                sqlConnection.Close();

            }


            return CreatedAtActionResult();


        }

        private IActionResult CreatedAtActionResult()
        {
            throw new NotImplementedException();
        }

        public IActionResult promote() {


            using (var sqlConnection = new SqlConnection(@"Data Source=db-mssql.pjwstk.edu.pl;Initial Catalog=s20035;Integrated Security=True"))
            {

                sqlConnection.Open();

                sqlConnection.Close();

        }
            return CreatedAtAction(nameof(promote), new Object());
    }

        private IActionResult CreatedAtAction(string v1, object v2)
        {
            throw new NotImplementedException();
        }
    }
}
