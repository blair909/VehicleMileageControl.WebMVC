using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Model.VehicleHistoryModel
{
    public class VehicleHistoryListItem
    {
        [Display(Name = "Vehicle History Id")]
        public int VehicleHistoryId { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Vehicle Make")]
        public string VehicleMake { get; set; }
        [Display(Name = "Vehicle Year")]
        public int VehicleYear { get; set; }
        [Display(Name = "Date Serviced")]
        public DateTime ServiceDate
        {
            get { return ServiceDate; }
            set
            {
                ServiceDate.ToString("MM/dd/yyyy");
            }
        }
        [Display(Name = "Odometer Mileage")]
        public int OdometerMileage { get; set; }
    }
}
