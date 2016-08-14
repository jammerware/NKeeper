using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NKeeper.Models;

namespace NKeeper
{
    public class NKeeperClient
    {
        // TODO: figure out how to tell HttpClient not to throw errors when redirected by 301
        //private const string API_ADDRESS = "https://api.hearthstonejson.com/v1/latest/enUS/cards.collectible.json";
        private const string API_ADDRESS = "http://api.hearthstonejson.com/v1/13921/enUS/cards.collectible.json";
        private const string CARD_IMAGE_URL_BASE = "http://wow.zamimg.com/images/hearthstone/cards/enus/original/";
        private const string CARD_IMAGE_GOLD_URL_BASE = "http://wow.zamimg.com/images/hearthstone/cards/enus/animated/";

        public IEnumerable<Card> Cards { get; private set; }

        // gotta get it async baby
        private NKeeperClient() { }

        public static async Task<NKeeperClient> CreateAsync()
        {
            var httpClient = new HttpClient();
            var data = await httpClient.GetStringAsync(API_ADDRESS);
            var cards = await Task.Factory.StartNew(() => 
            {
                var settings = new JsonSerializerSettings();
                settings.Converters.Add(new StringEnumConverter());

                return JsonConvert.DeserializeObject<IEnumerable<Card>>(data, settings);
            });

            return new NKeeperClient()
            {
                Cards = cards
            };
        }

        public string GetCardImageUrl(Card card, bool getGold = false)
        {
            if(!getGold)
            {
                return CARD_IMAGE_URL_BASE + $"{card.Id}.png";
            }
            return CARD_IMAGE_GOLD_URL_BASE + $"{card.Id}_premium.gif";
        }
    }
}