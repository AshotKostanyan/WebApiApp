using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using WebApiApp.Models;

namespace WebApiApp.Controllers
{
    public class GetEmployeesController : Controller
    {
        public IActionResult GetEmployees()
        {
            ConnectionClass dataBase = new ConnectionClass();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string queryString1 = $"select * from Employee";
            SqlCommand command1 = new SqlCommand(queryString1, dataBase.getConnection());
            adapter.SelectCommand = command1;
            
            adapter.Fill(dt);
            List<EmployeeViewModel> employees =  ConverterClass.ConvertDataTableToList(dt);
            if (employees != null)
            {
                Console.WriteLine(1);
            }
            return Ok(employees);
        }
    }
}
