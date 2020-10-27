using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CommandAPI.Data;
using CommandAPI.Models;

namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CommandsController : ControllerBase
    {
        private readonly ICommandAPIRepo _repository;
        public CommandsController(ICommandAPIRepo repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandList = _repository.GetAllCommands();
            return Ok(commandList);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandsById(int id)
        {
            var commandResult = _repository.GetCommandsById(id);
            if(commandResult == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(commandResult);
            }
        }
    }
}