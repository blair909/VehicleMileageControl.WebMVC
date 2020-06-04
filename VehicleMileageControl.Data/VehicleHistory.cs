﻿using System;
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
        public string FullName
        {
            get { return FullName; }
            set { FullName = $"{FirstName} {LastName}"; }
        }
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
        [Required]
        public DateTime ServiceDate
        {
            get { return ServiceDate; }
            set
            {
                ServiceDate.ToString("MM/dd/yyyy");
            }
        }
        [Required]
        public int OdometerMileage { get; set; }
        [Required]
        public string ServiceOne { get; set; }
        public string ServiceTwo { get; set; }
        public string ServiceThree { get; set; }
        public string ServiceFour { get; set; }
        public string ServiceFive { get; set; }
        [Required]
        public decimal ServiceOneCost
        {
            get { return ServiceOneCost; }
            set
            {
                ServiceOneCost.ToString($"${ServiceOneCost}");
            }
        }
        public decimal ServiceTwoCost
        {
            get { return ServiceTwoCost; }
            set
            {
                ServiceTwoCost.ToString($"${ServiceTwoCost}");
            }
        }
        public decimal ServiceThreeCost
        {
            get { return ServiceThreeCost; }
            set
            {
                ServiceThreeCost.ToString($"${ServiceThreeCost}");
            }
        }
        public decimal ServiceFourCost
        {
            get { return ServiceFourCost; }
            set
            {
                ServiceFourCost.ToString($"${ServiceFourCost}");
            }
        }
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