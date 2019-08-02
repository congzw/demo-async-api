using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoAsyncApi.Controllers
{
    [Route("api/test")]
    public class TestController : ControllerBase
    {
        [Route("GetDate")]
        [HttpGet]
        public Task<DateTime> GetDate()
        {
            return Task.FromResult(DateTime.Now);
        }
    }
}
