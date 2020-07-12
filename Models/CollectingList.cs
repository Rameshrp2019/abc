using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FTSMock.Models
{
    /// <summary>
    /// CollectingList
    /// </summary>
    public class CollectingList
    {
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string LocationName { get; set; }
        public string ProductionDate { get; set; }
        public string ProductionTime { get; set; }
        public string Role { get; set; }
        public string BranchTown { get; set; }
        public string BranchAddress { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Agreement> Agreements { get; set; }
        public List<PaymentHistory> PaymentHistory { get; set; }
    }
}