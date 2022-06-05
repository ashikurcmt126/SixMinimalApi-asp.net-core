using System;
using Microsoft.EntityFrameworkCore;
using SixMinimalApi.Models;

namespace SixMinimalApi.Data
{
    public class CommandRepo : ICommandRepo
    {
        private readonly AppDbContext _context;

        public CommandRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateCommand(Command cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            await _context.AddAsync(cmd);
        }

        public void DeleteCommand(Command cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.commands.Remove(cmd);
        }

        public async Task<Command?> GetCommandById(int id)
        {
            return await _context.commands.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Command>> GetAllCommands()
        {
            return await _context.commands.ToListAsync();
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        public void DeleteCommand(Task<Command?> command)
        {
            throw new NotImplementedException();
        }
    }
}

