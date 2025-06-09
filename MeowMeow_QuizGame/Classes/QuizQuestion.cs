using MeowMeow_QuizGame.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MeowMeow_QuizGame.Classes
{
    public abstract class QuizQuestion
    {
        public string QuizQuestionID;
        public string QuizQuestionText;
        public QuestionDifficulty QuestionDifficulty;
        public int Score => QuestionDifficulty switch
        {
            QuestionDifficulty.LEVEL_1 => 1,
            QuestionDifficulty.LEVEL_2 => 2,
            QuestionDifficulty.LEVEL_3 => 3,
            QuestionDifficulty.LEVEL_4 => 5,
            _ => 0
        };

        public QuizQuestion(string id, string text, QuestionDifficulty difficulty)
        {
            QuizQuestionID = id;
            QuizQuestionText = text;
            QuestionDifficulty = difficulty;
        }

        public abstract void DisplayQuestion();
        public abstract bool CheckAnswer(string userAnswer);
        public abstract void DisplayAnswer(string userAnswer);
        public virtual void AddScore(Player player, int score)
        {
            player.Score += score;
        }
    }
}
