using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.EventArgs;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Threading.Tasks;

public class CidBot
{
    public DiscordClient Client { get; private set; }
    public CommandsNextExtension Command { get; private set; }

    public static bool TooSoon = false;

    public static bool MikiriFound = false;

    public static int randomMax = 301;

    public static int commandsRecieved = 0;

    public async Task MainAsync()
    {
        var json = string.Empty;

        using (var fs = File.OpenRead("config.json"))
        using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            json = sr.ReadToEnd();

        var configJson = JsonConvert.DeserializeObject<ConfigJson>(json);
        var config = new DiscordConfiguration
        {
            Token = configJson.Token,
            TokenType = TokenType.Bot,
            AutoReconnect = true,
        };

        Client = new DiscordClient(config);

        Client.Ready += OnClientReady;

        var commandsConfig = new CommandsNextConfiguration
        {
            StringPrefixes = new string[]
            {
                configJson.Prefix
            },
            EnableMentionPrefix = true,
            EnableDms = false,
            EnableDefaultHelp = false
        };

        Command = Client.UseCommandsNext(commandsConfig);

        Command.RegisterCommands<AddRoles>();

        await Client.ConnectAsync();
        await Task.Delay(60000).ContinueWith(t => ResetLimit());
        await Task.Delay(-1);
    }

    private Task OnClientReady(DiscordClient sender, ReadyEventArgs e)
    {
        return Task.CompletedTask;
    }

    private async Task ResetLimit()
    {
        commandsRecieved = 0;
        await Task.Delay(60000).ContinueWith(t => ResetLimit());
    }
}