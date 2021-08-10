using System;

namespace tester.Models
{
    public class OneRightAlternativeQuestion : Question
    {
        private string rightAlter;                              //Место верной альтернативы. Изначально, она всегда первая

        public string RightAlter
        {
            get => rightAlter;
            set => rightAlter = value;
        }

        public OneRightAlternativeQuestion(string _txtOfQ, string[] _possibleAnsw, int _numbOfQ, int _typeOfQuest) : base (_txtOfQ, _possibleAnsw, _numbOfQ, _typeOfQuest)
        {
            rightAlter = _possibleAnsw[0];                      //Поскольку верная альтернатива изначально всегда первая 
        }

        public bool score_user_answer()                         //Пользователь уже дал ответ. Совпадает ли он с истинным?
        {
            if (String.Compare(UserAnsw, RightAlter, StringComparison.OrdinalIgnoreCase) == 0)
            {
                ScoreOfAnsw = 1;                                //Совпал, ответ верный
                return true;
            }
            else
            {
                ScoreOfAnsw = -1;                               //Не совпал, ответ неверный
                return false;
            }
        }



    }
}
