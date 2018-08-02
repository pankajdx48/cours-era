using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class SignUP
    {
        public int RID { get; set; }

        [Required]
        [Display(Name = "Name: ")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Father Name: ")]
        public string FatherName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(150)]
        [Display(Name = "Email : ")]
        public string Email { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Mobile Number : ")]
        public string MobileNumber { get; set; }

        [Required]
        [Display(Name = "Address : ")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "User Name : ")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(150, MinimumLength = 6)]
        [Display(Name = "Password: ")]
        public string Password { get; set; }
        


        //public string UserType { get; set; }
        //public System.DateTime CreatedDate { get; set; }
        //public bool IsActive { get; set; }
        //public string IPAddress { get; set; }
    }
}