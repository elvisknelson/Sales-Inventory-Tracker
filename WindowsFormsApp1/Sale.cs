using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptApp
{
    class Sale
    {
        public List<Bin> bins = new List<Bin>();
        public int salesOrder { get; set; }

        public Sale(int _salesOrder)
        {
            salesOrder = _salesOrder;
        }
    }
}
