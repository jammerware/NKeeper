using Newtonsoft.Json;

namespace NKeeper.Models
{
    public class Card
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Rarity { get; set; }
        public string Type { get; set; }
        public int Cost { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public string Set { get; set; }
        public string Faction { get; set; }
        public string Artist { get; set; }
        public string Flavor { get; set; }

        public string[] Mechanics { get; set; }
        public int[] Dust { get; set; }

        [JsonProperty("collectible")]
        public bool IsCollectible { get; set; }
    }
}