using Discord;
using Discord.WebSocket;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Text;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace DiscordSample
{
    class Program
    {
        private DiscordSocketClient _client;

        public static void Main(string[] args)
            => new Program().MainAsync(args[0]).GetAwaiter().GetResult();


        public async Task MainAsync(string tokenFile)
        {
            // Set up the display mappings

            _client = new DiscordSocketClient();

            _client.Log += Log;

            var token = File.ReadAllText(tokenFile);

            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();

            _client.MessageReceived += _client_MessageReceived;
            _client.Ready += () =>
            {
                Console.WriteLine("Bot is connected!");
                return Task.CompletedTask;
            };

            // Block this task until the program is closed.
            await Task.Delay(-1);
        }

        private async Task _client_MessageReceived(SocketMessage message)
        {
            if(message.Author.IsBot)
            {
                return;
            }

            int count = await GetMountsForDakt();
            await message.Channel.SendMessageAsync($"Dakt has {count} mounts", false);
        }

        private async Task<int> GetMountsForDakt()
        {
            string characterUri = $"https://xivapi.com/character/19442264?data=MIMO";

            using (HttpClient client = new HttpClient())
            {
                Uri address = new Uri(characterUri);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                // List data response.
                HttpResponseMessage response = await client.GetAsync(address);
                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body.
                    string result = await response.Content.ReadAsStringAsync();
                    CharacterInfo info = JsonConvert.DeserializeObject<CharacterInfo>(result);
                    return info.Mounts.Count();
                }
                else
                {
                    throw new Exception($"Character id dakt not found - {response.StatusCode}, {response.ReasonPhrase}");
                }
            }
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}
