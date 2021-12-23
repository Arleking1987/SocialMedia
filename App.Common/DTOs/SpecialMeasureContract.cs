﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App.Common.DTOs
{
   public class SpecialMeasureContract
    {
        public int IdMessage { get; set; }
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public string SenderMessage { get; set; }
        public DateTime MessageTime { get; set; }
        public string Status { get; set; }
    }
}
