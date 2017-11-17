using System.IO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Scribble.Controllers
{
    [Produces("application/json")]
    [Route("api/WebHook")]
    public class WebHookController : Controller
    {
        [HttpPost]
        public void Post([FromBody]WebHookEvent webHookEvent)
        {
        }
    }

    public class WebHookEvent
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("repository")]
        public Repository Repository { get; set; }
    }

    public class Repository
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }
    }
}
