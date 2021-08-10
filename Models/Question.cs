namespace tester.Models
{
    public abstract class Question
    {
        private string txtOfQ;              //Сам вопрос
        private string[] possibleAnsw;      //Альтернативы к вопросу, если имеются
        private string userAnsw;            //Пользовательский ответ одной строкой
        private uint numbOfQ;               //Номер вопроса в тестировании

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
        public uint NumbOfQ
        {
            get => numbOfQ;
            set => numbOfQ = value;
        }

        public Question(string _txtOfQ, string[] _possibleAnsw, uint _numbOfQ)
        {
            txtOfQ = _txtOfQ;
            possibleAnsw = _possibleAnsw;
            userAnsw = "";
            numbOfQ = _numbOfQ;
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

        public int mix_sequence(ref int[] sequence, int max_value)
        {
            int zeroNumb = 0;
            
            sequence[0] = gener_rand_number(max_value);
            if(sequence[0] == 0) zeroNumb = 0;

            for(int i = 1; i < max_value; i++)
            {
                do
                {
                    sequence[i] = gener_rand_number(max_value);
                }
                while(!double_number(sequence, i, sequence[i]));
            }

        }

        public abstract void mix_possible();             //Перемешивание альтернатив в вопросе... Где-то да нужно)
    }
}
