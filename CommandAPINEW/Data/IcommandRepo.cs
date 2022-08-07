using CommandAPINEW.Models;

namespace CommandAPINEW.Data
{
    public interface IcommandRepo
    {
        IEnumerable<CommandModel> GetAllCommands();
        CommandModel GetNewCommandById(int id);
    }
}
