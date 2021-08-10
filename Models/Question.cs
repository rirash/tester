using System;

namespace tester.Models
{
    public abstract class Question
    {
        private string txtOfQ;              //Сам вопрос
        private string[] possibleAnsw;      //Альтернативы к вопросу, если имеются
        private string userAnsw;            //Пользовательский ответ одной строкой
        private int numbOfQ;                //Номер вопроса в тестировании
        private int scoreOfAnsw;            //Итоговая оценка ответа пользователя
        private int typeOfQuest;          //Тип вопроса. К какому направлению он относится. Что проверяет...

        public string TxtOfQ
        {
            get => txtOfQ;
            set => txtOfQ = value;
        }
        public string[] PossibleAnsw
        {
            get => possibleAnsw;
            set => possibleAnsw = value;
        }
        public string UserAnsw
        {
            get => userAnsw;
            set => userAnsw = value;
        }
        public int NumbOfQ
        {
            get => numbOfQ;
            set => numbOfQ = value;
        }

        public int ScoreOfAnsw
        {
            get => scoreOfAnsw;
            set => scoreOfAnsw = value;
        }

        public int TypeOfQuest
        {
            get => typeOfQuest;
            set => typeOfQuest = value;
        }

        public Question(string _txtOfQ, string[] _possibleAnsw, int _numbOfQ, int _typeOfQuest)
        {
            txtOfQ = _txtOfQ;
            possibleAnsw = _possibleAnsw;
            userAnsw = "";
            numbOfQ = _numbOfQ;
            scoreOfAnsw = 0;
            typeOfQuest = _typeOfQuest;
        }

        private int gener_rand_number(int max_value)
        {
            Random rand = new Random();
            return rand.Next();
        }

        private bool double_number (int[] sequence, int idx, int double_val)
        {
            for(int i = 0; i < idx; i ++)
            {
                if(sequence[i] == double_val) return true;
            }

            return false;
        }

        
        public int[] mix_sequence(int max_value)                //Перемешенная последовательность чисел от 0 до *кол-во альтернатив*
        {
            int[] sequence = new int[max_value];

            sequence[0] = gener_rand_number(max_value);
            for(int i = 1; i < max_value; i++)
            {
                do
                {
                    sequence[i] = gener_rand_number(max_value);
                }
                while(!double_number(sequence, i, sequence[i]));
            }

            return sequence;
        }
             
        public void mix_possible()                              //Перемешивание альтернатив в вопросе... Где-то да нужно) Уже основывается на типе вопроса
        {
            string[] tempArrAlter = new string[PossibleAnsw.Length];
            PossibleAnsw.CopyTo(tempArrAlter, 0);               //Поскольку в С# семантика ссылок -- копируем наш массив альтернатив 

            int[] randIdx = mix_sequence(PossibleAnsw.Length);  //Перемешанная последовательность чисел от 0 до *количество альтернатив*

            for (int i = 0; i < PossibleAnsw.Length; i++)
            {
                PossibleAnsw[i] = tempArrAlter[randIdx[i]];
            }
        }
    }
}
