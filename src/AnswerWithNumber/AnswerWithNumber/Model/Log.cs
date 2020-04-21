using System;
using System.Collections.Generic;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace AnswerWithNumber.Model
{
  public class Log
  {
    internal static void Init()
    {
      IAppSecrets appSecrets = new AppSecrets();
      AppCenter.Start($"ios={appSecrets.AppCenterIos};" +
                      $"android={appSecrets.AppCenterAndroid}",
                      typeof(Analytics), typeof(Crashes));
    }

    public static void Exception(Exception exception, string propertyName, string propertyValue)
    {
      var properties = new Dictionary<string, string>
      {
        { propertyName, propertyValue }
      };

      Crashes.TrackError(exception, properties);
    }

    public static void Event(string name, string propertyName, string propertyValue)
    {
      var properties = new Dictionary<string, string>
      {
        { propertyName, propertyValue }
      };

      Analytics.TrackEvent(name, properties);
    }
  }
}