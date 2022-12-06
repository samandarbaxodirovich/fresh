﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fresh.Service.ViewModels
{
    public class ConsignmentLetterView
    {
        public DateTime DateTime { get; set; }
        public string Cashier { get; set; } = string.Empty;
        public float TotalPrice { get; set; }
    }
}