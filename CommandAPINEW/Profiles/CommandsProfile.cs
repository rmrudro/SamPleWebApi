using AutoMapper;
using CommandAPINEW.Dtos;
using CommandAPINEW.Models;

namespace CommandAPINEW.Profiles
{
    public class CommandsProfile:Profile
    {
        public CommandsProfile()
        {
            //source -> Target
            CreateMap<CommandModel, CommandReadDto>();
            CreateMap<CommandCreateDto,CommandModel>();
            CreateMap<CommandUpdateDto,CommandModel>();
        }
    }
}
