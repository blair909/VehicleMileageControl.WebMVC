using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Model
{
    public class MaintenanceListItem
    {
        [Display(Name = "Maintenance Id")]
        public int MaintenanceId { get; set; }
        [Required]
        [Display(Name = "Odometer Mileage")]
        public int OdomoterMileage { get; set; }
        [Display(Name = "Personal Note Title")]
        public string PersonalNoteTitle { get; set; }
    }
}
