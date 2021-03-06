﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptApp
{
    class Bin
    {
        public int salesOrder { get; set; }
        public string binSize { get; set; }
        public DateTime promiseDate { get; set; }
        public int hoursWorked { get; set; }
        public string options { get; set; }
        public bool winterBin { get; set; }


        public Bin(int _salesOrder, string _binSize, DateTime _promiseDate, int _hoursWorked, string _options, bool _winterBin)
        {
            salesOrder = _salesOrder;
            binSize = _binSize;
            promiseDate = _promiseDate;
            hoursWorked = _hoursWorked;
            options = _options;
            winterBin = _winterBin;
        }
    }
}
