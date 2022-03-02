using System;

public class StartRunning
{
    static void Main(string[] args)
    {
        var bot = new CidBot();
        bot.MainAsync().GetAwaiter().GetResult();
    }
}
