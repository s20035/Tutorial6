using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APBDTUT3.Models.Enrollment;
using System.Data.SqlClient;
using APBDTUT3.Controllers;
using APBDTUT3.Services;

namespace APBDTUT3.Controllers
{
    [Route("api/enrollments")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        /*
        public EnrollmentController() {
            StudentDbservicescs hella = new StudentDbservicescs();
        }

       
        [HttpPost("{enroll}")]
        public IActionResult enroll([FromBody] Student student) {
            Student st;
            using (var sqlConnection = new SqlConnection(@"Data Source=db-mssql.pjwstk.edu.pl;Initial Catalog=s20035;Integrated Security=True")) {

                sqlConnection.Open();
                var transaction = sqlConnection.BeginTransaction();

                string fname = "Jogn";
                string lname = "Doe";
                string index = "s12345";
                string studies = "IT";
                DateTime bdate = DateTime.Parse("30.03.1993");
                

                try
                {
                    using (var command = new SqlCommand()) {
                        command.Connection = sqlConnection;
                        command.CommandText = "select IndexNumber from student where IndexNumber = " + index;

                        var response = command.ExecuteReader();

                       string answer = response.Read().ToString();
                        if (answer == null) {
                            return NotFound("This student number has already been assigned");
                        }

                        command.CommandText = "select IndexNumber from student where IndexNumber = " + studies+";";

                         response = command.ExecuteReader();

                         answer = response.Read().ToString();
                        if (answer == null)
                        {
                            return NotFound("This subject does exist in our offered subjects");
                        }

                        command.CommandText = "select Max(IdEnrollment) from Enrollment ;";

                        response = command.ExecuteReader();

                        answer = response.Read().ToString();
                        if (answer ==null) {
                            return NotFound("There has been an error with assging enrollment numbers");
                        }

                        int enrollnum = Int32.Parse(answer)+1;
                        int defaultsem = 1;
                        DateTime enrollday = DateTime.Today;

                        command.CommandText = " Insert into Enrollment(IdEnrollment,Semester,StartDate) values " +
                            " (" + enrollnum + "," + defaultsem + "," + enrollday + ") ;" +
                            " Insert into Student(IndexNumber,FirstName,LastName,Birthdate,IdEnrollment) values " +
                            " (" + index + "," + fname + "," + lname + "," + bdate + "," + enrollnum + ") ;";

                         st = new Student { IndexNumber = index, FirstName = fname, LastName = lname, BirthDate = bdate, Studies = studies };
                    }
                    



                }catch (Exception s) {
                    transaction.Rollback();
                    return NotFound();
                }
                transaction.Commit();
                sqlConnection.Close();
            
            }
            return CreatedAtAction(nameof(enroll), st);

        }

        [HttpPost("{promotions}")]
        public IActionResult promote([FromQuery]string studies,[FromQuery]int semester) {

            using (var sqlConnection = new SqlConnection(@"Data Source=db-mssql.pjwstk.edu.pl;Initial Catalog=s20035;Integrated Security=True"))
            {

                sqlConnection.Open();
                var transaction = sqlConnection.BeginTransaction();

                try
                {
                    using (var command = new SqlCommand("Promotion", sqlConnection) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        command.Parameters.Add(new SqlParameter("@Studies", studies));
                        command.Parameters.Add(new SqlParameter("@Semster", semester));
                    }
                }
                catch (Exception t)
                {
                    transaction.Rollback();
                    return NotFound();
                }
                transaction.Commit();
                sqlConnection.Close();

            }
            return CreatedAtAction(nameof(promote), "Action Completed");
        }
        */

    }
}