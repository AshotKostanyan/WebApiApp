using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace WebApiApp.Models
{
    public class EmployeeViewModel
    {  
        public int Id { get; set; }

        [Required(ErrorMessage = "Write name")]
        [MinLength(2, ErrorMessage = "Name min lenght is 2")]
        [MaxLength(50, ErrorMessage = "Name max lenght is 50")]
        public string? Name { get; set; }

        [Range(12,110,ErrorMessage = "Min age is 12")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Write department")]
        [MaxLength(100, ErrorMessage = "Name max lenght is 100")]
        public string? Department { get; set; }
    }
}
