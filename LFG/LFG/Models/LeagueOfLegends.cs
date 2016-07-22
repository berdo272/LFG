using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LFG.Models
{
    public class LeagueOfLegends
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string TimeOfDay { get; set; }
        public string TypeOfPlayer { get; set; }
        public string GameMode { get; set; }
        public int Rank { get; set; }

    }
}