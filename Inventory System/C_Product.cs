using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{    
    public class C_Product
    {                           
        public C_Product() { }                                                                                           

        public int ProductID { get; set; }                
        public string Name { get; set; }
        public string Brand { get; set; }       
        public string Category { get; set; }
        public string Functional { get; set; }      
        public string Status { get; set; }
        public double Weight { get; set; }
        public int Quantity { get; set; }      
        public double Fee { get; set; }      
    }
}
