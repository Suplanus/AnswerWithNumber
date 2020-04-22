using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using PropertyChanged;

namespace AnswerWithNumber.Model
{
  [AddINotifyPropertyChangedInterface]
  public class Game
  {
    public ObservableCollection<Level> Levels { get; set; }
    public int CurrentLevelCount { get; set; }
    public string AnswerFromUser { get; set; }
    public GameState State { get; set; } = GameState.Playing;
    public Level CurrentLevel => Levels?[CurrentLevelCount];
    public bool CanAnswer => !string.IsNullOrWhiteSpace(AnswerFromUser) && State == GameState.Playing;
    private readonly Stopwatch _stopwatch;

    public Game()
    {
      Levels = new ObservableCollection<Level>(DataStore.GetLevels());
      _stopwatch = new Stopwatch();
      _stopwatch.Start();
    }

    public void Answer()
    {
      // Crash
      if (AnswerFromUser.Equals("1337"))
      {
        throw new StackOverflowException("Oh my god, a hacker!");
      }

      try
      {
        int answerNumber = Convert.ToInt32(AnswerFromUser);
        if (CurrentLevel.Answer.Equals(answerNumber))
        {
          // Answer: Correct
          if (CurrentLevel.Equals(Levels.Last()))
          {
            // Game: Finished
            State = GameState.Finished;
            string seconds = _stopwatch.Elapsed.Seconds.ToString();
            Log.Event("Highscore", "Finished", seconds);
          }
          else
          {
            // Next level
            CurrentLevelCount++;
          }
        }
        else
        {
          // Answer: Wrong
          State = GameState.Wrong;
          Log.Event("Difficulty", "Level", CurrentLevel.Question);
        }
      }
      catch (Exception exception)
      {
        // Error
        State = GameState.Error;
        Log.Exception(exception, "Answer", AnswerFromUser);
      }
      finally
      {
        AnswerFromUser = null;
      }
    }
  }
}