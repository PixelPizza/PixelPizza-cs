using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace PixelPizza_cs
{
    class Program
    {
        private DiscordSocketClient _client;

        private string getConstant(string fieldName, string envName)
        {
            Type constantsType = Type.GetType("PixelPizza_cs.Constants");
            return constantsType != null ? constantsType.GetField(fieldName).GetValue(null).ToString() : Environment.GetEnvironmentVariable(envName);
        }

        static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();

        private void HookClientEvents()
        {
            _client.Log += Log;
            _client.JoinedGuild += JoinedGuild;
            _client.LeftGuild += LeftGuild;
            _client.UserJoined += UserJoined;
            _client.UserLeft += UserLeft;
            _client.GuildMemberUpdated += GuildMemberUpdated;
            _client.ReactionAdded += ReactionAdded;
            _client.ReactionRemoved += ReactionRemoved;
            _client.MessageReceived += MessageReceived;
        }

        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();
            HookClientEvents();

            await _client.LoginAsync(TokenType.Bot, getConstant("token", "BOT_TOKEN"));
            await _client.StartAsync();

            await Task.Delay(-1);
        }

        private Task Log(LogMessage message)
        {
            Console.WriteLine(message.ToString());
            return Task.CompletedTask;
        }

        private async Task JoinedGuild(SocketGuild guild)
        {

        }

        private async Task LeftGuild(SocketGuild guild)
        {

        }

        private async Task UserJoined(SocketGuildUser member)
        {

        }

        private async Task UserLeft(SocketGuildUser member)
        {

        }

        private async Task GuildMemberUpdated(SocketGuildUser oldMember, SocketGuildUser newMember)
        {

        }

        private async Task ReactionAdded(Cacheable<IUserMessage, ulong> message, ISocketMessageChannel channel, SocketReaction reaction)
        {

        }

        private async Task ReactionRemoved(Cacheable<IUserMessage, ulong> message, ISocketMessageChannel channel, SocketReaction reaction)
        {

        }

        private async Task MessageReceived(SocketMessage message)
        {

        }
    }
}
