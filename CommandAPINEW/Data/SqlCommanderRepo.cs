using CommandAPINEW.Models;

namespace CommandAPINEW.Data
{
    public class SqlCommanderRepo : IcommandRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }
        public IEnumerable<CommandModel> GetAllCommands()
        {
            return _context.commands.ToList();
        }

        public CommandModel GetNewCommandById(int id)
        {
            return _context.commands.FirstOrDefault(p => p.Id == id);
        }
    }
}
