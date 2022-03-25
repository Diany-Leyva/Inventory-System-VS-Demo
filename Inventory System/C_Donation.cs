using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    public class C_Donation
    {
        public C_Donation() {}

        public int DonationID { get; set; }
        public string CustomerName { get; set; }
        public int ItemsDonated { get; set; }
        public DateTime DonationDate { get; set; }
        public double Total { get; set; }
        public string RequestType { get; set; }        
    }
}
