using CommandAPINEW.Models;

namespace CommandAPINEW.Data
{
    public class MockCommanderRepo : IcommandRepo
    {
        private readonly CommanderContext _context;

        public void CreateCommand(CommandModel cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommandModel> GetAllCommands()
        {
            var commandlist = new List<CommandModel>
            {
                new CommandModel { Id = 0, Howto = "To Boil Egg", Line = "Boil Water", Platform = "Kettle a pan" },
                new CommandModel { Id = 1, Howto = "Curl Bread", Line = "Bread Watrer", Platform = "Bread Water" },
                new CommandModel { Id = 2, Howto = "Test Water", Line = "Hello Water", Platform = "Kettle a pan" },
            };
            return commandlist;
        }

        public CommandModel GetNewCommandById(int id)
        {
            return new CommandModel { Id = id, Howto = "To Boil Egg", Line = "Boil Water", Platform = "Kettle a pan" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(CommandModel cmd)
        {
            throw new NotImplementedException();
        }
    }
}
