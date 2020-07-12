using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using FTSMock.Extensions;
using System.Web.Http.ModelBinding;
using FTSMock.Models;
using System.Web.Script.Serialization;
using System.Web.OData;
using Marvin.JsonPatch;

namespace FTSMock.Controllers
{
    public class CollectingListsController : ApiController
    {
        [Route("api/CollectingLists/{activeCollectingListId}")]
        public IHttpActionResult GetCollectingLists(int activeCollectingListId)
        {
            switch (activeCollectingListId)
            {
                case 1:
                    {
                        return ApiControllerExtension.Accepted(this, "An exception was encountered while processing the request, check response body for details.", "1", 0); ;
                    }
                case 2:
                    {
                        return BadRequest("Bad Request.");
                    }
                case 3:
                    {
                        Uri uri = this.Request.RequestUri;
                        return ApiControllerExtension.NotFound(this, string.Format("No HTTP resource was found that matches the request URI '{0}'.", uri.AbsoluteUri));
                    }
                default:
                    {
                        CollectingList collectingList = new CollectingList();
                        collectingList.Agreements = new List<Agreement>();
                        collectingList.Agreements.Add(new Agreement());
                        collectingList.Customers = new List<Customer>();
                        collectingList.Customers.Add(new Customer());
                        collectingList.PaymentHistory = new List<PaymentHistory>();
                        collectingList.PaymentHistory.Add(new PaymentHistory());
                        return Ok(collectingList);
                    }
            }
        }

        [Route("api/CollectingLists/{activeCollectingListId}/Status")]
        public IHttpActionResult GetCollectingLists(int activeCollectingListId, [FromBody]string newStatus)
        {
            switch (activeCollectingListId)
            {
                case 1:
                    {
                        return ApiControllerExtension.Accepted(this, "An exception was encountered while processing the request, check response body for details.", "1", 0); ;
                    }
                case 2:
                    {
                        return BadRequest("Bad Request.");
                    }
                case 3:
                    {
                        Uri uri = this.Request.RequestUri;
                        return ApiControllerExtension.NotFound(this, string.Format("No HTTP resource was found that matches the request URI '{0}'.", uri.AbsoluteUri));
                    }
                default:
                    {
                        CollectingList collectingList = new CollectingList();
                        collectingList.Agreements = new List<Agreement>();
                        collectingList.Agreements.Add(new Agreement());
                        collectingList.Customers = new List<Customer>();
                        collectingList.Customers.Add(new Customer());
                        collectingList.PaymentHistory = new List<PaymentHistory>();
                        collectingList.PaymentHistory.Add(new PaymentHistory());
                        return Ok(collectingList);
                    }
            }
        }

        [Route("api/CollectingLists/")]
        public IHttpActionResult GetCollectingLists(long? RepresentativeId, long? ModifiedSinceTimeStamp)
        {
            switch (RepresentativeId)
            {
                case 1:
                    {
                        return ApiControllerExtension.Accepted(this, "An exception was encountered while processing the request, check response body for details.", "1", 0); ;
                    }
                case 2:
                    {
                        return BadRequest("Bad Request.");
                    }
                default:
                    {
                        AvailableCollectingListResults availableCollectingList = new AvailableCollectingListResults();
                        availableCollectingList.ServerTimestamp = 1;
                        return Ok(availableCollectingList);
                    }
            }
        }
        [HttpPatch()]
        [Route("api/Customers/{CustomerNumber}")]
        public IHttpActionResult PatchCustomer(int CustomerNumber, JsonPatchDocument<Customer> customer)
        {
            Customer dbcustomer = new Customer() { CustomerNumber = 1, CustomerMobileTelephoneNumber = "22222222" };
            customer.ApplyTo(dbcustomer);
            return Ok(dbcustomer);
        }
    }
}
