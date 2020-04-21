using Foundation;
using Lottie.Forms.iOS.Renderers;
using UIKit;
using Xamarin;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace AnswerWithNumber.iOS
{
  [Register("AppDelegate")]
  public class AppDelegate : FormsApplicationDelegate
  {
    public override bool FinishedLaunching(UIApplication app, NSDictionary options)
    {
#if ENABLE_TEST_CLOUD

// requires Xamarin Test Cloud Agent
      Calabash.Start();
#endif

      Forms.Init();
      AnimationViewRenderer.Init();

      LoadApplication(new App());

      return base.FinishedLaunching(app, options);
    }
  }
}