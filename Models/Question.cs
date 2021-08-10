namespace tester.Models
{
    public abstract class Question
    {
        private string txtOfQ;              //Сам вопрос
        private string[] possibleAnsw;      //Альтернативы к вопросу, если имеются
        private string userAnsw;            //Пользовательский ответ одной строкой
        private uint numbOfQ;               //Номер вопроса в тестировании

        public string TxtOfQ => txtOfQ;
        public string[] PosiibleAnsw
        {
            get => possibleAnsw;
            set => possibleAnsw = value;
        }
        public string UserAnsw
        {
            get => userAnsw;
            set => userAnsw = value;
        }
        public uint NumbOfQ => numbOfQ;

        public Question(string _txtOfQ, string[] _possibleAnsw, string _userAnsw, uint _numbOfQ) 
        {
            txtOfQ = _txtOfQ;
            possibleAnsw = _possibleAnsw;
            userAnsw = _userAnsw;
            numbOfQ = _numbOfQ;
        }

        public abstract void mix_possible();             //Перемешивание альтернатив в вопросе... Где-то да нужно)
    }
}
