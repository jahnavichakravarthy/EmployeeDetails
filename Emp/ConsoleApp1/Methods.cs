using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;


namespace ConsoleApp1
{
    public class Methods
    {
        public Employee FindById(string id)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeDetailsDB"].ConnectionString))
                {
                    return db.Query<Employee>("Select * From EMPLOYEES" +
                    "WHERE Id = @Id", new { id }).SingleOrDefault();//return only elemnnt or defualt value if null
                                                                    //  SELECT* FROM Customers
                                                                    //    WHERE Country = 'Mexico';
                }
            }
        
            catch (System.Exception e)
            {

                throw;
            }


        }
    }
}
