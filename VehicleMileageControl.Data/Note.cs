using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string PersonalNoteTitle { get; set; }
        [Required]
        public string PersonalNoteContent { get; set; }
    }
}
