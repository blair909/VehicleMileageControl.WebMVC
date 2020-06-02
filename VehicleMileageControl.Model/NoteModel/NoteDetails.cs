using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Model.NoteModel
{
    public class NoteDetails
    {
        [Display(Name = "Note Id")]
        public int NoteId { get; set; }
        [Display(Name = "Note Title")]
        public string NoteTitle { get; set; }
        [Display(Name = "Note Content")]
        public string NoteContent { get; set; }
    }
}
