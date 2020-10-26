using Microsoft.AspNetCore.Mvc;
using Twilio.AspNet.Core;
using Twilio.TwiML;

namespace IoTBroochWebhook.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SmsController : TwilioController
    {
        [HttpPost]
        public TwiMLResult Index()
        {
            var messagingResponse = new MessagingResponse();
            messagingResponse.Message("This is an automated reply from an unmonitored number.");
            return TwiML(messagingResponse);
        }
    }

}