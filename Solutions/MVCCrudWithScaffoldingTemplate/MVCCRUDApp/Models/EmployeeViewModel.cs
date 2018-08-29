using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MVCCRUDApp.Models
{
    public class EmployeeViewModel
    {
        [Required]
        [MinLength(7)]
        [StringLength(7)]
        [Remote("IsEmpNIPExist", "Employees", ErrorMessage = "Employee NIP already exist")]
        public string NIP { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime Birthday { get; set; }
    }
}