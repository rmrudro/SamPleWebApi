using CommandAPINEW.Data;
using CommandAPINEW.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPINEW.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<CommandModel>> GetAllCommand()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }
        //GET api/commands/5
        [HttpGet("{id}")]
        public ActionResult <CommandModel> GetAllcommandById(int id)
        {
            var commandItem = _repository.GetNewCommandById(id);
            return Ok(commandItem);
        }
    }
}
