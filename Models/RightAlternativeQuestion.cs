namespace tester.Models
{
    public class RightAlternativeQuestion : Question
    {
        private uint rightAlter;//Место верной альтернативы. Изначально, она всегда первая

        public uint RightAlter
        {
            get => rightAlter;
            set => rightAlter = value;
        }
        public RightAlternativeQuestion(string _txtOfQ, string[] _possibleAnsw, uint _numbOfQ) : base (_txtOfQ, _possibleAnsw, _numbOfQ)
        {
            rightAlter = 0; //Поскольку верная альтернатива изначально всегда первая 
        }

       

        override public void mix_possible()
        {
            string[] tempArrAlter = new string[PossibleAnsw.Length];
            PossibleAnsw.CopyTo(tempArrAlter, 0);

            uint[] randIdx = new uint[tempArrAlter.Length];

        }
    }
}
