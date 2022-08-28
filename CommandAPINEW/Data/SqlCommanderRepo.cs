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

        public void CreateCommand(CommandModel cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.commands.Add(cmd);
            _context.SaveChanges();
        }

        public IEnumerable<CommandModel> GetAllCommands()
        {
            return _context.commands.ToList();
        }

        public CommandModel GetNewCommandById(int id)
        {
            return _context.commands.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
           return(_context.SaveChanges() >=0);
        }
    }
}
