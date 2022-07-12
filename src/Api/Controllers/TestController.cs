using System.Threading.Tasks;
using Api.Common;
using Application.Commands;
using Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class TestController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetTest()
        {
            return Ok(await Mediator.Send(new GetTestRecordsQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> PostTest(InsertTestRecordCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}
