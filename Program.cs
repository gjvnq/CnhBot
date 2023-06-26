using dotenv.net;
using Discord;
using Discord.WebSocket;

namespace com.github.gjvnq.cnhbot;

class Program
{
    private DiscordSocketClient _client = null!;

    public static Task Main(string[] args)
    {
        DotEnv.Load();
        return new Program().MainAsync();
    }

    public async Task MainAsync()
	{
        var envVars = DotEnv.Read();
        _client = new DiscordSocketClient();
        _client.Log += Log;

        await _client.LoginAsync(TokenType.Bot, envVars["CNHBOT__TOKEN"]);
        await _client.StartAsync();

        // Block this task until the program is closed.
        await Task.Delay(-1);
	}

    private Task Log(LogMessage msg) {
	Console.WriteLine(msg.ToString());
	return Task.CompletedTask;
}
}
