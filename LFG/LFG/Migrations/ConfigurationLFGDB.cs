namespace LFG.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LFG.Models;
    using System.Collections.Generic;
    internal sealed class ConfigurationLFGDB : DbMigrationsConfiguration<LFG.Models.LFGDBContext>
    {
        public ConfigurationLFGDB()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LFG.Models.LFGDBContext context)
        {
            List<TimeOfDay> TimesOfDay = new List<TimeOfDay>
            {
                new TimeOfDay
                {
                    PartOfDay = "Morning"
                },
                new TimeOfDay
                {
                    PartOfDay = "Mid Day"
                },
                new TimeOfDay
                {
                    PartOfDay = "Afternoon"
                },
                new TimeOfDay
                {
                    PartOfDay = "Evening"
                },
                new TimeOfDay
                {
                    PartOfDay = "Night"
                },
                new TimeOfDay
                {
                    PartOfDay = "Late Night"
                },
            };
            TimesOfDay.ForEach(b => context.TimesOfDay.Add(b));

            context.SaveChanges();
            List<LeagueRank> Ranks = new List<LeagueRank>
            {
                new LeagueRank
                {
                    Rank = "Bronze 5"
                },
                new LeagueRank
                {
                    Rank = "Bronze 4"
                },
                new LeagueRank
                {
                    Rank = "Bronze 3"
                },
                new LeagueRank
                {
                    Rank = "Bronze 2"
                },
                new LeagueRank
                {
                    Rank = "Bronze 1"
                },
                new LeagueRank
                {
                    Rank = "Silver 5"
                },
                new LeagueRank
                {
                    Rank = "Silver 4"
                },
                new LeagueRank
                {
                    Rank = "Silver 3"
                },
                new LeagueRank
                {
                    Rank = "Silver 2"
                },
                new LeagueRank
                {
                    Rank = "Silver 1"
                },
                new LeagueRank
                {
                    Rank = "Gold 5"
                },
                new LeagueRank
                {
                    Rank = "Gold 4"
                },
                new LeagueRank
                {
                    Rank = "Gold 3"
                },
                new LeagueRank
                {
                    Rank = "Gold 2"
                },
                new LeagueRank
                {
                    Rank = "Gold 1"
                },
                new LeagueRank
                {
                    Rank = "Platnium 5"
                },
                new LeagueRank
                {
                    Rank = "Platnium 4"
                },
                new LeagueRank
                {
                    Rank = "Platnium 3"
                },
                new LeagueRank
                {
                    Rank = "Platnium 2"
                },
                new LeagueRank
                {
                    Rank = "Platnium 1"
                },
                new LeagueRank
                {
                    Rank = "Diamond 5"
                },
                new LeagueRank
                {
                    Rank = "Diamond 4"
                },
                new LeagueRank
                {
                    Rank = "Diamond 3"
                },
                new LeagueRank
                {
                    Rank = "Diamond 2"
                },
                new LeagueRank
                {
                    Rank = "Diamond 1"
                },
                new LeagueRank
                {
                    Rank = "Master 1"
                },
                new LeagueRank
                {
                    Rank = "Challenger 1"
                },
            };
            Ranks.ForEach(d => context.LeagueRanks.Add(d));
            context.SaveChanges();

            List<PlayerType> types = new List<PlayerType>
            {
                new PlayerType
                {
                    PlayStyle = "Play To Win"
                },
                new PlayerType
                {
                    PlayStyle = "Play For Fun"
                },
                new PlayerType
                {
                    PlayStyle = "Trolling Around"
                },
                new PlayerType
                {
                    PlayStyle = "Learning"
                },
            };
            types.ForEach(f => context.PlayerTypes.Add(f));
            context.SaveChanges();
        }
    }
}
