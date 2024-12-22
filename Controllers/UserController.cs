using KognitAPI.Models;
using KognitAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace KognitAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;

        public UserController(UserService service)
        {
            _service = service;
        }

        [HttpPost]
        [ApiExplorerSettings(IgnoreApi = false)]
        public IActionResult CreateUser(User user)
        {
            _service.AddUser(user);
            return Ok("Usuário criado com sucesso.");
        }
    }

}
