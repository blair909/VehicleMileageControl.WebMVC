using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Model.VehicleInformation
{
    public class VehicleInformationListItem
    {
        [Display(Name = "Vehicle InformationId")]
        public int VehicleInformationId { get; set; }
    }
}
