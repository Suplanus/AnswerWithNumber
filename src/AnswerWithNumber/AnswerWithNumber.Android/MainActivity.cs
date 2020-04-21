using Android.App;
using Android.Content.PM;
using Android.OS;
using Lottie.Forms.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace AnswerWithNumber.Droid
{
  [Activity(
    Label = "AnswerWithNumber",
    Icon = "@mipmap/icon",
    Theme = "@style/MainTheme",
    MainLauncher = true,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
    ScreenOrientation = ScreenOrientation.FullSensor)]
  public class MainActivity : FormsAppCompatActivity
  {
    protected override void OnCreate(Bundle savedInstanceState)
    {
      TabLayoutResource = Resource.Layout.Tabbar;
      ToolbarResource = Resource.Layout.Toolbar;

      base.OnCreate(savedInstanceState);

      Forms.Init(this, savedInstanceState);
      AnimationViewRenderer.Init();

      LoadApplication(new App());
    }
  }
}