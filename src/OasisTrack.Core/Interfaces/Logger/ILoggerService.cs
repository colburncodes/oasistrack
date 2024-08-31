namespace OasisTrack.Core.Interfaces.Logger;

public interface ILoggerService
{
    void LogInformation(string message, params object[] args);
    void LogWarning(string message, params object[] args);
    void LogError(Exception ex, string message, params object[] args);
}