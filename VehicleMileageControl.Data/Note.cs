using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Data
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        [Required]
        public Guid NoteOwnerId { get; set; }
        [Required]
        public string NoteTitle { get; set; }
        [Required]
        public string NoteContent { get; set; }
        public int VehicleHistoryId { get; set; }
        [ForeignKey(nameof(VehicleHistoryId))]
        public virtual VehicleHistory VehicleHistory { get; set; }
    }
}
