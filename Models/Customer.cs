using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FTSMock.Models
{
    public class Customer
    {
        public string CustomerShortName { get; set; }
        public int AgencySequenceNum { get; set; }
        public int IPPP { get; set; }
        public int CustomerSequenceNumber { get; set; }
        public string Frequency { get; set; }
        public int MaintainQualityAmount { get; set; }
        public string CustomerMarketingMessage { get; set; }
        public string CustomerFacingMarketingMessage { get; set; }
        public int CollectionPct { get; set; }
        public string HomeAddress { get; set; }
        public string FirstAgreementDate { get; set; }
        public int CustomerAge { get; set; }
        public string CustomerMobileTelephoneNumber { get; set; }
        public string HomeTelNum { get; set; }
        public string CustomerName { get; set; }
        public string MessageText { get; set; }
        public int CustomerNumber { get; set; }
        public int WkSinceLastPayment { get; set; }
        public string CollectionAddress { get; set; }
        public string District { get; set; }
        public int CustomerAbsoluteArrears { get; set; }
        public int TotalOutstandingBalance { get; set; }
        public int CustomerSettlementBalance { get; set; }
        public int TotalRate { get; set; }
        public string ContactDate { get; set; }
        public string ContactType { get; set; }
        public int CustomerLastPayment { get; set; }
        public int AgreedRate { get; set; }
        public string AgreedRateStartDate { get; set; }
        public string AgreedRateEndDate { get; set; }
        public int CustomerMaintainQualityMessage { get; set; }
        public string AgentCollectionSpace { get; set; }
        public int TotalRFB { get; set; }
        public int TotalExpected { get; set; }
        public int StageTargetValue { get; set; }
        public string Deceased { get; set; }
        public string UTR { get; set; }
        public string DayOfWeek { get; set; }
        public string DocumentReference { get; set; }
        public int QPPP { get; set; }
    }
}