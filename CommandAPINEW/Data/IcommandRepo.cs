using CommandAPINEW.Models;

namespace CommandAPINEW.Data
{
    public interface IcommandRepo
    {
        bool SaveChanges();
        IEnumerable<CommandModel> GetAllCommands();
        CommandModel GetNewCommandById(int id);
        void  CreateCommand(CommandModel cmd);
        
        void UpdateCommand(CommandModel cmd);

    }
}
