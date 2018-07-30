using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Filters;
using WeddingAPI.Filters;
using WeddingAPI.Models;

namespace WeddingAPI.Controller
{
    [MyExceptionFilter]
    public class GuestController : ApiController
    {
        [HttpPost]
        public async Task<HttpResponseMessage> RegisterGuest(RegisterGuestInput guest)
        {
            string result = await new Service.Service().RegisterGuest(guest);

            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}
