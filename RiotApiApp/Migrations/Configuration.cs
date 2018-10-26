using Newtonsoft.Json;
using RiotApiApp.Models;
using RiotNet.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net.Http;

namespace RiotApiApp.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            InitializeStaticChampionData(context);
        }

        private async void InitializeStaticChampionData(ApplicationDbContext dbContext)
        {
            if (!dbContext.StaticChampions.Any())
            {
                HttpClient httpClient = new HttpClient();
                var championJsonLink = "http://ddragon.leagueoflegends.com/cdn/6.24.1/data/en_US/champion.json";
                var championJsonString = await httpClient.GetStringAsync(championJsonLink);
                var result = JsonConvert.DeserializeObject<StaticChampionList>(championJsonString);

                dbContext.StaticChampions.AddRange(result.Data.Values.ToList());
                dbContext.SaveChanges();
            }
        }
    }
}