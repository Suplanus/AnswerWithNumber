using System;
using System.Globalization;
using AnswerWithNumber.Model;
using Xamarin.Forms;

namespace AnswerWithNumber.Converter
{
  public class GameStateToBoolConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (parameter != null &&
          value is GameState gameState)
      {
        switch (parameter.ToString().ToUpper())
        {
          case "PLAYING":
            if (gameState == GameState.Playing)
            {
              return true;
            }
            break;

          case "ERROR":
            if (gameState == GameState.Error)
            {
              return true;
            }
            break;

          case "WRONG":
            if (gameState == GameState.Wrong)
            {
              return true;
            }
            break;

          case "FINISHED":
            if (gameState == GameState.Finished)
            {
              return true;
            }
            break;

          case "RETRY":
            if (gameState == GameState.Error ||
                gameState == GameState.Finished ||
                gameState == GameState.Wrong)
            {
              return true;
            }
            break;
        }
      }
      return false;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return true;
    }
  }
}