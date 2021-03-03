using AutoMapper;
using CommandAPI.DTOs;
using CommandAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandAPI.Profiles
{
    public class CommandsProfile:Profile
    {
        public CommandsProfile()
        {
            //Source->Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>().ReverseMap();
        }
    }
}

