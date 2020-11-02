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
            var commandItem = _repository.GetCommandsById(id);
            if(commandItem == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(commandItem);
            }
        }
    }
}