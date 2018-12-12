﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Stopwatch.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Migrations.Configuration>("DefaultConnection"));
        }

        //public DbSet<BannedChampion> BannedChampions { get; set; }
        //public DbSet<Block> Blocks { get; set; }
        //public DbSet<BlockItem> BlockItems { get; set; }
        //public DbSet<Champion> Champions { get; set; }
        //public DbSet<Group> Groups { get; set; }
        //public DbSet<LeagueList> LeagueLists { get; set; }
        //public DbSet<LeagueItem> LeagueItems { get; set; }
        //public DbSet<LeaguePosition> LeaguePositions { get; set; }
        //public DbSet<Match> Matches { get; set; }
        //public DbSet<MatchEvent> MatchEvents { get; set; }
        //public DbSet<MatchParticipant> MatchParticipants { get; set; }
        //public DbSet<MatchParticipantFrame> MatchParticipantFrames { get; set; }
        //public DbSet<MatchParticipantIdentity> MatchParticipantIdentities { get; set; }
        //public DbSet<MatchReference> MatchReferences { get; set; }
        //public DbSet<MatchTeam> MatchTeams { get; set; }
        //public DbSet<MatchTimeline> MatchTimelines { get; set; }
        //public DbSet<Player> Players { get; set; }
        //public DbSet<Recommended> RecommendedItemSets { get; set; }
        //public DbSet<Rune> Runes { get; set; }
        //public DbSet<Skin> Skins { get; set; }
        //public DbSet<SpellVars> SpellVars { get; set; }
        //public DbSet<StaticChampion> StaticChampions { get; set; }
        //public DbSet<StaticChampionSpell> StaticChampionSpells { get; set; }
        //public DbSet<AltImage> StaticImages { get; set; }
        //public DbSet<StaticItem> StaticItems { get; set; }
        //public DbSet<StaticItemTree> StaticItemTrees { get; set; }
        //public DbSet<StaticMapDetails> StaticMapDetails { get; set; }
        //public DbSet<StaticMastery> StaticMasteries { get; set; }
        //public DbSet<StaticMasteryTreeList> StaticMasteryTreeLists { get; set; }
        //public DbSet<StaticMasteryTree> StaticMasteryTrees { get; set; }
        //public DbSet<StaticRealm> StaticRealms { get; set; }
        //public DbSet<StaticRune> StaticRunes { get; set; }
        //public DbSet<StaticSummonerSpell> StaticSummonerSpells { get; set; }
        //public DbSet<Summoner> Summoners { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}