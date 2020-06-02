using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VehicleMileageControl.Data;

namespace VehicleMileageControl.Model
{
    public class MaintenanceCreate
    {
        public int MaintenanceId { get; set; }
        [Required]
        [Range(0, 1000000, ErrorMessage = "Please enter a whole number between 0 and 1,000,000 with no decimal points, letters, or symbols. ")]
        [Display(Name = "Odometer Mileage")]
        public int OdomoterMileage { get; set; }
        [Display(Name = "Date Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        [Display(Name = "Message Id")]
        public int MessageId { get; set; }
        [Display(Name = "Message")]
        public string MessageStr { get; set; }
        [Display(Name = "Vehicle Information Id")]
        public int VehicleInformationId { get; set; }
        [Display(Name = "Vehicle Information")]
        public string VehicleInformationStr { get; set; }
        [Display(Name = "Note Id")]
        public int NoteId { get; set; }
    }
}
