using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FTSMock.Models
{
    public class CollectingListSummary
    {
        public int ActiveCollectingListId { get; set; }
        public bool IsActiveBln { get; set; }
        public int RepresentativeId { get; set; }
        public int AgencyId { get; set; }
        public int MainAgentId { get; set; }
        public int AccountingWeekNumber { get; set; }
    }
}