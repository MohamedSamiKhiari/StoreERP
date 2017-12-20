using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreERP.Model.Setup
{
    public class EmployeeDetailModel
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "First Name")]
        public string FName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LName { get; set; }
       
        [Required]
        [Display(Name = "Mobile Number")]
        public string MobileNo { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "IsActive")]
        public bool IsActive { get; set; }

        public string Created_By { get; set; }
        public System.DateTime Created_On { get; set; }
        public string Updated_By { get; set; }
        public System.DateTime Updated_On { get; set; }

    }
}
