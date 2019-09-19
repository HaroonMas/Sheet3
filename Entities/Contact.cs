using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Contact
    {
        public int contactid { get; set; }
        public string first { get; set; }
        public string last { get; set; }
        public string phone { get; set; }
        public string Bphone {get; set;}
        public string address { get; set; }
        public string notes { get; set; }
        public bool Active = true;

   


    }
}
