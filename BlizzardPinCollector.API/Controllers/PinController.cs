using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using BlizzardPinCollector.API.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlizzardPinCollector.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PinController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public async Task <IActionResult> Get()
        {
            var json = string.Empty;
            using (var reader = new StreamReader("Pins.json"))
            {
                json = reader.ReadToEnd();
            }

            var pins = JsonConvert.DeserializeObject<List<Pin>>(json);
            return Ok(pins);
        }

        //    // GET api/values/5
        //    [HttpGet("{id}")]
        //    public async Task<IActionResult> Get(int id)
        //    {
        //        var json = string.Empty;
        //        using (var reader = new StreamReader("Pins.json"))
        //        {
        //            json = reader.ReadToEnd();
        //        }

        //        var pins = JsonConvert.DeserializeObject<List<Pin>>(json);

        //        return Ok(pins);
        //    }

        //    // POST api/values
        //    [HttpPost]
        //    public void Post([FromBody] string value)
        //    {
        //    }

        //    // PUT api/values/5
        //    [HttpPut("{id}")]
        //    public void Put(int id, [FromBody] string value)
        //    {
        //    }

        //    // DELETE api/values/5
        //    [HttpDelete("{id}")]
        //    public void Delete(int id)
        //    {
        //    }
    }
}
