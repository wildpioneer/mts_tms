using NLog;
using ValueOfObjects.Core;

namespace ValueOfObjects.Tests;

[SetUpFixture]
public class BaseSuite
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
    
    [OneTimeSetUp]
    public static void SuiteSetUp()
    {
        Logger.Info("NLog Config...");
        new NLogConfig().Config();
        //new NLogConfig().ColoredConfig();
    }
}