using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Model
{
    public class SavedPaymentInformationEdit
    {
        public int SavedPaymentInformationId { get; set; }
        [Required]
        [Range(12, 19, ErrorMessage = "Enter your correct card number with no spaces or dashes.")]
        [Display(Name = "Credit/Debit Card Number")]
        public int CardNumber { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Enter your correct full name.")]
        [MaxLength(40, ErrorMessage = "Enter your correct full name.")]
        [Display(Name = "Full Name (First Name + Last Name")]
        public string FullName { get; set; }
        [Required]
        [Display(Name = "Expiration Date")]
        public DateTime ExpirationDate
        {
            get;
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
