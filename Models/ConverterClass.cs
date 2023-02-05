using System.Data;
using System.Linq;
using System.Net;

namespace WebApiApp.Models
{
    public static class ConverterClass
    {
        public static List<EmployeeViewModel> ConvertDataTableToList(DataTable dt)
        {
                List<EmployeeViewModel> employeeList = new List<EmployeeViewModel>();
            return employeeList = (from DataRow dr in dt.Rows
                    select new EmployeeViewModel()
            {
                    Id = Convert.ToInt32(dr["id"]),  
                    Name = dr["EmplyeeName"].ToString(),  
                    Age = Convert.ToInt32(dr["Age"]),  
                    Department = dr["Department"].ToString()
                    }).ToList();
        }
    }
}
