using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Employee.Model
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        [Display(Name ="Full Name")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Full Name is Required!")]
        public string FullName { get; set; }

        [Display(Name = "Phone No.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Phone No. Must be Required!")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNo { get; set; }

        [Display(Name = "Country Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Country Name Must be Required!")]
        public string Country { get; set; }

        [Display(Name = "State")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "State Must be Required!")]
        public string State { get; set; }
        public int DepartmentId { get; set; }

        [Display(Name = "Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password Must be Required!")]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage ="Password is not Less Than 6!")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Confirm Password Must be Required!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and Confirm Password Must be Same!")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Date Of Birth")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Date Of Birth Must be Required!")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode =true,DataFormatString ="DD/MM/YYYY")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Department Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Date Of Birth Must be Required!")]
        public string DepartmnetName { get; set; }
        
    }
}
