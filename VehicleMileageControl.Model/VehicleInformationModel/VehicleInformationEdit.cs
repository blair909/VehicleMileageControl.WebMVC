using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Model.VehicleInformationModel
{
    public class VehicleInformationEdit
    {
        [Display(Name = "Vehicle Information Id")]
        public int VehicleInformationId { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(5000, ErrorMessage = "There are too many characters in this field.")]
        [Display(Name = "New Vehicle Information")]
        public string NewVehicleInformation { get; set; }
    }
}
