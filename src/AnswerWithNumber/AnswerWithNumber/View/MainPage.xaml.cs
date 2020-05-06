using System.Linq;
using AnswerWithNumber.Extension;
using Xamarin.Forms;
using Xamarin.Forms.PancakeView;

namespace AnswerWithNumber.View
{
  public partial class MainPage
  {
    public MainPage()
    {
      InitializeComponent();
    }

    protected override async void OnAppearing()
    {
      base.OnAppearing();

      Color color1 = PancakeView.BackgroundGradientStops.First().Color;
      Color color2 = PancakeView.BackgroundGradientStops.Last().Color;

      while (true)
      {
        await PancakeView.ColorTo(color1, color2, c => PancakeView.BackgroundGradientStops.First().Color = c, 5000, Easing.Linear);
        await PancakeView.ColorTo(color2, color1, c => PancakeView.BackgroundGradientStops.Last().Color = c, 5000, Easing.Linear);  
        await PancakeView.ColorTo(color1, color2, c => PancakeView.BackgroundGradientStops.First().Color = c, 5000, Easing.Linear);
        await PancakeView.ColorTo(color2, color1, c => PancakeView.BackgroundGradientStops.Last().Color = c, 5000, Easing.Linear);  
      }
    }
  }
}