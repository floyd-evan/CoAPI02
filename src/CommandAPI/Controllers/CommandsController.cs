using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CommandAPI.Data;
using CommandAPI.Models;
using CommandAPI.Dtos;

namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CommandsController : ControllerBase
    {
        private readonly ICommandAPIRepo _repository;
        private readonly IMapper _mapper;
        public CommandsController(ICommandAPIRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var commandList = _repository.GetAllCommands();
            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandList));
        }

        [HttpGet("{id}")]
        public ActionResult<CommandReadDto> GetCommandsById(int id)
        {
            var commandItem = _repository.GetCommandsById(id);
            if(commandItem == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(_mapper.Map<CommandReadDto>(commandItem));
            }
        }
    }
}