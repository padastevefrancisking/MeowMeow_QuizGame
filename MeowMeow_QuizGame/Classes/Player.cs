using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeowMeow_QuizGame.Classes
{
    public class Player
    {
        public string Name;
        public int Score;

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }
    }
}
