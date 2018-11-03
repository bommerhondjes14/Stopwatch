using RiotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RiotApiApp.Viewmodels
{
    public class MatchListViewModel
    {
        public List<Match> Matches { get; set; }
        public List<MatchParticipant> MatchParticipants { get; set; }
    }
}