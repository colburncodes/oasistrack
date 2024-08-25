using OasisTrack.Core.Interfaces.Logger;

namespace OasisTrack.Infrastructure.Logger;

public class LoggerService : ILoggerService
{
    public void LogInformation(string message, params object[] args)
    {
        throw new NotImplementedException();
    }

    public void LogWarning(string message, params object[] args)
    {
        throw new NotImplementedException();
    }

    public void LogError(Exception ex, string message, params object[] args)
    {
        throw new NotImplementedException();
    }
}