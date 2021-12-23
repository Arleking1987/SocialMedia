using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace App.Common.DTOs
{
   public class SpecialMeasureContract
    {
        public int IdMessage { get; set; }

        [Required]
        public string SenderName { get; set; }

        [Required]
        public string SenderEmail { get; set; }

        [Required]
        public string SenderMessage { get; set; }

        public DateTime MessageTime { get; set; }

        public string Status { get; set; }
    }
}
