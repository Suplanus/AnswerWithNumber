using System.Windows.Input;
using AnswerWithNumber.Model;
using PropertyChanged;
using Xamarin.Forms;

namespace AnswerWithNumber.ViewModel
{
  [AddINotifyPropertyChangedInterface]
  public class MainViewModel
  {
    public Game Game { get; private set; }
    public ICommand AnswerCommand { get; }
    public ICommand RetryCommand { get; }
    public ICommand DeleteCommand { get; }
    public ICommand AddNumberCommand { get; }

    public MainViewModel()
    {
      Game = new Game();
      AnswerCommand = new Command(() => Game.Answer(), () => Game.CanAnswer);
      RetryCommand = new Command(() => Game = new Game());
      DeleteCommand = new Command(() => Game.AnswerFromUser = null);
      AddNumberCommand = new Command(answer => Game.AnswerFromUser += answer);
    }
  }
}