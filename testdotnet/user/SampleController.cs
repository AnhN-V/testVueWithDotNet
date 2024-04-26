using Microsoft.AspNetCore.Mvc;

namespace testdotnet
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var data = new
            {
                Id = 1,
                Name = "John Doe",
                Age = 30
            };

            return Ok(data);
        }
    }
}
