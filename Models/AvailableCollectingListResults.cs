using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FTSMock.Models
{
    public class AvailableCollectingListResults
    {
        public AvailableCollectingListResults()
        {
            ActiveCollectingLists = new List<CollectingListSummary>();
        }

        public int ServerTimestamp { get; set; }
        public List<CollectingListSummary> ActiveCollectingLists { get; set; }
    }
}