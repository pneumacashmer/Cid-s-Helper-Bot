using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Text.Json;
class Character
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string imageURL { get; set; }
}
public class AddRoles : BaseCommandModule
{
    [Command("wings")]
    public async Task Wings(CommandContext ctx)
    {
        if (CidBot.commandsRecieved >= 10)
        {
            await TooManyCommands(ctx);
            return;
        }
        CidBot.commandsRecieved++;
        var member = ctx.Member;
        CheckName(ctx);
        string userName = ctx.Member.Username;
        var json = string.Empty;

        using (var fs = File.OpenRead("names.json"))
        using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            json = sr.ReadToEnd();

        NamesJson namesJson = JsonConvert.DeserializeObject<NamesJson>(json);
        switch (userName)
        {
            case "Nat":
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(876947832442060841)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(856336398612168724)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(925239976592039956)).ConfigureAwait(false);
                await member.ModifyAsync(x =>
                {
                    x.Nickname = namesJson.Angel;
                });
                break;
            case "Mitslett":
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(877013330852741141)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(794049480021901342)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(924708958235684886)).ConfigureAwait(false);
                await member.ModifyAsync(x =>
                {
                    x.Nickname = namesJson.Mitsu;
                });
                break;
            case "Ninjalex":
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(876972512385314847)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(631902834215878658)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(925247043251871774)).ConfigureAwait(false);
                await member.ModifyAsync(x =>
                {
                    x.Nickname = namesJson.Tsu;
                });
                break;
            case "CheshireKitten":
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(862156087339909132)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(890831046642393088)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(924528250393333831)).ConfigureAwait(false);
                await member.ModifyAsync(x =>
                {
                    x.Nickname = namesJson.Kirra;
                });
                break;
            case "WishMaker":
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(883135201163763773)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(856335145313501225)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(876947491197693962)).ConfigureAwait(false);
                await member.ModifyAsync(x =>
                {
                    x.Nickname = namesJson.Psyshock;
                });
                break;
            case "RobynAmethyst":
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(884944036551618580)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(764926243975069727)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(877383402779717642)).ConfigureAwait(false);
                await member.ModifyAsync(x =>
                {
                    x.Nickname = namesJson.Taiyo;
                });
                break;
        }

        await ctx.Channel.SendMessageAsync("So you wanted to join those Magius weirdos? Strange").ConfigureAwait(false);
    }

    [Command("rg")]
    public async Task RG(CommandContext ctx)
    {
        RadiantGarden(ctx);
    }

    [Command("radiant")]
    public async Task RadiantGarden(CommandContext ctx)
    {
        if (CidBot.commandsRecieved >= 10)
        {
            await TooManyCommands(ctx);
            return;
        }
        CidBot.commandsRecieved++;
        var member = ctx.Member;
        CheckName(ctx);
        string userName = ctx.Member.Username;
        var json = string.Empty;

        using (var fs = File.OpenRead("names.json"))
        using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            json = sr.ReadToEnd();

        NamesJson namesJson = JsonConvert.DeserializeObject<NamesJson>(json);
        switch (userName)
        {
            case "Nat":
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(876947832442060841)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(856336398612168724)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(925239976592039956)).ConfigureAwait(false);
                await member.ModifyAsync(x =>
                {
                    x.Nickname = namesJson.Stella;
                });
                break;
            case "Mitslett":
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(877013330852741141)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(794049480021901342)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(924708958235684886)).ConfigureAwait(false);
                await member.ModifyAsync(x =>
                {
                    x.Nickname = namesJson.Scarlett;
                });
                break;
            case "Ninjalex":
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(876972512385314847)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(631902834215878658)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(925247043251871774)).ConfigureAwait(false);
                await member.ModifyAsync(x =>
                {
                    x.Nickname = namesJson.Hiro;
                });
                break;
            case "CheshireKitten":
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(862156087339909132)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(890831046642393088)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(924528250393333831)).ConfigureAwait(false);
                await member.ModifyAsync(x =>
                {
                    x.Nickname = namesJson.Duana;
                });
                break;
            case "WishMaker":
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(883135201163763773)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(856335145313501225)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(876947491197693962)).ConfigureAwait(false);
                await member.ModifyAsync(x =>
                {
                    x.Nickname = namesJson.Teri;
                });
                break;
            case "RobynAmethyst":
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(884944036551618580)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(764926243975069727)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(877383402779717642)).ConfigureAwait(false);
                await member.ModifyAsync(x =>
                {
                    x.Nickname = namesJson.Vast;
                });
                break;
        }

        await ctx.Channel.SendMessageAsync("Welcome Back, was wonderin how long it'd take you to return").ConfigureAwait(false);
    }

    [Command("org")]
    public async Task Organization(CommandContext ctx)
    {
        if (CidBot.commandsRecieved >= 10)
        {
            await TooManyCommands(ctx);
            return;
        }
        CidBot.commandsRecieved++;
        var member = ctx.Member;
        CheckName(ctx);
        string userName = ctx.Member.Username;

        var json = string.Empty;

        using (var fs = File.OpenRead("names.json"))
        using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            json = sr.ReadToEnd();

        NamesJson namesJson = JsonConvert.DeserializeObject<NamesJson>(json);
        switch (userName)
        {
            case "Nat":
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(876947832442060841)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(856336398612168724)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(925239976592039956)).ConfigureAwait(false);
                await member.ModifyAsync(x =>
                {
                    x.Nickname = namesJson.Lily;
                });
                break;
            case "Mitslett":
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(877013330852741141)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(794049480021901342)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(924708958235684886)).ConfigureAwait(false);
                await member.ModifyAsync(x =>
                {
                    x.Nickname = namesJson.Kistrex;
                });
                break;
            case "Ninjalex":
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(876972512385314847)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(631902834215878658)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(925247043251871774)).ConfigureAwait(false);
                await member.ModifyAsync(x =>
                {
                    x.Nickname = namesJson.Asa;
                });
                break;
            case "CheshireKitten":
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(862156087339909132)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(890831046642393088)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(924528250393333831)).ConfigureAwait(false);
                await member.ModifyAsync(x =>
                {
                    x.Nickname = namesJson.Xoronma;
                });
                break;
            case "WishMaker":
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(883135201163763773)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(856335145313501225)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(876947491197693962)).ConfigureAwait(false);
                await member.ModifyAsync(x =>
                {
                    x.Nickname = namesJson.RobotGirl;
                });
                break;
            case "RobynAmethyst":
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(884944036551618580)).ConfigureAwait(false);
                await ctx.Member.RevokeRoleAsync(ctx.Guild.GetRole(764926243975069727)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(877383402779717642)).ConfigureAwait(false);
                await member.ModifyAsync(x =>
                {
                    x.Nickname = namesJson.Xah;
                });
                break;
        }

        await ctx.Channel.SendMessageAsync("What do you fancy those black coats?  I could build ya armor that does more than what that group can do").ConfigureAwait(false);
    }

    public void CheckName(CommandContext ctx)
    {
        //Console.WriteLine("Started");
        if ((ctx.Member.Roles.Contains(ctx.Guild.GetRole(877013330852741141)) && ctx.Member.Roles.Contains(ctx.Guild.GetRole(924708958235684886)))
            || (ctx.Member.Roles.Contains(ctx.Guild.GetRole(876947832442060841)) && ctx.Member.Roles.Contains(ctx.Guild.GetRole(856336398612168724)))
            || (ctx.Member.Roles.Contains(ctx.Guild.GetRole(876972512385314847)) && ctx.Member.Roles.Contains(ctx.Guild.GetRole(631902834215878658)))
            || (ctx.Member.Roles.Contains(ctx.Guild.GetRole(862156087339909132)) && ctx.Member.Roles.Contains(ctx.Guild.GetRole(890831046642393088)))
            || (ctx.Member.Roles.Contains(ctx.Guild.GetRole(883135201163763773)) && ctx.Member.Roles.Contains(ctx.Guild.GetRole(856335145313501225)))
            || (ctx.Member.Roles.Contains(ctx.Guild.GetRole(884944036551618580)) && ctx.Member.Roles.Contains(ctx.Guild.GetRole(764926243975069727)))
            )
        {
            return;
        }
        var json = string.Empty;

        using (var fs = File.OpenRead("names.json"))
        using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            json = sr.ReadToEnd();

        Console.WriteLine(json);
        NamesJson namesJson = new NamesJson();
        try
        {
            namesJson = JsonConvert.DeserializeObject<NamesJson>(json);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed");
        }
        //var namesJson = JsonSerializer.Serialize<NamesJson>(json);
        //NamesJson namesJson = new NamesJson();
        Console.WriteLine(namesJson);

        if (ctx.Member.Roles.Contains(ctx.Guild.GetRole(876947832442060841)))
        {
            namesJson.Angel = ctx.Member.Nickname;
        }
        if (ctx.Member.Roles.Contains(ctx.Guild.GetRole(856336398612168724)))
        {
            namesJson.Stella = ctx.Member.Nickname;
        }
        if (ctx.Member.Roles.Contains(ctx.Guild.GetRole(925239976592039956)))
        {
            namesJson.Lily = ctx.Member.Nickname;
        }

        if (ctx.Member.Roles.Contains(ctx.Guild.GetRole(877013330852741141)))
        {
            namesJson.Mitsu = ctx.Member.Nickname;
        }
        if (ctx.Member.Roles.Contains(ctx.Guild.GetRole(794049480021901342)))
        {
            namesJson.Scarlett = ctx.Member.Nickname;
        }
        if (ctx.Member.Roles.Contains(ctx.Guild.GetRole(924708958235684886)))
        {
            namesJson.Kistrex = ctx.Member.Nickname;
        }

        if (ctx.Member.Roles.Contains(ctx.Guild.GetRole(862156087339909132)))
        {
            namesJson.Kirra = ctx.Member.Nickname;
        }
        if (ctx.Member.Roles.Contains(ctx.Guild.GetRole(890831046642393088)))
        {
            namesJson.Duana = ctx.Member.Nickname;
        }
        if (ctx.Member.Roles.Contains(ctx.Guild.GetRole(924528250393333831)))
        {
            namesJson.Xoronma = ctx.Member.Nickname;
        }

        if (ctx.Member.Roles.Contains(ctx.Guild.GetRole(876972512385314847)))
        {
            namesJson.Tsu = ctx.Member.Nickname;
        }
        if (ctx.Member.Roles.Contains(ctx.Guild.GetRole(631902834215878658)))
        {
            namesJson.Hiro = ctx.Member.Nickname;
        }
        if (ctx.Member.Roles.Contains(ctx.Guild.GetRole(925247043251871774)))
        {
            namesJson.Asa = ctx.Member.Nickname;
        }

        if (ctx.Member.Roles.Contains(ctx.Guild.GetRole(883135201163763773)))
        {
            namesJson.Psyshock = ctx.Member.Nickname;
        }
        if (ctx.Member.Roles.Contains(ctx.Guild.GetRole(856335145313501225)))
        {
            namesJson.Teri = ctx.Member.Nickname;
        }
        if (ctx.Member.Roles.Contains(ctx.Guild.GetRole(876947491197693962)))
        {
            namesJson.RobotGirl = ctx.Member.Nickname;
        }

        if (ctx.Member.Roles.Contains(ctx.Guild.GetRole(884944036551618580)))
        {
            namesJson.Taiyo = ctx.Member.Nickname;
        }
        if (ctx.Member.Roles.Contains(ctx.Guild.GetRole(764926243975069727)))
        {
            namesJson.Vast = ctx.Member.Nickname;
        }
        if (ctx.Member.Roles.Contains(ctx.Guild.GetRole(877383402779717642)))
        {
            namesJson.Xah = ctx.Member.Nickname;
        }
        var end = JsonConvert.SerializeObject(namesJson);
        File.WriteAllText("names.json", end);
        Console.WriteLine(end);
    }

    [Command("all")]
    public async Task AllRoles(CommandContext ctx)
    {
        if (CidBot.commandsRecieved >= 10)
        {
            await TooManyCommands(ctx);
            return;
        }
        CidBot.commandsRecieved++;
        string userName = ctx.Member.Username;

        switch (userName)
        {
            case "Nat":
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(876947832442060841)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(856336398612168724)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(925239976592039956)).ConfigureAwait(false);
                break;
            case "Mitslett":
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(877013330852741141)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(794049480021901342)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(924708958235684886)).ConfigureAwait(false);
                break;
            case "Ninjalex":
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(876972512385314847)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(631902834215878658)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(925247043251871774)).ConfigureAwait(false);
                break;
            case "CheshireKitten":
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(862156087339909132)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(890831046642393088)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(924528250393333831)).ConfigureAwait(false);
                break;
            case "WishMaker":
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(883135201163763773)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(856335145313501225)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(876947491197693962)).ConfigureAwait(false);
                break;
            case "RobynAmethyst":
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(884944036551618580)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(764926243975069727)).ConfigureAwait(false);
                await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(877383402779717642)).ConfigureAwait(false);
                break;
        }

        await ctx.Channel.SendMessageAsync("I gave ya all your roles, happy?").ConfigureAwait(false);
    }

    [Command("yell")]
    public async Task Yell(CommandContext ctx, [RemainingText] string name)
    {
        if (CidBot.commandsRecieved >= 10)
        {
            await TooManyCommands(ctx);
            return;
        }
        CidBot.commandsRecieved++;
        Random random = new Random();
        if (name == "Mikiri" || name == "mikiri")
        {
            name = "Scarlett";
        }
        if (name == "I")
        {
            await ctx.RespondAsync("I ain't fallin for yer tricks");
            return;
        }
        if ((name.Contains("N") || name.Contains("n")) &&
            (name.Contains("U") || name.Contains("u")) && (name.Contains("M") || name.Contains("m")) && (name.Contains("A") || name.Contains("a")))
        {
            name = ctx.User.Mention;
        }
        if (name == "Nemu")
        {
            await ctx.RespondAsync("She's the only Magius I can stand, why'd I yell at her?");
            return;
        }
        if (name == "Vanitas" || name == "Yuki")
        {
            await ctx.RespondAsync("Scarlett just what hellspawn did you bring here with your wish?");
            return;
        }
        if (name == "Vast")
        {
            await ctx.RespondAsync("Who the hell you callin' Dad?  I ain't your dad.");
            return;
        }
        if (random.Next(1, 10) == 1)
        {
            name = "Scarlett";
        }
        switch (random.Next(0, 3))
        {
            case 0:
                await ctx.RespondAsync($"The hell did {name} do?!");
                break;
            case 1:
                await ctx.RespondAsync($"I swear to Johnson if {name} killed some innocents, Hades is gonna have a new soul to torture");
                break;
            case 2:
                name = name.ToUpper();
                await ctx.RespondAsync($"{name}!!!!");
                break;
        }
    }

    [Command("cid")]
    public async Task Cid(CommandContext ctx)
    {
        if (CidBot.commandsRecieved >= 10)
        {
            await TooManyCommands(ctx);
            return;
        }
        CidBot.commandsRecieved++;
        if (ctx.Member.Roles.Contains(ctx.Guild.GetRole(863554072832638986)))
        {
            await ctx.RespondAsync("Ask when you learn how to spell my name right");
            return;
        }
        if (CidBot.TooSoon)
        {
            await ctx.RespondAsync("Go away, quit asking");
            return;
        }
        Random random = new Random();
        if (random.Next(1, 151) == 40)
        {
            await ctx.RespondAsync("Quit bugging me so much, I'm takin 15 gold as a fee");
            CidBot.TooSoon = true;
        }
        else if (random.Next(1, CidBot.randomMax) == 100)
        {
            await ctx.RespondAsync("Yeah sure, I'll give you 20 munny");
            CidBot.TooSoon = true;
            CidBot.randomMax += 30;
        }
        else
        {
            await ctx.RespondAsync("I ain't givin you munny, now go away");
            CidBot.TooSoon = true;
        }
        await Task.Delay(60000).ContinueWith(t => TooSoonFalse());
    }

    [Command("cis")]
    public async Task Cis(CommandContext ctx)
    {
        if (CidBot.commandsRecieved >= 10)
        {
            await TooManyCommands(ctx);
            return;
        }
        CidBot.commandsRecieved++;
        await ctx.RespondAsync("That ain't my name");
        await ctx.Member.GrantRoleAsync(ctx.Guild.GetRole(863554072832638986));
    }

    [Command("Mikiri")]
    public async void mikiri(CommandContext ctx)
    {
        if (CidBot.commandsRecieved >= 10)
        {
            await TooManyCommands(ctx);
            return;
        }
        CidBot.commandsRecieved++;
        if (!CidBot.MikiriFound)
        {
            await ctx.RespondAsync("Shes a good kid, wonder who her mysterious doners are though.  @Mikiri " + ctx.Member.Mention + " found this command, give them the prize");
            CidBot.MikiriFound = true;
        }
        else
        {
            await ctx.RespondAsync("Too late, this prize has already been claimed");
        }
    }

    public void TooSoonFalse()
    {
        CidBot.TooSoon = false;
    }
    [Command("rr")]
    public async Task MultiRoll(CommandContext ctx, int iterations, [RemainingText] string command)
    {
        string fullResult = "";
        for(int i = 0; i < iterations; i++)
        {
            fullResult += Rolling(ctx, command);
            fullResult += "\n";
        }
        await ctx.RespondAsync(fullResult).ConfigureAwait(false);
    }
    [Command("r")]
    public async Task SingleRoll(CommandContext ctx, [RemainingText] string command)
    {
        string respond = Rolling(ctx, command);
        await ctx.RespondAsync(respond).ConfigureAwait(false);
    }

    [Command("r")]
    public String Rolling(CommandContext ctx, [RemainingText] string command)
    {
        string result = $"{ctx.User.Mention}: ";
        int sum = 0;
        Random random = new Random();
        char[] fullCommand = command.ToCharArray();
        List<string> commands = new List<string>();
        string line = "";
        for (int i = 0; i < fullCommand.Length; i++)
        {
            char c = fullCommand[i];
            switch (c)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    if (line.Contains('0') || line.Contains('1') || line.Contains('2') || line.Contains('3') ||
                        line.Contains('4') || line.Contains('5') || line.Contains('6') || line.Contains('7') ||
                        line.Contains('8') || line.Contains('9') || line == "")
                    {
                        line = line + c;
                        if (i == fullCommand.Length - 1)
                        {
                            commands.Add(line);
                        }
                    }
                    else
                    {
                        commands.Add(line);
                        line = c.ToString();
                    }
                    break;
                case '+':
                case '-':
                case '*':
                case '/':
                case 'd':
                    commands.Add(line);
                    commands.Add(c.ToString());
                    line = "";
                    break;
                case 'k':
                    if(fullCommand[i + 1] == 'l' || fullCommand[i + 1] == 'h')
                    {
                        commands.Add(line);
                        line = "";
                        commands.Add(fullCommand[i + 1].ToString());
                        i++;
                    }
                    break;
                case ' ':
                    break;
            }
        }
        List<int> positions = new List<int>();
        List<string> batches = new List<string>();
        List<int> batchResults = new List<int>();
        for (int i = 0; i < commands.Count; i++)
        {
            if (commands[i] == "d")
            {
                positions.Add(i);
            }
            else if(commands[i] == "l")
            {
                Console.WriteLine("TEST");
                positions.Add(-1);
                positions.Add(Int32.Parse(commands[i + 1]));
            }
            else if (commands[i] == "h")
            {
                positions.Add(-2);
                positions.Add(Int32.Parse(commands[i + 1]));
            }
        }
        List<int> rolls = new List<int>();
        // 1 = disad, 2 = add, 3 = roll
        int previous = -1;
        for (int i = 0; i < positions.Count; i++)
        {
            bool disad = false;
            bool add = false;
            bool roll = false;
            if (positions[i] == -1)
                {
                    disad = true;
                }
            else if (positions[i] == -2)
                {
                    add = true;
                }
            else
                {
                    roll = true;
                }
            
            if(previous == 3 && roll)
            {
                int batchresult = 0;
                string batch = "(";
                for(int j = 0; j < rolls.Count; j++)
                {
                    if (j != 0)
                    {
                        batch += ", ";
                    }
                    batchresult += rolls[j];
                    batch += rolls[j];
                }
                batch += ")";
                batches.Add(batch);
                batchResults.Add(batchresult);
                previous = 0;
            }
            if (previous == 3 && disad)
            {
                int keep = positions[i + 1];
                List<int> goodRolls = new List<int>();
                List<int> badRolls = new List<int>();
                foreach (int j in rolls)
                {
                    if(goodRolls.Count < keep)
                    {
                        goodRolls.Add(j);
                    }
                    else
                    {
                        int biggerNum = 0;
                        for(int k = 0; k < goodRolls.Count; k++)
                        {
                            if(goodRolls[k] > biggerNum)
                            {
                                biggerNum = goodRolls[k];
                            }
                        }
                        if(j < biggerNum)
                        {
                            goodRolls.Remove(biggerNum);
                            goodRolls.Add(rolls[j]);
                            badRolls.Add(biggerNum);
                        }
                        else
                        {
                            badRolls.Add(j);
                        }
                    }    
                }
                int batchresult = 0;
                string batch = "(";
                for (int j = 0; j < rolls.Count; j++)
                {
                    if (j != 0)
                    {
                        batch += ", ";
                    }
                    if(badRolls.Contains(rolls[j]))
                    {
                        batch += "~~" + rolls[j] + "~~";
                    }
                    else
                    {
                        batch += rolls[j];
                        batchresult += rolls[j];
                    }
                    

                }
                batch += ")";
                batches.Add(batch);
                batchResults.Add(batchresult);
                i++;
                previous = 1;
                continue;
            }
            if (previous == 3 && add)
            {
                //Console.WriteLine("here");
                int keep = positions[i + 1];
                List<int> goodRolls = new List<int>();
                List<int> badRolls = new List<int>();
                foreach (int j in rolls)
                {
                    if (goodRolls.Count < keep)
                    {
                        goodRolls.Add(j);
                    }
                    else
                    {
                        int smallerNum = int.MaxValue;
                        for (int k = 0; k < goodRolls.Count; k++)
                        {
                            if (goodRolls[k] < smallerNum)
                            {
                                smallerNum = goodRolls[k];
                            }
                        }
                        if (j > smallerNum)
                        {
                            goodRolls.Remove(smallerNum);
                            goodRolls.Add(j);
                            badRolls.Add(smallerNum);
                        }
                        else
                        {
                            badRolls.Add(j);
                        }
                        
                    }
                }
                int batchresult = 0;
                string batch = "(";
                for (int j = 0; j < rolls.Count; j++)
                {
                    if (j != 0)
                    {
                        batch += ", ";
                    }
                    if (badRolls.Contains(rolls[j]))
                    {
                        batch += "~~" + rolls[j] + "~~";
                    }
                    else
                    {
                        batch += rolls[j];
                        batchresult += rolls[j];
                    }

                }
                batch += ")";
                batches.Add(batch);
                batchResults.Add(batchresult);
                i++;
                previous = 2;
                continue;
            }

            rolls.Clear();
            for (int j = 0; j < Int32.Parse(commands[positions[i] - 1]); j++)
            {
                /**/
                rolls.Add(random.Next(1, Int32.Parse(commands[positions[i] + 1]) + 1));
                //Console.WriteLine(rolls[j]);
                //
            }

            previous = 3;
            if (i == positions.Count - 1)
            {
                int batchresult = 0;
                string batch = "(";
                for (int j = 0; j < rolls.Count; j++)
                {
                    if (j != 0)
                    {
                        batch += ", ";
                    }
                        batch += rolls[j];
                        batchresult += rolls[j];


                }
                batch += ")";
                batches.Add(batch);
                batchResults.Add(batchresult);
            }

        }
        string[] arrayCommands = commands.ToArray();
        for (int i = 0; i < arrayCommands.Length; i++)
        {
            if (arrayCommands[i] == "d")
            {
                arrayCommands[i - 1] = "";
                arrayCommands[i] = batchResults.ElementAt(0).ToString();
                batchResults.RemoveAt(0);
                arrayCommands[i + 1] = "";
            }
        }
        List<string> mathCommands = new List<string>();
        foreach (string item in arrayCommands)
        {
            if (item != "")
            {
                mathCommands.Add(item);
            }
            Console.WriteLine(item);
        }
        int first = 0;
        string operation = "null";
        foreach (string item in mathCommands)
        {
            if(item == "l" || item == "h")
            {
                continue;
            }
            if (first == 0)
            {
                first = Int32.Parse(item);
            }
            else if (operation == "null")
            {
                operation = item;
            }
            else
            {
                first = Math(first, operation, Int32.Parse(item));
                operation = "null";
            }
        }
        sum = first;
        //[] batchArray = batches.ToArray();
        for(int i = 0; i < mathCommands.Count; i++)
        {
            if(mathCommands[i] == "h" || mathCommands[i] == "l")
            {
                i++;
                continue;
            }
            try
            {
                Int32.Parse(mathCommands[i]);
                result += batches.ElementAt(0);
                batches.RemoveAt(0);
            }
            catch (Exception e)
            {
                result += " " + mathCommands[i] + " ";
            }
        }
        foreach (string item in mathCommands)
        {

        }
        result += $" for a total of {sum}";
        return result;
        
    }

    private int Math(int num1, string command, int num2)
    {
        int result = 0;
        switch (command)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                result = num1 / num2;
                break;
        }
        return result;
    }
    [Command("help")]
    public static async Task Help()
    {

    }

    public async Task TooManyCommands(CommandContext ctx)
    {
        if (CidBot.commandsRecieved == 10)
        {
            await ctx.RespondAsync("Just shut up");
            CidBot.commandsRecieved++;
        }
    }

    private List<Character> characters = new List<Character>();

    [Command("Add")]
    public async Task Add(CommandContext ctx, string name, [RemainingText] string description)
    {
        SetupList();

        foreach (Character cha in characters)
        {
            if (name == cha.Name)
            {
                await ctx.RespondAsync("Character already added");
                return;
            }
        }
        Character c = new Character();
        c.Name = name;
        c.Description = description;
        characters.Add(c);

        string dataPoint = name + "; " + description + "~ ";
        using (StreamWriter sw = File.AppendText("data.txt"))
        {
            await sw.WriteLineAsync(dataPoint);
        }
        await ctx.RespondAsync("Added " + name);
    }

    [Command("Get")]
    public async Task Lookup(CommandContext ctx, string name)
    {
        SetupList();
        Character character = characters.Find(c => c.Name == name);
        if (character == null)
        {
            await ctx.RespondAsync("Character not found");
        }
        else
        {
            string readout = character.Name + ": " + character.Description + "\n";
            if (character.imageURL != "")
            {
                readout += character.imageURL;
            }
            await ctx.RespondAsync(readout);
        }
    }

    public void SetupList()
    {
        var LogFile = File.ReadAllLines("data.txt");
        List<string> rawData = new List<string>(LogFile);
        bool end = false;
        foreach (string line in rawData)
        {
            Character ch = new Character();
            string newname = "";
            string newdescription = "";
            string newURL = "";
            int location = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ';')
                {
                    location = i + 1;
                    break;
                }
                else
                {
                    newname += line[i];
                }
            }
            ch.Name = newname;
            foreach (Character chara in characters)
            {
                if (ch.Name == chara.Name)
                {
                    end = true;
                    break;
                }
            }
            if (end)
            {
                break;
            }
            for (int j = location; j < line.Length; j++)
            {
                if (line[j] == '~')
                {
                    location = j + 1;
                    break;
                }
                else
                {
                    newdescription += line[j];
                }
            }
            for (int k = location; k < line.Length; k++)
            {
                newURL += line[k];
            }
            Console.WriteLine(newname);
            ch.Description = newdescription;
            ch.imageURL = newURL;
            characters.Add(ch);
        }
    }
}