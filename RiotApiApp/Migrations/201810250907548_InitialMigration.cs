namespace RiotApiApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BannedChampions",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        ChampionId = c.Long(nullable: false),
                        PickTurn = c.Int(nullable: false),
                        TeamId = c.Int(nullable: false),
                        MatchTeam_DatabaseId = c.Long(),
                    })
                .PrimaryKey(t => t.DatabaseId)
                .ForeignKey("dbo.MatchTeams", t => t.MatchTeam_DatabaseId)
                .Index(t => t.MatchTeam_DatabaseId);
            
            CreateTable(
                "dbo.BlockItems",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        Id = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        Block_DatabaseId = c.Long(),
                    })
                .PrimaryKey(t => t.DatabaseId)
                .ForeignKey("dbo.Blocks", t => t.Block_DatabaseId)
                .Index(t => t.Block_DatabaseId);
            
            CreateTable(
                "dbo.Blocks",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        RecMath = c.Boolean(nullable: false),
                        Type = c.String(),
                        Recommended_DatabaseId = c.Long(),
                    })
                .PrimaryKey(t => t.DatabaseId)
                .ForeignKey("dbo.Recommendeds", t => t.Recommended_DatabaseId)
                .Index(t => t.Recommended_DatabaseId);
            
            CreateTable(
                "dbo.Champions",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Active = c.Boolean(nullable: false),
                        BotEnabled = c.Boolean(nullable: false),
                        BotMmEnabled = c.Boolean(nullable: false),
                        FreeToPlay = c.Boolean(nullable: false),
                        RankedPlayEnabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        MaxGroupOwnable = c.String(),
                        Key = c.String(),
                    })
                .PrimaryKey(t => t.DatabaseId);
            
            CreateTable(
                "dbo.LeagueItems",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        Rank = c.String(),
                        FreshBlood = c.Boolean(nullable: false),
                        HotStreak = c.Boolean(nullable: false),
                        Inactive = c.Boolean(nullable: false),
                        Veteran = c.Boolean(nullable: false),
                        LeaguePoints = c.Int(nullable: false),
                        Losses = c.Int(nullable: false),
                        MiniSeries_Losses = c.Int(nullable: false),
                        MiniSeries_Progress = c.String(),
                        MiniSeries_Target = c.Int(nullable: false),
                        MiniSeries_Wins = c.Int(nullable: false),
                        PlayerOrTeamId = c.String(),
                        PlayerOrTeamName = c.String(),
                        Wins = c.Int(nullable: false),
                        LeagueId = c.String(),
                        LeagueName = c.String(),
                        QueueType = c.String(),
                        Tier = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        LeagueList_LeagueId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.DatabaseId)
                .ForeignKey("dbo.LeagueLists", t => t.LeagueList_LeagueId)
                .Index(t => t.LeagueList_LeagueId);
            
            CreateTable(
                "dbo.LeagueLists",
                c => new
                    {
                        LeagueId = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Queue = c.String(),
                        Tier = c.String(),
                    })
                .PrimaryKey(t => t.LeagueId);
            
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        GameId = c.Long(nullable: false),
                        MapId = c.Int(nullable: false),
                        GameCreation = c.DateTime(nullable: false),
                        GameDuration = c.Time(nullable: false, precision: 7),
                        GameMode = c.String(),
                        GameType = c.String(),
                        GameVersion = c.String(),
                        PlatformId = c.String(),
                        QueueId = c.Int(nullable: false),
                        SeasonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GameId);
            
            CreateTable(
                "dbo.MatchParticipantIdentities",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        ParticipantId = c.Int(nullable: false),
                        Player_CurrentPlatformId = c.String(),
                        Player_PlatformId = c.String(),
                        Player_CurrentAccountId = c.Long(nullable: false),
                        Player_AccountId = c.Long(nullable: false),
                        Player_MatchHistoryUri = c.String(),
                        Player_ProfileIcon = c.Int(nullable: false),
                        Player_SummonerId = c.Long(nullable: false),
                        Player_SummonerName = c.String(),
                        Match_GameId = c.Long(),
                    })
                .PrimaryKey(t => t.DatabaseId)
                .ForeignKey("dbo.Matches", t => t.Match_GameId)
                .Index(t => t.Match_GameId);
            
            CreateTable(
                "dbo.MatchParticipants",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        ChampionId = c.Int(nullable: false),
                        HighestAchievedSeasonTier = c.String(),
                        ParticipantId = c.Int(nullable: false),
                        Spell1Id = c.Int(nullable: false),
                        Spell2Id = c.Int(nullable: false),
                        Stats_AltarsCaptured = c.Int(nullable: false),
                        Stats_AltarsNeutralized = c.Int(nullable: false),
                        Stats_Assists = c.Int(nullable: false),
                        Stats_ChampLevel = c.Int(nullable: false),
                        Stats_CombatPlayerScore = c.Int(nullable: false),
                        Stats_DamageDealtToObjectives = c.Long(nullable: false),
                        Stats_DamageDealtToTurrets = c.Long(nullable: false),
                        Stats_DamageSelfMitigated = c.Long(nullable: false),
                        Stats_Deaths = c.Int(nullable: false),
                        Stats_DoubleKills = c.Int(nullable: false),
                        Stats_FirstBloodAssist = c.Boolean(nullable: false),
                        Stats_FirstBloodKill = c.Boolean(nullable: false),
                        Stats_FirstInhibitorAssist = c.Boolean(nullable: false),
                        Stats_FirstInhibitorKill = c.Boolean(nullable: false),
                        Stats_FirstTowerAssist = c.Boolean(nullable: false),
                        Stats_FirstTowerKill = c.Boolean(nullable: false),
                        Stats_GoldEarned = c.Long(nullable: false),
                        Stats_GoldSpent = c.Int(nullable: false),
                        Stats_InhibitorKills = c.Int(nullable: false),
                        Stats_Item0 = c.Int(nullable: false),
                        Stats_Item1 = c.Int(nullable: false),
                        Stats_Item2 = c.Int(nullable: false),
                        Stats_Item3 = c.Int(nullable: false),
                        Stats_Item4 = c.Int(nullable: false),
                        Stats_Item5 = c.Int(nullable: false),
                        Stats_Item6 = c.Int(nullable: false),
                        Stats_KillingSprees = c.Int(nullable: false),
                        Stats_Kills = c.Int(nullable: false),
                        Stats_LargestCriticalStrike = c.Int(nullable: false),
                        Stats_LargestKillingSpree = c.Int(nullable: false),
                        Stats_LargestMultiKill = c.Int(nullable: false),
                        Stats_LongestTimeSpentLiving = c.Int(nullable: false),
                        Stats_MagicDamageDealt = c.Long(nullable: false),
                        Stats_MagicDamageDealtToChampions = c.Long(nullable: false),
                        Stats_MagicalDamageTaken = c.Long(nullable: false),
                        Stats_TotalMinionsKilled = c.Int(nullable: false),
                        Stats_NeutralMinionsKilled = c.Int(nullable: false),
                        Stats_NeutralMinionsKilledEnemyJungle = c.Int(nullable: false),
                        Stats_NeutralMinionsKilledTeamJungle = c.Int(nullable: false),
                        Stats_NodeCapture = c.Int(nullable: false),
                        Stats_NodeCaptureAssist = c.Int(nullable: false),
                        Stats_NodeNeutralize = c.Int(nullable: false),
                        Stats_NodeNeutralizeAssist = c.Int(nullable: false),
                        Stats_ObjectivePlayerScore = c.Int(nullable: false),
                        Stats_ParticipantId = c.Int(nullable: false),
                        Stats_PentaKills = c.Int(nullable: false),
                        Stats_PerkPrimaryStyle = c.Long(nullable: false),
                        Stats_PerkSubStyle = c.Long(nullable: false),
                        Stats_Perk0 = c.Long(nullable: false),
                        Stats_Perk0Var1 = c.Long(nullable: false),
                        Stats_Perk0Var2 = c.Long(nullable: false),
                        Stats_Perk0Var3 = c.Long(nullable: false),
                        Stats_Perk1 = c.Long(nullable: false),
                        Stats_Perk1Var1 = c.Long(nullable: false),
                        Stats_Perk1Var2 = c.Long(nullable: false),
                        Stats_Perk1Var3 = c.Long(nullable: false),
                        Stats_Perk2 = c.Long(nullable: false),
                        Stats_Perk2Var1 = c.Long(nullable: false),
                        Stats_Perk2Var2 = c.Long(nullable: false),
                        Stats_Perk2Var3 = c.Long(nullable: false),
                        Stats_Perk3 = c.Long(nullable: false),
                        Stats_Perk3Var1 = c.Long(nullable: false),
                        Stats_Perk3Var2 = c.Long(nullable: false),
                        Stats_Perk3Var3 = c.Long(nullable: false),
                        Stats_Perk4 = c.Long(nullable: false),
                        Stats_Perk4Var1 = c.Long(nullable: false),
                        Stats_Perk4Var2 = c.Long(nullable: false),
                        Stats_Perk4Var3 = c.Long(nullable: false),
                        Stats_Perk5 = c.Long(nullable: false),
                        Stats_Perk5Var1 = c.Long(nullable: false),
                        Stats_Perk5Var2 = c.Long(nullable: false),
                        Stats_Perk5Var3 = c.Long(nullable: false),
                        Stats_PhysicalDamageDealt = c.Long(nullable: false),
                        Stats_PhysicalDamageDealtToChampions = c.Long(nullable: false),
                        Stats_PhysicalDamageTaken = c.Long(nullable: false),
                        Stats_QuadraKills = c.Int(nullable: false),
                        Stats_SightWardsBoughtInGame = c.Int(nullable: false),
                        Stats_TeamObjective = c.Int(nullable: false),
                        Stats_TimeCCingOthers = c.Long(nullable: false),
                        Stats_TotalDamageDealt = c.Long(nullable: false),
                        Stats_TotalDamageDealtToChampions = c.Long(nullable: false),
                        Stats_TotalDamageTaken = c.Long(nullable: false),
                        Stats_TotalHeal = c.Long(nullable: false),
                        Stats_TotalPlayerScore = c.Int(nullable: false),
                        Stats_TotalScoreRank = c.Int(nullable: false),
                        Stats_TotalTimeCrowdControlDealt = c.Int(nullable: false),
                        Stats_TotalUnitsHealed = c.Long(nullable: false),
                        Stats_TowerKills = c.Int(nullable: false),
                        Stats_TripleKills = c.Int(nullable: false),
                        Stats_TrueDamageDealt = c.Long(nullable: false),
                        Stats_TrueDamageDealtToChampions = c.Long(nullable: false),
                        Stats_TrueDamageTaken = c.Int(nullable: false),
                        Stats_TurretKills = c.Int(nullable: false),
                        Stats_UnrealKills = c.Int(nullable: false),
                        Stats_VisionScore = c.Long(nullable: false),
                        Stats_VisionWardsBoughtInGame = c.Int(nullable: false),
                        Stats_WardsKilled = c.Int(nullable: false),
                        Stats_WardsPlaced = c.Int(nullable: false),
                        Stats_Win = c.Boolean(nullable: false),
                        TeamId = c.Int(nullable: false),
                        Timeline_CreepsPerMinDeltas_ZeroToTen = c.Double(nullable: false),
                        Timeline_CreepsPerMinDeltas_TenToTwenty = c.Double(nullable: false),
                        Timeline_CreepsPerMinDeltas_TwentyToThirty = c.Double(nullable: false),
                        Timeline_CsDiffPerMinDeltas_ZeroToTen = c.Double(nullable: false),
                        Timeline_CsDiffPerMinDeltas_TenToTwenty = c.Double(nullable: false),
                        Timeline_CsDiffPerMinDeltas_TwentyToThirty = c.Double(nullable: false),
                        Timeline_DamageTakenDiffPerMinDeltas_ZeroToTen = c.Double(nullable: false),
                        Timeline_DamageTakenDiffPerMinDeltas_TenToTwenty = c.Double(nullable: false),
                        Timeline_DamageTakenDiffPerMinDeltas_TwentyToThirty = c.Double(nullable: false),
                        Timeline_DamageTakenPerMinDeltas_ZeroToTen = c.Double(nullable: false),
                        Timeline_DamageTakenPerMinDeltas_TenToTwenty = c.Double(nullable: false),
                        Timeline_DamageTakenPerMinDeltas_TwentyToThirty = c.Double(nullable: false),
                        Timeline_GoldPerMinDeltas_ZeroToTen = c.Double(nullable: false),
                        Timeline_GoldPerMinDeltas_TenToTwenty = c.Double(nullable: false),
                        Timeline_GoldPerMinDeltas_TwentyToThirty = c.Double(nullable: false),
                        Timeline_Lane = c.String(),
                        Timeline_ParticipantId = c.Int(nullable: false),
                        Timeline_Role = c.String(),
                        Timeline_XpDiffPerMinDeltas_ZeroToTen = c.Double(nullable: false),
                        Timeline_XpDiffPerMinDeltas_TenToTwenty = c.Double(nullable: false),
                        Timeline_XpDiffPerMinDeltas_TwentyToThirty = c.Double(nullable: false),
                        Timeline_XpPerMinDeltas_ZeroToTen = c.Double(nullable: false),
                        Timeline_XpPerMinDeltas_TenToTwenty = c.Double(nullable: false),
                        Timeline_XpPerMinDeltas_TwentyToThirty = c.Double(nullable: false),
                        Match_GameId = c.Long(),
                    })
                .PrimaryKey(t => t.DatabaseId)
                .ForeignKey("dbo.Matches", t => t.Match_GameId)
                .Index(t => t.Match_GameId);
            
            CreateTable(
                "dbo.Masteries",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        Id = c.Int(nullable: false),
                        MasteryId = c.Int(nullable: false),
                        Rank = c.Int(nullable: false),
                        MatchParticipant_DatabaseId = c.Long(),
                    })
                .PrimaryKey(t => t.DatabaseId)
                .ForeignKey("dbo.MatchParticipants", t => t.MatchParticipant_DatabaseId)
                .Index(t => t.MatchParticipant_DatabaseId);
            
            CreateTable(
                "dbo.Runes",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        Count = c.Long(nullable: false),
                        Rank = c.Long(nullable: false),
                        RuneId = c.Long(nullable: false),
                        MatchParticipant_DatabaseId = c.Long(),
                    })
                .PrimaryKey(t => t.DatabaseId)
                .ForeignKey("dbo.MatchParticipants", t => t.MatchParticipant_DatabaseId)
                .Index(t => t.MatchParticipant_DatabaseId);
            
            CreateTable(
                "dbo.MatchTeams",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        BaronKills = c.Int(nullable: false),
                        DominionVictoryScore = c.Int(nullable: false),
                        DragonKills = c.Int(nullable: false),
                        FirstBaron = c.Boolean(nullable: false),
                        FirstBlood = c.Boolean(nullable: false),
                        FirstDragon = c.Boolean(nullable: false),
                        FirstInhibitor = c.Boolean(nullable: false),
                        FirstRiftHerald = c.Boolean(nullable: false),
                        FirstTower = c.Boolean(nullable: false),
                        InhibitorKills = c.Int(nullable: false),
                        RiftHeraldKills = c.Int(nullable: false),
                        TeamId = c.Int(nullable: false),
                        TowerKills = c.Int(nullable: false),
                        VilemawKills = c.Int(nullable: false),
                        Win = c.Boolean(nullable: false),
                        Match_GameId = c.Long(),
                    })
                .PrimaryKey(t => t.DatabaseId)
                .ForeignKey("dbo.Matches", t => t.Match_GameId)
                .Index(t => t.Match_GameId);
            
            CreateTable(
                "dbo.MatchEvents",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        AfterId = c.Int(),
                        AscendedType = c.String(),
                        AssistingParticipantIds_Value = c.String(),
                        BeforeId = c.Int(),
                        BuildingType = c.String(),
                        CreatorId = c.Int(),
                        EventType = c.String(),
                        ItemId = c.Int(),
                        KillerId = c.Int(),
                        LaneType = c.String(),
                        LevelUpType = c.String(),
                        MonsterType = c.String(),
                        MonsterSubType = c.String(),
                        ParticipantId = c.Int(),
                        PointCaptured = c.String(),
                        Position_X = c.Int(nullable: false),
                        Position_Y = c.Int(nullable: false),
                        SkillSlot = c.Int(),
                        TeamId = c.Int(),
                        Timestamp = c.Time(nullable: false, precision: 7),
                        TowerType = c.String(),
                        Type = c.String(),
                        VictimId = c.Int(),
                        WardType = c.String(),
                        MatchFrame_DatabaseId = c.Long(),
                    })
                .PrimaryKey(t => t.DatabaseId)
                .ForeignKey("dbo.MatchFrames", t => t.MatchFrame_DatabaseId)
                .Index(t => t.MatchFrame_DatabaseId);
            
            CreateTable(
                "dbo.MatchParticipantFrames",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        CurrentGold = c.Int(nullable: false),
                        DominionScore = c.Int(nullable: false),
                        JungleMinionsKilled = c.Int(nullable: false),
                        Level = c.Int(nullable: false),
                        MinionsKilled = c.Int(nullable: false),
                        ParticipantId = c.Int(nullable: false),
                        Position_X = c.Int(nullable: false),
                        Position_Y = c.Int(nullable: false),
                        TeamScore = c.Int(nullable: false),
                        TotalGold = c.Int(nullable: false),
                        Xp = c.Int(nullable: false),
                        MatchFrame_DatabaseId = c.Long(),
                    })
                .PrimaryKey(t => t.DatabaseId)
                .ForeignKey("dbo.MatchFrames", t => t.MatchFrame_DatabaseId)
                .Index(t => t.MatchFrame_DatabaseId);
            
            CreateTable(
                "dbo.MatchReferences",
                c => new
                    {
                        GameId = c.Long(nullable: false),
                        Champion = c.Int(nullable: false),
                        Lane = c.String(),
                        PlatformId = c.String(),
                        Queue = c.Int(nullable: false),
                        Role = c.String(),
                        Season = c.Int(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.GameId);
            
            CreateTable(
                "dbo.MatchTimelines",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        FrameInterval = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.DatabaseId);
            
            CreateTable(
                "dbo.MatchFrames",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        Timestamp = c.Time(nullable: false, precision: 7),
                        MatchTimeline_DatabaseId = c.Long(),
                    })
                .PrimaryKey(t => t.DatabaseId)
                .ForeignKey("dbo.MatchTimelines", t => t.MatchTimeline_DatabaseId)
                .Index(t => t.MatchTimeline_DatabaseId);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        ChampionId = c.Int(nullable: false),
                        SummonerId = c.Long(nullable: false),
                        TeamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DatabaseId);
            
            CreateTable(
                "dbo.Recommendeds",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        Champion = c.String(),
                        Map = c.String(),
                        Mode = c.String(),
                        Priority = c.Boolean(nullable: false),
                        Title = c.String(),
                        Type = c.String(),
                        StaticChampion_Id = c.Int(),
                    })
                .PrimaryKey(t => t.DatabaseId)
                .ForeignKey("dbo.StaticChampions", t => t.StaticChampion_Id)
                .Index(t => t.StaticChampion_Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Skins",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Num = c.Int(nullable: false),
                        StaticChampion_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StaticChampions", t => t.StaticChampion_Id)
                .Index(t => t.StaticChampion_Id);
            
            CreateTable(
                "dbo.SpellVars",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        Coeff_Value = c.String(),
                        Dyn = c.String(),
                        Key = c.String(),
                        Link = c.String(),
                        RanksWith = c.String(),
                        StaticChampionSpell_DatabaseId = c.Long(),
                        StaticSummonerSpell_Id = c.Int(),
                    })
                .PrimaryKey(t => t.DatabaseId)
                .ForeignKey("dbo.StaticChampionSpells", t => t.StaticChampionSpell_DatabaseId)
                .ForeignKey("dbo.StaticSummonerSpells", t => t.StaticSummonerSpell_Id)
                .Index(t => t.StaticChampionSpell_DatabaseId)
                .Index(t => t.StaticSummonerSpell_Id);
            
            CreateTable(
                "dbo.StaticChampions",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        AllyTips_Value = c.String(),
                        Blurb = c.String(),
                        EnemyTips_Value = c.String(),
                        Image_Full = c.String(),
                        Image_Group = c.String(),
                        Image_Sprite = c.String(),
                        Image_X = c.Int(nullable: false),
                        Image_Y = c.Int(nullable: false),
                        Image_W = c.Int(nullable: false),
                        Image_H = c.Int(nullable: false),
                        Info_Attack = c.Int(nullable: false),
                        Info_Magic = c.Int(nullable: false),
                        Info_Defense = c.Int(nullable: false),
                        Info_Difficulty = c.Int(nullable: false),
                        Key = c.String(),
                        Lore = c.String(),
                        Name = c.String(nullable: false),
                        ParType = c.String(),
                        Passive_Description = c.String(),
                        Passive_Image_Full = c.String(),
                        Passive_Image_Group = c.String(),
                        Passive_Image_Sprite = c.String(),
                        Passive_Image_X = c.Int(nullable: false),
                        Passive_Image_Y = c.Int(nullable: false),
                        Passive_Image_W = c.Int(nullable: false),
                        Passive_Image_H = c.Int(nullable: false),
                        Passive_Name = c.String(),
                        Passive_SanitizedDescription = c.String(),
                        Stats_Armor = c.Double(nullable: false),
                        Stats_ArmorPerLevel = c.Double(nullable: false),
                        Stats_AttackDamage = c.Double(nullable: false),
                        Stats_AttackDamagePerLevel = c.Double(nullable: false),
                        Stats_AttackRange = c.Double(nullable: false),
                        Stats_AttackSpeedOffset = c.Double(nullable: false),
                        Stats_AttackSpeedPerLevel = c.Double(nullable: false),
                        Stats_Crit = c.Double(nullable: false),
                        Stats_CritPerLevel = c.Double(nullable: false),
                        Stats_HP = c.Double(nullable: false),
                        Stats_HPPerLevel = c.Double(nullable: false),
                        Stats_HPRegen = c.Double(nullable: false),
                        Stats_HPRegenPerLevel = c.Double(nullable: false),
                        Stats_MoveSpeed = c.Double(nullable: false),
                        Stats_MP = c.Double(nullable: false),
                        Stats_MPPerLevel = c.Double(nullable: false),
                        Stats_MPRegen = c.Double(nullable: false),
                        Stats_MPRegenPerLevel = c.Double(nullable: false),
                        Stats_SpellBlock = c.Double(nullable: false),
                        Stats_SpellBlockPerLevel = c.Double(nullable: false),
                        Tags_Value = c.String(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StaticChampionSpells",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        Cooldown_Value = c.String(),
                        CooldownBurn = c.String(),
                        Cost_Value = c.String(),
                        CostBurn = c.String(),
                        CostType = c.String(),
                        Description = c.String(),
                        Effect_Value = c.String(),
                        EffectBurn_Value = c.String(),
                        Image_Full = c.String(),
                        Image_Group = c.String(),
                        Image_Sprite = c.String(),
                        Image_X = c.Int(nullable: false),
                        Image_Y = c.Int(nullable: false),
                        Image_W = c.Int(nullable: false),
                        Image_H = c.Int(nullable: false),
                        Key = c.String(),
                        LevelTip_Effect_Value = c.String(),
                        LevelTip_Label_Value = c.String(),
                        MaxRank = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Range_Value = c.String(),
                        RangeBurn = c.String(),
                        Resource = c.String(),
                        SanitizedDescription = c.String(),
                        SanitizedTooltip = c.String(),
                        Tooltip = c.String(),
                        StaticChampion_Id = c.Int(),
                    })
                .PrimaryKey(t => t.DatabaseId)
                .ForeignKey("dbo.StaticChampions", t => t.StaticChampion_Id)
                .Index(t => t.StaticChampion_Id);
            
            CreateTable(
                "dbo.AltImages",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        Full = c.String(),
                        Group = c.String(),
                        Sprite = c.String(),
                        X = c.Int(nullable: false),
                        Y = c.Int(nullable: false),
                        W = c.Int(nullable: false),
                        H = c.Int(nullable: false),
                        StaticChampionSpell_DatabaseId = c.Long(),
                    })
                .PrimaryKey(t => t.DatabaseId)
                .ForeignKey("dbo.StaticChampionSpells", t => t.StaticChampionSpell_DatabaseId)
                .Index(t => t.StaticChampionSpell_DatabaseId);
            
            CreateTable(
                "dbo.StaticItems",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Colloq = c.String(),
                        ConsumeOnFull = c.Boolean(nullable: false),
                        Consumed = c.Boolean(nullable: false),
                        Depth = c.Int(nullable: false),
                        Effect_Value = c.String(),
                        From_Value = c.String(),
                        Gold_Base = c.Int(nullable: false),
                        Gold_Purchasable = c.Boolean(nullable: false),
                        Gold_Sell = c.Int(nullable: false),
                        Gold_Total = c.Int(nullable: false),
                        Group = c.String(),
                        HideFromAll = c.Boolean(nullable: false),
                        InStore = c.Boolean(nullable: false),
                        Into_Value = c.String(),
                        Maps_Value = c.String(),
                        PlainText = c.String(),
                        RequiredChampion = c.String(),
                        SpecialRecipe = c.Int(nullable: false),
                        Stacks = c.Int(nullable: false),
                        Stats_FlatArmorMod = c.Double(nullable: false),
                        Stats_FlatAttackSpeedMod = c.Double(nullable: false),
                        Stats_FlatBlockMod = c.Double(nullable: false),
                        Stats_FlatCritChanceMod = c.Double(nullable: false),
                        Stats_FlatCritDamageMod = c.Double(nullable: false),
                        Stats_FlatEXPBonus = c.Double(nullable: false),
                        Stats_FlatEnergyPoolMod = c.Double(nullable: false),
                        Stats_FlatEnergyRegenMod = c.Double(nullable: false),
                        Stats_FlatHPPoolMod = c.Double(nullable: false),
                        Stats_FlatHPRegenMod = c.Double(nullable: false),
                        Stats_FlatMPPoolMod = c.Double(nullable: false),
                        Stats_FlatMPRegenMod = c.Double(nullable: false),
                        Stats_FlatMagicDamageMod = c.Double(nullable: false),
                        Stats_FlatMovementSpeedMod = c.Double(nullable: false),
                        Stats_FlatPhysicalDamageMod = c.Double(nullable: false),
                        Stats_FlatSpellBlockMod = c.Double(nullable: false),
                        Stats_PercentArmorMod = c.Double(nullable: false),
                        Stats_PercentAttackSpeedMod = c.Double(nullable: false),
                        Stats_PercentBlockMod = c.Double(nullable: false),
                        Stats_PercentCritChanceMod = c.Double(nullable: false),
                        Stats_PercentCritDamageMod = c.Double(nullable: false),
                        Stats_PercentDodgeMod = c.Double(nullable: false),
                        Stats_PercentEXPBonus = c.Double(nullable: false),
                        Stats_PercentHPPoolMod = c.Double(nullable: false),
                        Stats_PercentHPRegenMod = c.Double(nullable: false),
                        Stats_PercentLifeStealMod = c.Double(nullable: false),
                        Stats_PercentMPPoolMod = c.Double(nullable: false),
                        Stats_PercentMPRegenMod = c.Double(nullable: false),
                        Stats_PercentMagicDamageMod = c.Double(nullable: false),
                        Stats_PercentMovementSpeedMod = c.Double(nullable: false),
                        Stats_PercentPhysicalDamageMod = c.Double(nullable: false),
                        Stats_PercentSpellBlockMod = c.Double(nullable: false),
                        Stats_PercentSpellVampMod = c.Double(nullable: false),
                        Description = c.String(),
                        Image_Full = c.String(),
                        Image_Group = c.String(),
                        Image_Sprite = c.String(),
                        Image_X = c.Int(nullable: false),
                        Image_Y = c.Int(nullable: false),
                        Image_W = c.Int(nullable: false),
                        Image_H = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        SanitizedDescription = c.String(),
                        Tags_Value = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StaticItemTrees",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        Header = c.String(),
                        Tags_Value = c.String(),
                    })
                .PrimaryKey(t => t.DatabaseId);
            
            CreateTable(
                "dbo.StaticMapDetails",
                c => new
                    {
                        MapId = c.Long(nullable: false),
                        Image_Full = c.String(),
                        Image_Group = c.String(),
                        Image_Sprite = c.String(),
                        Image_X = c.Int(nullable: false),
                        Image_Y = c.Int(nullable: false),
                        Image_W = c.Int(nullable: false),
                        Image_H = c.Int(nullable: false),
                        MapName = c.String(nullable: false),
                        UnpurchasableItemList_Value = c.String(),
                    })
                .PrimaryKey(t => t.MapId);
            
            CreateTable(
                "dbo.StaticMasteries",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Description_Value = c.String(),
                        Image_Full = c.String(),
                        Image_Group = c.String(),
                        Image_Sprite = c.String(),
                        Image_X = c.Int(nullable: false),
                        Image_Y = c.Int(nullable: false),
                        Image_W = c.Int(nullable: false),
                        Image_H = c.Int(nullable: false),
                        MasteryTree = c.String(),
                        Name = c.String(nullable: false),
                        Prereq = c.Int(nullable: false),
                        Ranks = c.Int(nullable: false),
                        SanitizedDescription_Value = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StaticMasteryTreeLists",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        StaticMasteryTree_DatabaseId = c.Long(),
                        StaticMasteryTree_DatabaseId1 = c.Long(),
                        StaticMasteryTree_DatabaseId2 = c.Long(),
                    })
                .PrimaryKey(t => t.DatabaseId)
                .ForeignKey("dbo.StaticMasteryTrees", t => t.StaticMasteryTree_DatabaseId)
                .ForeignKey("dbo.StaticMasteryTrees", t => t.StaticMasteryTree_DatabaseId1)
                .ForeignKey("dbo.StaticMasteryTrees", t => t.StaticMasteryTree_DatabaseId2)
                .Index(t => t.StaticMasteryTree_DatabaseId)
                .Index(t => t.StaticMasteryTree_DatabaseId1)
                .Index(t => t.StaticMasteryTree_DatabaseId2);
            
            CreateTable(
                "dbo.StaticMasteryTreeItems",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        MasteryId = c.Int(nullable: false),
                        Prereq = c.Int(nullable: false),
                        StaticMasteryTreeList_DatabaseId = c.Long(),
                    })
                .PrimaryKey(t => t.DatabaseId)
                .ForeignKey("dbo.StaticMasteryTreeLists", t => t.StaticMasteryTreeList_DatabaseId)
                .Index(t => t.StaticMasteryTreeList_DatabaseId);
            
            CreateTable(
                "dbo.StaticMasteryTrees",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.DatabaseId);
            
            CreateTable(
                "dbo.StaticRealms",
                c => new
                    {
                        DatabaseId = c.Long(nullable: false, identity: true),
                        Cdn = c.String(),
                        Css = c.String(),
                        Dd = c.String(),
                        L = c.String(),
                        Lg = c.String(),
                        N_Value = c.String(),
                        ProfileIconMax = c.Int(nullable: false),
                        Store = c.String(),
                        V = c.String(),
                    })
                .PrimaryKey(t => t.DatabaseId);
            
            CreateTable(
                "dbo.StaticRunes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Rune_IsRune = c.Boolean(nullable: false),
                        Rune_Tier = c.String(),
                        Rune_Type = c.String(),
                        Stats_FlatArmorModPerLevel = c.Double(nullable: false),
                        Stats_FlatArmorPenetrationMod = c.Double(nullable: false),
                        Stats_FlatArmorPenetrationModPerLevel = c.Double(nullable: false),
                        Stats_FlatCritChanceModPerLevel = c.Double(nullable: false),
                        Stats_FlatCritDamageModPerLevel = c.Double(nullable: false),
                        Stats_FlatDodgeMod = c.Double(nullable: false),
                        Stats_FlatDodgeModPerLevel = c.Double(nullable: false),
                        Stats_FlatEnergyModPerLevel = c.Double(nullable: false),
                        Stats_FlatEnergyRegenModPerLevel = c.Double(nullable: false),
                        Stats_FlatGoldPer10Mod = c.Double(nullable: false),
                        Stats_FlatHPModPerLevel = c.Double(nullable: false),
                        Stats_FlatHPRegenModPerLevel = c.Double(nullable: false),
                        Stats_FlatMPModPerLevel = c.Double(nullable: false),
                        Stats_FlatMPRegenModPerLevel = c.Double(nullable: false),
                        Stats_FlatMagicDamageModPerLevel = c.Double(nullable: false),
                        Stats_FlatMagicPenetrationMod = c.Double(nullable: false),
                        Stats_FlatMagicPenetrationModPerLevel = c.Double(nullable: false),
                        Stats_FlatMovementSpeedModPerLevel = c.Double(nullable: false),
                        Stats_FlatPhysicalDamageModPerLevel = c.Double(nullable: false),
                        Stats_FlatSpellBlockModPerLevel = c.Double(nullable: false),
                        Stats_FlatTimeDeadMod = c.Double(nullable: false),
                        Stats_FlatTimeDeadModPerLevel = c.Double(nullable: false),
                        Stats_PercentArmorPenetrationMod = c.Double(nullable: false),
                        Stats_PercentArmorPenetrationModPerLevel = c.Double(nullable: false),
                        Stats_PercentAttackSpeedModPerLevel = c.Double(nullable: false),
                        Stats_PercentCooldownMod = c.Double(nullable: false),
                        Stats_PercentCooldownModPerLevel = c.Double(nullable: false),
                        Stats_PercentMagicPenetrationMod = c.Double(nullable: false),
                        Stats_PercentMagicPenetrationModPerLevel = c.Double(nullable: false),
                        Stats_PercentMovementSpeedModPerLevel = c.Double(nullable: false),
                        Stats_PercentTimeDeadMod = c.Double(nullable: false),
                        Stats_PercentTimeDeadModPerLevel = c.Double(nullable: false),
                        Stats_FlatArmorMod = c.Double(nullable: false),
                        Stats_FlatAttackSpeedMod = c.Double(nullable: false),
                        Stats_FlatBlockMod = c.Double(nullable: false),
                        Stats_FlatCritChanceMod = c.Double(nullable: false),
                        Stats_FlatCritDamageMod = c.Double(nullable: false),
                        Stats_FlatEXPBonus = c.Double(nullable: false),
                        Stats_FlatEnergyPoolMod = c.Double(nullable: false),
                        Stats_FlatEnergyRegenMod = c.Double(nullable: false),
                        Stats_FlatHPPoolMod = c.Double(nullable: false),
                        Stats_FlatHPRegenMod = c.Double(nullable: false),
                        Stats_FlatMPPoolMod = c.Double(nullable: false),
                        Stats_FlatMPRegenMod = c.Double(nullable: false),
                        Stats_FlatMagicDamageMod = c.Double(nullable: false),
                        Stats_FlatMovementSpeedMod = c.Double(nullable: false),
                        Stats_FlatPhysicalDamageMod = c.Double(nullable: false),
                        Stats_FlatSpellBlockMod = c.Double(nullable: false),
                        Stats_PercentArmorMod = c.Double(nullable: false),
                        Stats_PercentAttackSpeedMod = c.Double(nullable: false),
                        Stats_PercentBlockMod = c.Double(nullable: false),
                        Stats_PercentCritChanceMod = c.Double(nullable: false),
                        Stats_PercentCritDamageMod = c.Double(nullable: false),
                        Stats_PercentDodgeMod = c.Double(nullable: false),
                        Stats_PercentEXPBonus = c.Double(nullable: false),
                        Stats_PercentHPPoolMod = c.Double(nullable: false),
                        Stats_PercentHPRegenMod = c.Double(nullable: false),
                        Stats_PercentLifeStealMod = c.Double(nullable: false),
                        Stats_PercentMPPoolMod = c.Double(nullable: false),
                        Stats_PercentMPRegenMod = c.Double(nullable: false),
                        Stats_PercentMagicDamageMod = c.Double(nullable: false),
                        Stats_PercentMovementSpeedMod = c.Double(nullable: false),
                        Stats_PercentPhysicalDamageMod = c.Double(nullable: false),
                        Stats_PercentSpellBlockMod = c.Double(nullable: false),
                        Stats_PercentSpellVampMod = c.Double(nullable: false),
                        Description = c.String(),
                        Image_Full = c.String(),
                        Image_Group = c.String(),
                        Image_Sprite = c.String(),
                        Image_X = c.Int(nullable: false),
                        Image_Y = c.Int(nullable: false),
                        Image_W = c.Int(nullable: false),
                        Image_H = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        SanitizedDescription = c.String(),
                        Tags_Value = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StaticSummonerSpells",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Modes_Value = c.String(),
                        SummonerLevel = c.Int(nullable: false),
                        Cooldown_Value = c.String(),
                        CooldownBurn = c.String(),
                        Cost_Value = c.String(),
                        CostBurn = c.String(),
                        CostType = c.String(),
                        Description = c.String(),
                        Effect_Value = c.String(),
                        EffectBurn_Value = c.String(),
                        Image_Full = c.String(),
                        Image_Group = c.String(),
                        Image_Sprite = c.String(),
                        Image_X = c.Int(nullable: false),
                        Image_Y = c.Int(nullable: false),
                        Image_W = c.Int(nullable: false),
                        Image_H = c.Int(nullable: false),
                        Key = c.String(),
                        LevelTip_Effect_Value = c.String(),
                        LevelTip_Label_Value = c.String(),
                        MaxRank = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Range_Value = c.String(),
                        RangeBurn = c.String(),
                        Resource = c.String(),
                        SanitizedDescription = c.String(),
                        SanitizedTooltip = c.String(),
                        Tooltip = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Summoners",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        AccountId = c.Long(nullable: false),
                        Name = c.String(),
                        ProfileIconId = c.Int(nullable: false),
                        RevisionDate = c.DateTime(nullable: false),
                        SummonerLevel = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.SpellVars", "StaticSummonerSpell_Id", "dbo.StaticSummonerSpells");
            DropForeignKey("dbo.StaticMasteryTreeLists", "StaticMasteryTree_DatabaseId2", "dbo.StaticMasteryTrees");
            DropForeignKey("dbo.StaticMasteryTreeLists", "StaticMasteryTree_DatabaseId1", "dbo.StaticMasteryTrees");
            DropForeignKey("dbo.StaticMasteryTreeLists", "StaticMasteryTree_DatabaseId", "dbo.StaticMasteryTrees");
            DropForeignKey("dbo.StaticMasteryTreeItems", "StaticMasteryTreeList_DatabaseId", "dbo.StaticMasteryTreeLists");
            DropForeignKey("dbo.StaticChampionSpells", "StaticChampion_Id", "dbo.StaticChampions");
            DropForeignKey("dbo.SpellVars", "StaticChampionSpell_DatabaseId", "dbo.StaticChampionSpells");
            DropForeignKey("dbo.AltImages", "StaticChampionSpell_DatabaseId", "dbo.StaticChampionSpells");
            DropForeignKey("dbo.Skins", "StaticChampion_Id", "dbo.StaticChampions");
            DropForeignKey("dbo.Recommendeds", "StaticChampion_Id", "dbo.StaticChampions");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Blocks", "Recommended_DatabaseId", "dbo.Recommendeds");
            DropForeignKey("dbo.MatchFrames", "MatchTimeline_DatabaseId", "dbo.MatchTimelines");
            DropForeignKey("dbo.MatchParticipantFrames", "MatchFrame_DatabaseId", "dbo.MatchFrames");
            DropForeignKey("dbo.MatchEvents", "MatchFrame_DatabaseId", "dbo.MatchFrames");
            DropForeignKey("dbo.MatchTeams", "Match_GameId", "dbo.Matches");
            DropForeignKey("dbo.BannedChampions", "MatchTeam_DatabaseId", "dbo.MatchTeams");
            DropForeignKey("dbo.MatchParticipants", "Match_GameId", "dbo.Matches");
            DropForeignKey("dbo.Runes", "MatchParticipant_DatabaseId", "dbo.MatchParticipants");
            DropForeignKey("dbo.Masteries", "MatchParticipant_DatabaseId", "dbo.MatchParticipants");
            DropForeignKey("dbo.MatchParticipantIdentities", "Match_GameId", "dbo.Matches");
            DropForeignKey("dbo.LeagueItems", "LeagueList_LeagueId", "dbo.LeagueLists");
            DropForeignKey("dbo.BlockItems", "Block_DatabaseId", "dbo.Blocks");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.StaticMasteryTreeItems", new[] { "StaticMasteryTreeList_DatabaseId" });
            DropIndex("dbo.StaticMasteryTreeLists", new[] { "StaticMasteryTree_DatabaseId2" });
            DropIndex("dbo.StaticMasteryTreeLists", new[] { "StaticMasteryTree_DatabaseId1" });
            DropIndex("dbo.StaticMasteryTreeLists", new[] { "StaticMasteryTree_DatabaseId" });
            DropIndex("dbo.AltImages", new[] { "StaticChampionSpell_DatabaseId" });
            DropIndex("dbo.StaticChampionSpells", new[] { "StaticChampion_Id" });
            DropIndex("dbo.SpellVars", new[] { "StaticSummonerSpell_Id" });
            DropIndex("dbo.SpellVars", new[] { "StaticChampionSpell_DatabaseId" });
            DropIndex("dbo.Skins", new[] { "StaticChampion_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Recommendeds", new[] { "StaticChampion_Id" });
            DropIndex("dbo.MatchFrames", new[] { "MatchTimeline_DatabaseId" });
            DropIndex("dbo.MatchParticipantFrames", new[] { "MatchFrame_DatabaseId" });
            DropIndex("dbo.MatchEvents", new[] { "MatchFrame_DatabaseId" });
            DropIndex("dbo.MatchTeams", new[] { "Match_GameId" });
            DropIndex("dbo.Runes", new[] { "MatchParticipant_DatabaseId" });
            DropIndex("dbo.Masteries", new[] { "MatchParticipant_DatabaseId" });
            DropIndex("dbo.MatchParticipants", new[] { "Match_GameId" });
            DropIndex("dbo.MatchParticipantIdentities", new[] { "Match_GameId" });
            DropIndex("dbo.LeagueItems", new[] { "LeagueList_LeagueId" });
            DropIndex("dbo.Blocks", new[] { "Recommended_DatabaseId" });
            DropIndex("dbo.BlockItems", new[] { "Block_DatabaseId" });
            DropIndex("dbo.BannedChampions", new[] { "MatchTeam_DatabaseId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Summoners");
            DropTable("dbo.StaticSummonerSpells");
            DropTable("dbo.StaticRunes");
            DropTable("dbo.StaticRealms");
            DropTable("dbo.StaticMasteryTrees");
            DropTable("dbo.StaticMasteryTreeItems");
            DropTable("dbo.StaticMasteryTreeLists");
            DropTable("dbo.StaticMasteries");
            DropTable("dbo.StaticMapDetails");
            DropTable("dbo.StaticItemTrees");
            DropTable("dbo.StaticItems");
            DropTable("dbo.AltImages");
            DropTable("dbo.StaticChampionSpells");
            DropTable("dbo.StaticChampions");
            DropTable("dbo.SpellVars");
            DropTable("dbo.Skins");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Recommendeds");
            DropTable("dbo.Players");
            DropTable("dbo.MatchFrames");
            DropTable("dbo.MatchTimelines");
            DropTable("dbo.MatchReferences");
            DropTable("dbo.MatchParticipantFrames");
            DropTable("dbo.MatchEvents");
            DropTable("dbo.MatchTeams");
            DropTable("dbo.Runes");
            DropTable("dbo.Masteries");
            DropTable("dbo.MatchParticipants");
            DropTable("dbo.MatchParticipantIdentities");
            DropTable("dbo.Matches");
            DropTable("dbo.LeagueLists");
            DropTable("dbo.LeagueItems");
            DropTable("dbo.Groups");
            DropTable("dbo.Champions");
            DropTable("dbo.Blocks");
            DropTable("dbo.BlockItems");
            DropTable("dbo.BannedChampions");
        }
    }
}
