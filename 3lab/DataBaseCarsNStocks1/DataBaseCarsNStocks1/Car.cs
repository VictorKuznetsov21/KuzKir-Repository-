﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace DataBaseCarsNStocks
{
    public class Car
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int? DataRelease { get; set; }
        public int Cost { get; set; }
        public string? Remark { get; set; }
        public bool IsStock { get; set; }
        public Stock? Stock { get; set; }
    }

}
