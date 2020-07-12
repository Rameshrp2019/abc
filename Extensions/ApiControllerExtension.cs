using FTSMock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FTSMock.Extensions
{
    public static class ApiControllerExtension
    {
        public static NotFoundPlainTextActionResult NotFound(ApiController controller, string message)
        {
            return new NotFoundPlainTextActionResult(controller.Request, message);
        }

        public static AcceptedPlainTextActionResult Accepted(ApiController controller, string message, string exceptionCode, int deferralPeriod)
        {
            BusinessException businessException = new BusinessException();
            businessException.Message = message;
            businessException.ExceptionCode = exceptionCode;
            businessException.DeferralPeriod = deferralPeriod;
            return new AcceptedPlainTextActionResult(businessException,controller.Request);
        }
    }
}