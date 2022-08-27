using CommandAPINEW.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandAPINEW.Data
{
    public class CommanderContext:DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {


        }
        public DbSet<CommandModel> commands { get; set; }

    }
}
