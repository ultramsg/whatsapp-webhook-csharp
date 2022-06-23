using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace WebHookExample.Properties
{
    [Route("api/")]
    [ApiController]
    public class UltraMessageController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] HookData data)
        {
            Console.WriteLine(JsonSerializer.Serialize(data));
            return Ok(data);
        }
    }
}
