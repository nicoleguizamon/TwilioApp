using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Twilio;

namespace TwilioService.Controllers
{
    public class TwilioController : ApiController
    {
        //TODO: This is an example using my own account, the account is a trial version.
        //TODO: SID and Token should be changed by an account configured by nimblesoft and should not be trial for real work.
        //TODO: FromPhoneNumber is a value configured in the account. It is a number provided bt Twilio.

        private const string accountSid = "";
        private const string authToken = "";
        private const string FromPhoneNumber = "+15123371984";
        public IHttpActionResult Post(Models.Message message)
        {
            string error = String.Empty;
            var client = new TwilioRestClient(accountSid, authToken);
            var result = client.SendMessage(FromPhoneNumber, "+" + message.PhoneNumber, message.TextMessage);
            if (result.RestException != null)
            {
                //an exception occurred making the REST call
                error = result.RestException.Message;
                return BadRequest(error);
            }
            
            return Ok("Success");
        }

    }
}
