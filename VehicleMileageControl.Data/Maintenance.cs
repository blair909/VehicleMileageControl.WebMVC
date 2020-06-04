using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public DateTimeOffset CreatedUtc { get; set; }
        [Required]
        public DateTimeOffset? ModifiedUtc { get; set; }
        public int MessageId { get; set; }
        public string MessageStr { get; set; }
        [ForeignKey(nameof(MessageId))]
        public virtual Message Message { get; set; }
        public int VehicleInformationId { get; set; }
        public string VehicleInformationStr { get; set; }
        [ForeignKey(nameof(VehicleInformationId))]
        public virtual VehicleInformation VehicleInformation { get; set; }
        public int NoteId { get; set; }
        [ForeignKey(nameof(NoteId))]
        public virtual Note Note { get; set; }
    }
}