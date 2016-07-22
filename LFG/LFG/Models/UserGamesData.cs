using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace LFG.Models
{
    public class UserGamesData
    {
        public int Id { get; set; }
        public string UserID { get; set; }
        public bool HasLeagueData { get; set; }
        public string SteamUserName { get; set; }
        public string LeagueUserName { get; set; }

    }
}