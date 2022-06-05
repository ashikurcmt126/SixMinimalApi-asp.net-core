using AutoMapper;
using SixMinimalApi.Dtos;
using SixMinimalApi.Models;

namespace SixMinimalApi.Profiles
{
	public class CommandsProfile: Profile
	{
		public CommandsProfile()
		{
			//Source -> Target
			CreateMap<Command, CommandReadDto>();
			CreateMap<CommandCreateDto, Command>();
			CreateMap<CommandUpdateDto, Command>();
		}
	}
}

