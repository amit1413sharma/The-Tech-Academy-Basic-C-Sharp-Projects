using System;
using System.ComponentModel.DataAnnotations;

namespace CarInsurance.Models
{
    [MetadataType(typeof(InsureeMetadata))]
    public partial class Insuree
    {
        // This class stays empty on purpose.
        // It allows metadata without editing the auto-generated model.
    }

    public class InsureeMetadata
    {
        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(50)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Range(1900, 2050)]
        [Display(Name = "Car Year")]
        public int CarYear { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Car Make")]
        public string CarMake { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Car Model")]
        public string CarModel { get; set; }

        [Required]
        [Display(Name = "DUI")]
        public bool DUI { get; set; }

        [Required]
        [Range(0, 100)]
        [Display(Name = "Speeding Tickets")]
        public int SpeedingTickets { get; set; }

        [Required]
        [Display(Name = "Coverage Type (Full Coverage)")]
        public bool CoverageType { get; set; }
    }
}
