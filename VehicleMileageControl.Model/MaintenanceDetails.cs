﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Model
{
    public class MaintenanceDetails
    {
        [Display(Name = "Maintenance Id")]
        public int MaintenanceId { get; set; }
        [Required]
        [Display(Name = "Odometer Mileage")]
        public int OdomoterMileage { get; set; }
        [Display(Name = "Personal Note Title")]
        public string PersonalNoteTitle { get; set; }
        [Display(Name = "Personal Note Content")]
        public string PersonalNoteContent { get; set; }
        [Display(Name = "Date Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        [Display(Name = "Date Modified")]
        public DateTimeOffset ModifiedUtc { get; set; }
    }
}
