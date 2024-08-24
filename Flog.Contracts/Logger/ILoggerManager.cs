
namespace Flog.Contracts.Logger;
public interface ILoggerManager
{
    public void LogError(string message);
    
    public void LogWarn(string message);
    
    public void LogDebug(string message);

    public void LogInfo(string message);
}
