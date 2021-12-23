using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace App.Infrastructure.Entities
{
    public partial class SpecialMeasureEntity
    {
        public int IdMessage { get; set; }
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public string SenderMessage { get; set; }
        public DateTime MessageTime { get; set; }
        public string Status { get; set; }
    }
}
