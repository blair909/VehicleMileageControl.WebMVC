using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Model.MessageModel
{
    public class MessageEdit
    {
        [Display(Name = "Message Id")]
        public int MessageId { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(5000, ErrorMessage = "There are too many characters in this field.")]
        [Display(Name = "New Message")]
        public string NewMessage { get; set; }
    }
}
