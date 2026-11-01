using DemoAPI.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjectController : ControllerBase
    {
        private readonly IServiceOne _serviceOne;
        private readonly IServiceTwo _serviceTwo;
        public ObjectController(IServiceOne serviceOne, IServiceTwo serviceTwo)
        {
            _serviceOne = serviceOne;
            _serviceTwo = serviceTwo;
        }

        [HttpGet("lifecycle")]
        public IActionResult TestObjectId()
        {
            return Ok(new
            {
                serviceOneId = _serviceOne.GetTrackerId(),
                serviceTwoId = _serviceTwo.GetTrackerId()
            });
        }
    }
}
