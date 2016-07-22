using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LFG.Models
{
    public class LFGDBContext: DbContext
    {
        public LFGDBContext() : base("defaultConnection")
        {

        }

        public DbSet<UserGamesData> UserData { get; set; }
        public DbSet<LeagueOfLegends> LeagueData { get; set; }
        public DbSet<PlayerType> PlayerTypes { get; set; }

        public DbSet<TimeOfDay> TimesOfDay { get; set; }
        public DbSet<LeagueRank> LeagueRanks { get; set; }
        public DbSet<GameMode> GameModes { get; set; }
    }
}