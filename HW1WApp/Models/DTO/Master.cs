﻿using System;
using System.Collections.Generic;

namespace HW1WApp.Models
{
    public partial class Master
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
    }
}
