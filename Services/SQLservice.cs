using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace APBDTUT3.Services
{
    public class SQLservice : IDBservice
    {
        public bool existIndexNumber(string index)
        {
            using (var sqlConnection = new SqlConnection(@"Data Source=db-mssql.pjwstk.edu.pl;Initial Catalog=s20035;Integrated Security=True"))
            {
                sqlConnection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = sqlConnection;
                    command.CommandText = "Select count(1) from Student where IndexNumber = " + index + " ;";


                    var response = command.ExecuteReader();
                    var comp = int.Parse(response.Read().ToString());
                    if (comp>0) {
                        return true;
                    }

                }
            }
            return false;
        }
       
    }
}
