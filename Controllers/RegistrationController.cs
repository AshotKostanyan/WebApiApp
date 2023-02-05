using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using WebApiApp.Models;

namespace WebApiApp.Controllers
{
    public class RegistrationController : Controller
    {
        ConnectionClass dataBase = new ConnectionClass(); 
        public IActionResult Registration([FromBody] EmployeeViewModel employee)
        {
            string queryString = $"insert into Employee (EmplyeeName,Age,Department) values ('{employee.Name}',{employee.Age},'{employee.Department}')";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.OpenConnection();
            command.ExecuteNonQuery();
            dataBase.CloseConnection();

            return Ok();
        }
    }
}
