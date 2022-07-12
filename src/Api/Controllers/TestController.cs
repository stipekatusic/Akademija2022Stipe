using System.Threading.Tasks;
using Api.Common;
using Application.Commands;
using Application.Queries;
using Domain.Entites;
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
        public async Task<IActionResult> PostTest([FromBody] Test test)
        {
            return Ok(await Mediator.Send(new InsertTestRecordCommand { Test = test }));
        }
    }
}
