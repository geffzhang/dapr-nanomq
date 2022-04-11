using Dapr;
using Dapr.Client;
using Microsoft.AspNetCore.Mvc;

namespace DaprMqttCS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DriverDetailsController : ControllerBase
    {
        private readonly DaprClient client;
        private readonly ILogger logger;

        public DriverDetailsController(DaprClient client,ILoggerFactory factory)
        {
            this.client = client;
            this.logger = factory.CreateLogger<DriverDetailsController>();
        }


        [Topic("mqtt-pubsub", "driverdetails")]
        [HttpPost("driverdetails")]
        public async Task<IActionResult> ProcessMessage(Driver driver)
        {
            logger.LogInformation($"----------> {driver.FirstName} {driver.LastName}");
            return Ok();
        }

        [HttpPost]
        [Route("Sender")]
        public async Task<IActionResult> Sender([FromBody] Driver driver)
        {
            await client.PublishEventAsync("mqtt-pubsub", "driverdetails", driver);
            return Created("driverdetails", driver);
        }
    }
}