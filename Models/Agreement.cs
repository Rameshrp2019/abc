using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FTSMock.Models
{
    public class Agreement
    {
        public int ExpectedPayment { get; set; }
        public int ElectronicCollectionBln { get; set; }
        public int EarlySettlementBalance { get; set; }
        public string CLRNumber { get; set; }
        public int InstalmentToDate { get; set; }
        public int OutstandingBalance { get; set; }
        public int Arrears { get; set; }
        public int Term { get; set; }
        public string IssueDate { get; set; }
        public int AgreementNum { get; set; }
        public int AgreementId { get; set; }
        public string RepaymentFrequency { get; set; }
        public int ChosenPaymentDueDate { get; set; }
        public string HighlightChosenPaymentDueDate { get; set; }
        public int RemainingPaymentHoliday { get; set; }
        public string PaymentHolidayWeek { get; set; }
        public bool PaymentHolidayStrikeout { get; set; }
        public int RemainingPaymentFreeze { get; set; }
        public string PaymentFreezeWeek { get; set; }
        public bool PaymentFlexibilityStrikeout { get; set; }
        public string CollectionType { get; set; }
        public int PenaltyInterestDuenotpaid { get; set; }
        public string AgreementCheckDigit { get; set; }
        public int OpeningBalance { get; set; }
        public string DefaultChargeAppliedMessage { get; set; }
        public string DefaultChargeRemovedMessage { get; set; }
        public string DefaultChargeWarningMessage { get; set; }
        public int DefaultCharge { get; set; }
        public int DefaultRemovedCharge { get; set; }
        public string DefaultChargeAppliedWeek { get; set; }
        public string DefaultChargeWarningWeek { get; set; }
        public string DefaultChargeRemovedWeeks { get; set; }
        public string EnterCollectionSpace { get; set; }
        public string EnterCollectionSpacesWords { get; set; }
        public int AgreementLastDigits { get; set; }
        public int RFB { get; set; }
        public string BusinessLoan { get; set; }
        public string EarlySettlementQuoteMessage { get; set; }
        public string ElectronicAgreement { get; set; }
        public int Last5WeeksPayments { get; set; }
        public string PaymentRequired { get; set; }
        public int Rate { get; set; }
    }
}