using AutoMapper;
using CommandAPINEW.Dtos;
using CommandAPINEW.Models;

namespace CommandAPINEW.Profiles
{
    public class CommandsProfile:Profile
    {
        public CommandsProfile()
        {
            CreateMap<CommandModel, CommandReadDto>();
        }
    }
}
