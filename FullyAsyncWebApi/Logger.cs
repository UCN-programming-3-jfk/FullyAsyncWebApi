using System.Threading.Tasks;

namespace AsyncWebApi;

public class Logger
{

    public static async Task LogAsync(string logEntryTitle)
    {
        await Task.Delay(5000);
    }
}
