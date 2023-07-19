using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace crudApplication.Models
{
    //[Table("tblEmp")]
    public class EmployeeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(15)]
         [Required(ErrorMessage ="Value karin")]
        public string Name { get; set; }
        [MinLength(4)]
        [MaxLength(10)]
        [Required(ErrorMessage = "Value karin")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Value karin")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }
        public DateTime Brithdate { get; set; }
       
        public string Gender { get; set; }
        [Phone]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }
     
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Joindate { get; set; }
        //public int IsMarried { get; set; }
        public int DepID { get; set; }
        //public bool isActive { get; set; }
        [NotMapped]
        public String Department { get; set; }

    }

    public class PhoneNumberCheckViewModel
    {
        private string _countryCodeSelected;

        [Required]
        [Display(Name = "Issuing Country")]
        public string CountryCodeSelected
        {
            get => _countryCodeSelected;
            set => _countryCodeSelected = value.ToUpperInvariant();
        }

        [Required]
        [Display(Name = "Number to Check")]
        public string PhoneNumberRaw { get; set; }

        // Holds the validation response. Not for data entry.
        [Display(Name = "Valid Number")]
        public bool Valid { get; set; }

        // Holds the validation response. Not for data entry.
        [Display(Name = "Has Extension")]
        public bool HasExtension { get; set; }

        // Optionally, add more fields here for returning data to the user.
    }

    public enum Gender
    {
        Male ,
        Female 
    }
}
