using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FTSMock.Models
{
    public class BusinessException
    {
        public string ExceptionCode { get; set; }
        public string Message { get; set; }
        public int DeferralPeriod { get; set; }
    }
}