using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Model
{
    public class SavedPaymentInformationListItem
    {
        [Display(Name = "Debit/Credit Card Id")]
        public int SavedPaymentInformationId { get; set; }
        [Display(Name = "Credit/Debit Card Number")]
        public int CardNumber { get; set; }
        [Display(Name = "Full Name (First Name + Last Name")]
        public string FullName { get; set; }
    }
}
