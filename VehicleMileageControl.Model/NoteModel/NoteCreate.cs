using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Model.NoteModel
{
    public class NoteCreate
    {
        [Display(Name = "Note Id")]
        public int NoteId { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        [Display(Name = "Note Title")]
        public string NoteTitle { get; set; }
        [MaxLength(5000, ErrorMessage = "There are too many characters in this field.")]
        [Display(Name = "Note Content")]
        public string NoteContent { get; set; }
    }
}
