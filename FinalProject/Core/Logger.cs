using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace FinalProject.Core
{
  public class Logger
  {
    
    private static readonly ILog _logger = LogManager.GetLogger(typeof(Logger));
  
    public void LogInfo(string message)
    {
      _logger.Info(message);
    }


    public void LogDebug(string message)
    {
      _logger.Debug(message);
    }


    public void LogWarn(string message)
    {
      _logger.Warn(message);
    }


    public void LogError(string message, Exception exception)
    {
      _logger.Error(message, exception);
    }

    public void LogFatal(string message, Exception exception)
    {
      _logger.Fatal(message, exception);
    }

    static Logger()
    {
      XmlConfigurator.Configure();
    }

  }
}
