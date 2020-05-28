using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Model
{
    public class MaintenanceEdit
    {
        [Display(Name = "Maintenance Id")]
        public int MaintenanceId { get; set; }
        [Required]
        [Range(0, 1000000, ErrorMessage = "Please enter a whole number between 0 and 1,000,000 with no decimal points, letters, or symbols. ")]
        [Display(Name = "Odometer Mileage")]
        public int OdomoterMileage { get; set; }
        [MaxLength(80, ErrorMessage = "Please enter less than 80 characters. ")]
        [Display(Name = "Personal Note Title")]
        public string PersonalNoteTitle { get; set; }
        [MaxLength(5000, ErrorMessage = "Please enter less than 5000 characters. ")]
        [Display(Name = "Personal Note Content")]
        public string PersonalNoteContent { get; set; }
        [Display(Name = "Date Modified")]
        public DateTimeOffset ModifiedUtc { get; set; }
    }
}
