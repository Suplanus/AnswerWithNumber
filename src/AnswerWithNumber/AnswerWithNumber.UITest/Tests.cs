using System;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace AnswerWithNumber.UITest
{
  [TestFixture(Platform.Android)]
  [TestFixture(Platform.iOS)]
  public class Tests
  {
    [SetUp]
    public void BeforeEachTest()
    {
      _app = AppInitializer.StartApp(_platform);
    }

    private IApp _app;
    private readonly Platform _platform;

    private static readonly Func<AppQuery, AppQuery> AnswerButton = c => c.Marked("AnswerButton");

    public Tests(Platform platform)
    {
      _platform = platform;
    }

    [Test]
    public void OpenRepl()
    {
      _app.Repl();
    }

    [Test]
    public void BindingTest()
    {
      for (int i = 0; i <= 9; i++)
      {
        string buttonName = $"Digit{i}Button";
        _app.Tap(buttonName);
      }

      Func<AppQuery, AppQuery> queryLabel = c => c.Marked("AnswerFromUserLabel").Text("0123456789");
      AppResult[] result = _app.Query(queryLabel);
      Assert.IsTrue(result.Any());
      _app.Screenshot("BindingTest");
    }

    [Test]
    public void StartupScreenIsDisplayed()
    {
      AppResult[] results = _app.WaitForElement(AnswerButton);
      Assert.IsTrue(results.Any());
      _app.Screenshot("StartingTest");
    }
  }
}