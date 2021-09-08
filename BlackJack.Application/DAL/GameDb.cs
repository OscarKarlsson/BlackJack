using BlackJack.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Application.DAL
{
    public class GameDb : DbContext
    {

        public GameDb() : base("GameContext")
        {
        }

        public DbSet<CardModel> Cards { get; set; }
        public DbSet<GameHistoryModel> History { get; set; }
        public DbSet<PlayerModel> Players { get; set; }

    }
}
