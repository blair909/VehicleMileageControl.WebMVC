using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Model
{
    public class SavedPaymentInformationCreate
    {
        public int SavedPaymentInformationId { get; set; }
        [Required]
        [Range(12, 19, ErrorMessage = "Enter your correct card number with no spaces or dashes.")]
        [Display(Name = "Credit/Debit Card Number")]
        public int CardNumber { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Enter your correct full name (with a space in between first and last name).")]
        [MaxLength(40, ErrorMessage = "Enter your correct full name (with a space in between first and last name.")]
        [Display(Name = "Full Name (First Name + Last Name")]
        public string FullName { get; set; }
        [Required]
        [Display(Name = "Expiration Date")]
        public DateTime ExpirationDate
        {
            get { return ExpirationDate; }
            set
            {
                ExpirationDate.ToString("MM/yyyy");
            }
        }
        [Required]
        [Range(1, 6, ErrorMessage = "Enter your correct CVV number.")]
        [Display(Name = "CVV Number")]
        public int CVV { get; set; }
    }
}
