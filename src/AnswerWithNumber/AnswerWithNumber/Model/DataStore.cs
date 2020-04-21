using System.Collections.Generic;

namespace AnswerWithNumber.Model
{
  public class DataStore
  {
    public static List<Level> GetLevels()
    {
      return new List<Level>
      {
        new Level
        {
          Question = "Was ist die Antwort auf Alles?",
          Answer = 42
        },
        new Level
        {
          Question = "Welche ist die Zahl der Illuminaten?",
          Answer = 23
        },
        new Level
        {
          Question = "Wie weit ist der halbe Weg zur Hölle?",
          Answer = 333
        },
        new Level
        {
          Question = "Welche Zahl ist die beste Zahl, nach Theorie von Dr. Dr. Sheldon Lee Cooper?",
          Answer = 73
        }
      };
    }
  }
}