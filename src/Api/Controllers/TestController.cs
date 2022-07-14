using Api.Common;
using Application.Commands;
using Application.Common.Dtos;
using Application.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        public async Task<IActionResult> PostTest([FromBody] TestDto testDto)
        {
            return Ok(await Mediator.Send(new InsertTestRecordCommand { TestDto = testDto }));
        }
    }
}
