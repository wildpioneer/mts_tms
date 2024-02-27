using NLog;

namespace ValueOfObjects.Tests;

[TestFixture]
public class NLogTest
{
    protected static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
    
    [Test]
    public void LevelsTest()
    {
        // Запись сообщения в лог
        Logger.Log(LogLevel.Info, "This is an informational message");
        
        Logger.Trace("Trace Level...");
        Logger.Debug("Debug Level...");
        Logger.Info("Info Level...");
        Logger.Warn("Warn Level...");
        Logger.Error("Error Level...");
        Logger.Fatal("Fatal Level...");
    }

    [Test]
    public void ExceptionLogTest()
    {
        try
        {
            throw new AssertionException("Какая-то ошибка...");
        }
        catch (Exception e)
        {
            Logger.Error(e, "Логируем ошибку...");
        }
    }
}