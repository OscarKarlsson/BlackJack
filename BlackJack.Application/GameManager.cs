using BlackJack.Application.DAL;
using BlackJack.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlackJack.Application
{
    public class GameManager
    {
        private readonly GameDb _context;

        public GameManager(GameDb Context)
        {
            _context = Context;
        }

        public async Task AddPlayer(List<string> playerNames)
        {
            _context.Database.ExecuteSqlCommand("TRUNCATE TABLE[Players]");

            foreach (var player in playerNames)
            {
                PlayerModel newPlayer = new PlayerModel()
                {
                    Name = player,
                    Cash = 500
                };
                _context.Players.Add(newPlayer);
            }
            await _context.SaveChangesAsync();
        }
    }
}
