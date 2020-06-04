using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Data
{
    public class VehicleHistory
    {
        [Key]
        public int VehicleHistoryId { get; set; }
        [Required]
        public Guid VehicleHistoryOwnerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string VehicleMake { get; set; }
        [Required]
        public string VehicleModel { get; set; }
        [Required]
        public int VehicleYear { get; set; }
        [Required]
        public string LicenseNo { get; set; }
        [Required]
        public string VinNo { get; set; }
        public DateTime ServiceDate { get; set; }
        [Required]
        public int OdometerMileage { get; set; }
        [Required]
        public string ServiceOne { get; set; }
        public string ServiceTwo { get; set; }
        public string ServiceThree { get; set; }
        public string ServiceFour { get; set; }
        public string ServiceFive { get; set; }
        [Required]
        public decimal ServiceOneCost { get; set; }
        public decimal ServiceTwoCost { get; set; }
        public decimal ServiceThreeCost { get; set; }
        public decimal ServiceFourCost { get; set; }
        public decimal ServiceFiveCost { get; set; }
    }
}