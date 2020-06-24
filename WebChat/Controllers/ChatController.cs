using ClientApi.Handlers;
using Microsoft.Web.WebSockets;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace WebChat.Controllers
{
    [RoutePrefix("api/chat")]
    public class ChatController : ApiController
    {
        // GET api/chat/ws/
        [Route("ws")]
        public HttpResponseMessage Get()
        {
            HttpContext.Current.AcceptWebSocketRequest(new ChatWebSocketHandler());
            return Request.CreateResponse(HttpStatusCode.SwitchingProtocols);
        }
    }
}
