
using SixMinimalApi.Models;

namespace SixMinimalApi.Data
{
	public interface ICommandRepo
	{
        Task SaveChanges();
		Task<Command?> GetCommandById(int id);
		Task<IEnumerable<Command>> GetAllCommands();
		Task CreateCommand(Command cmd);

		void DeleteCommand(Command cmd);
        void DeleteCommand(Task<Command?> command);
    }
}

