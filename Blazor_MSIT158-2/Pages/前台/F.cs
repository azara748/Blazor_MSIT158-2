using Blazor_MSIT158_2.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blazor_MSIT158_2.Pages.前台
{
    [Route("api/[controller]")]
    [ApiController]
    public class F : ControllerBase
    {
        // GET: api/<F前台>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<F前台>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<F前台>
        [HttpPost]
        public void Post(TOrder value)
        {
            new fM購物車().結帳(value);
            return;
        }

        // PUT api/<F前台>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<F前台>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
