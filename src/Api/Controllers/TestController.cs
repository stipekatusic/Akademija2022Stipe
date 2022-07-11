using System.Threading.Tasks;
using Api.Common;
using Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class TestController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> Test()
        {
            return Ok(await Mediator.Send(new GetTestRecordsQuery()));
        }
    }
}
