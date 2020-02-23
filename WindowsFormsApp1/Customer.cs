using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }


        public Customer(int _id, string _name, string _address)
        {
            id = _id;
            name = _name;
            address = _address;
        }
    }
}
