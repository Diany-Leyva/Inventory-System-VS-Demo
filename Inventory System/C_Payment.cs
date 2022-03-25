using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    public class C_Payment
    {
        public C_Payment() { }  
       
        public string Method { get; set; }   
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string CardName { get; set; }
        public string Phone { get; set; }
        public string CardNumber { get; set; }
        public int CVVNumber { get; set; }
        public string ExpDate { get; set; }  
    }
}
