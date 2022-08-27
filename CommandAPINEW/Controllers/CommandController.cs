using AutoMapper;
using CommandAPINEW.Data;
using CommandAPINEW.Dtos;
using CommandAPINEW.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPINEW.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        private readonly IcommandRepo _repository;
        private readonly IMapper _mapper;

        public CommandController(IcommandRepo repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<CommandReadDto>> GetAllCommand()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
        }
        //GET api/commands/{id }
        [HttpGet("{id}")]
        public ActionResult <CommandModel> GetAllcommandById(int id)
        {
            var commandItem = _repository.GetNewCommandById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<CommandReadDto>(commandItem));
            }
            return NotFound();
        }
    }
}
