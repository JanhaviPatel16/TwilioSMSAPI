
using Microsoft.AspNetCore.Mvc;
using TwilioAPI.Dtos;
using TwilioAPI.Services;

namespace TwilioAPI.Controllers
{
    [ApiController]
    [Route("SMS")]
    public class SMSController : ControllerBase
    {
        private readonly ISMSService _SMSService;

        public SMSController(ISMSService SMSService)
        {
            _SMSService = SMSService;
        }
        [HttpPost("Send")]
        public async Task<IActionResult> SendAsync(MessageRessourceDto model)
        {
            try
            {
                var result = await _SMSService.SendAsync(model.Message, model.To);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}