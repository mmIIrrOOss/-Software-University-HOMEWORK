﻿namespace P03_FootballBetting.Data.Models
{
    using Enums;
    using P03_FootballBetting.Models.Enums;
    using System.Collections.Generic;

    public class Team
    {
        public Team()
        {
            this.HomeGames = new HashSet<Game>();
            this.AwayGames = new HashSet<Game>();
            this.Players = new HashSet<Player>();
        }

        public int TeamId { get; set; }

        public string Name { get; set; }

        public string LogoUrl { get; set; }

        public Initials Initials { get; set; }

        public decimal Budget { get; set; }

        public int PrimaryKitColorId {   get; set; }

        public int SecondaryKitColorId { get; set; }

        public Color PrimaryKitColor { get; set; }

        public Color SecondaryKitColor { get; set; }

        public int TownId { get; set; }

        public Town Town { get; set; }

        public ICollection<Game> HomeGames { get; set; }

        public ICollection<Game> AwayGames { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
