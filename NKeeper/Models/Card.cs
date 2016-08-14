using Newtonsoft.Json;

namespace NKeeper.Models
{
    public class Card
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public Race Race { get; set; }
        public Rarity Rarity { get; set; }
        public CardType Type { get; set; }
        public int Cost { get; set; }
        public int Attack { get; set; }
        public int Durability { get; set; }
        public int Health { get; set; }
        public PlayerClass PlayerClass { get; set; }
        public Set Set { get; set; }
        public Faction Faction { get; set; }
        public string Artist { get; set; }
        public string Flavor { get; set; }

        public string[] Mechanics { get; set; }
        public int[] Dust { get; set; }

        [JsonProperty("collectible")]
        public bool IsCollectible { get; set; }
    }
}