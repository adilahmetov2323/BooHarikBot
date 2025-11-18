using BooHarikCreateBot;

class Program
{
    static async Task Main(string[] args)
    {
        string token = "";
        var bot = new CreateBot(token);
        await bot.StartAsync();
    }
}
