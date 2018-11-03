using Newtonsoft.Json;
using RiotApiApp.Viewmodels;
using RiotNet.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace RiotApiApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string summonerName)
        {            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MatchList()
        {
            var summonerName = "Bommerhond";
            HttpClient httpClient = new HttpClient();
            var matchListJsonLink = "http://localhost:64959/api/match/GetMatchListBySummonerName?summonerName=" + summonerName;
            var matchListJsonString = httpClient.GetStringAsync(matchListJsonLink).Result;
            var matchListObject = JsonConvert.DeserializeObject<MatchList>(matchListJsonString);
            List<long> gameIds = new List<long>();
            foreach (var match in matchListObject.Matches.ToList())
            {
                gameIds.Add(match.GameId);
            }


            var summonerJsonLink = "http://localhost:64959/api/summoner/GetSummonerBySummonerName?summonerName=" + summonerName;
            var summonerJsonString = httpClient.GetStringAsync(summonerJsonLink).Result;
            var summonerObject = JsonConvert.DeserializeObject<Summoner>(summonerJsonString);
            var summonerAccountId = summonerObject.AccountId;

            List<Match> matches = new List<Match>();
            List<MatchParticipant> participants = new List<MatchParticipant>();
            List<int> participantIds = new List<int>();

            foreach(var gameId in gameIds)
            {
                var matchJsonLink = "http://localhost:64959/api/match/GetMatchByGameId?gameId=" + gameId;
                var matchJsonString = httpClient.GetStringAsync(matchJsonLink).Result;
                var matchObject = JsonConvert.DeserializeObject<Match>(matchJsonString);

                matches.Add(matchObject);

                foreach (var participantIdentity in matchObject.ParticipantIdentities)
                {
                    if (participantIdentity.Player.AccountId == summonerAccountId)
                    {
                        foreach (var participant in matchObject.Participants)
                        {
                            if (participantIdentity.ParticipantId == participant.ParticipantId)
                                participants.Add(participant);
                        }
                    }                    
                }
            }
            MatchListViewModel viewModel = new MatchListViewModel
            {
                Matches = matches,
                MatchParticipants = participants
            };

            return View("Index", viewModel);
        }
    }
}