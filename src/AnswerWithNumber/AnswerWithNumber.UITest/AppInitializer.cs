using Xamarin.UITest;

namespace AnswerWithNumber.UITest
{
  public class AppInitializer
  {
    public static IApp StartApp(Platform platform)
    {
      if (platform == Platform.Android)
      {
        return ConfigureApp.Android.StartApp();
      }
      return ConfigureApp.iOS
                         .EnableLocalScreenshots()
                         .StartApp();
    }
  }
}