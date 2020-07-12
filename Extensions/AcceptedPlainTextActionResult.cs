using FTSMock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace FTSMock.Extensions
{
    public class AcceptedPlainTextActionResult : IHttpActionResult
    {
        public BusinessException Message { get; set; }
        public HttpRequestMessage Request { get; private set; }

        public AcceptedPlainTextActionResult(BusinessException message, HttpRequestMessage requestMessage)
        {
            Message = message;
            Request = requestMessage;
        }
        public Task<System.Net.Http.HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(ExecuteResult());
        }

        public HttpResponseMessage ExecuteResult()
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Accepted);
            response.Content = new StringContent(new JavaScriptSerializer().Serialize(Message));
            //testing added comment
            response.RequestMessage = Request;
            return response;
        }
    }
}
