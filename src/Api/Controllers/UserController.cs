using System.Threading.Tasks;
using Api.Common;
using Application.Commands;
using Application.Common.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class UserController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> InsertUser([FromBody] UserDto userDto)
        {
            return Ok(await Mediator.Send(new InsertUserCommand { UserDto = userDto }));
        }
    }
}
