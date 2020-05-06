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

      // Stops not working in current PanCake version

      //Color color1 = PancakeView.BackgroundGradientStops.First().Color;
      //Color color2 = PancakeView.BackgroundGradientStops.Last().Color;
      Color color1 = PancakeView.BackgroundGradientStartColor;
      Color color2 = PancakeView.BackgroundGradientEndColor;
      uint animationDuration = 1000;

      while (true)
      {
        //await PancakeView.ColorTo(color1, color2, c => PancakeView.BackgroundGradientStops.First().Color = c, 5000, Easing.Linear);
        //await PancakeView.ColorTo(color2, color1, c => PancakeView.BackgroundGradientStops.Last().Color = c, 5000, Easing.Linear);  
        //await PancakeView.ColorTo(color1, color2, c => PancakeView.BackgroundGradientStops.First().Color = c, 5000, Easing.Linear);
        //await PancakeView.ColorTo(color2, color1, c => PancakeView.BackgroundGradientStops.Last().Color = c, 5000, Easing.Linear);  

        await PancakeView.ColorTo(color1, color2, c => PancakeView.BackgroundGradientStartColor = c, animationDuration, Easing.Linear);
        await PancakeView.ColorTo(color2, color1, c => PancakeView.BackgroundGradientEndColor = c, animationDuration, Easing.Linear);  
        await PancakeView.ColorTo(color2, color1, c => PancakeView.BackgroundGradientStartColor = c, animationDuration, Easing.Linear);
        await PancakeView.ColorTo(color1, color2, c => PancakeView.BackgroundGradientEndColor = c, animationDuration, Easing.Linear);  
      }
    }
  }
}