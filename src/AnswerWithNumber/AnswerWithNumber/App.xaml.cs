using AnswerWithNumber.Model;
using AnswerWithNumber.View;

namespace AnswerWithNumber
{
  public partial class App
  {
    public App()
    {
      InitializeComponent();

      var mainPage = new MainPage();
      MainPage = mainPage;
    }

    protected override void OnStart()
    {
      Log.Init();
    }

    protected override void OnSleep() {}

    protected override void OnResume() {}
  }
}