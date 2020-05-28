using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Data
{
    public class Maintenance
    {
        [Key]
        public int MaintenanceId { get; set; }
        [Required]
        public Guid MaintenanceOwnerId { get; set; }
        [Required]
        public int OdomoterMileage { get; set; }
        [Required]
        public string PersonalNoteTitle { get; set; }
        [Required]
        public string PersonalNoteContent { get; set; }
        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        [Required]
        public DateTimeOffset ModifiedUtc { get; set; }
    }
}