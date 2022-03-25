using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    //future abstract class with residencial customer and corporation customer as child
    public class C_Customer
    {      
        public C_Customer() { }       

        public int custID { get; set; }
        public string fullName{ get; set;}                    
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }    
    }
}
