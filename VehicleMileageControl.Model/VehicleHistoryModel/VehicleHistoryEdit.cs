using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Model.VehicleHistoryModel
{
    public class VehicleHistoryEdit
    {
        [Display(Name = "Vehicle History Id")]
        public int VehicleHistoryId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return FullName; }
            set { FullName = $"{FirstName} {LastName}"; }
        }
        [Display(Name = "Vehicle Make")]
        public string VehicleMake { get; set; }
        [Display(Name = "Vehicle Model")]
        public string VehicleModel { get; set; }
        [Display(Name = "Vehicle Year")]
        public int VehicleYear { get; set; }
        [Display(Name = "License Number")]
        public string LicenseNo { get; set; }
        [Display(Name = "VIN Number")]
        public string VinNo { get; set; }
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
        [Display(Name = "Service One")]
        public string ServiceOne { get; set; }
        [Display(Name = "Service Two")]
        public string ServiceTwo { get; set; }
        [Display(Name = "Service Three")]
        public string ServiceThree { get; set; }
        [Display(Name = "Service Four")]
        public string ServiceFour { get; set; }
        [Display(Name = "Service Five")]
        public string ServiceFive { get; set; }
        [Display(Name = "Service One Cost")]
        public decimal ServiceOneCost
        {
            get { return ServiceOneCost; }
            set
            {
                ServiceOneCost.ToString($"${ServiceOneCost}");
            }
        }
        [Display(Name = "Service Two Cost")]
        public decimal ServiceTwoCost
        {
            get { return ServiceTwoCost; }
            set
            {
                ServiceTwoCost.ToString($"${ServiceTwoCost}");
            }
        }
        [Display(Name = "Service Three Cost")]
        public decimal ServiceThreeCost
        {
            get { return ServiceThreeCost; }
            set
            {
                ServiceThreeCost.ToString($"${ServiceThreeCost}");
            }
        }
        [Display(Name = "Service Four Cost")]
        public decimal ServiceFourCost
        {
            get { return ServiceFourCost; }
            set
            {
                ServiceFourCost.ToString($"${ServiceFourCost}");
            }
        }
        [Display(Name = "Service Five Cost")]
        public decimal ServiceFiveCost
        {
            get { return ServiceFiveCost; }
            set
            {
                ServiceFiveCost.ToString($"${ServiceFiveCost}");
            }
        }
    }
}
