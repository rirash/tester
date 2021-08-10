namespace tester.Models
{
    public abstract class Test
    {
        private double[] resultsOfTest;                 //Результаты теста
        private string nameOfTest;                      //Путь к файлу с вопросами
        private string instruction;                     //Инструкция к тесту
        private string[] themes;                        //Полные названия тем тестирования
        private string[] tegs;                          //Теги по темам для тестирования                        


        public double[] ResultsOfTest
        {
            get => resultsOfTest;
            set => resultsOfTest = value;
        }

        public string NameOfTest
        {
            get => nameOfTest;
            set => nameOfTest = value;
        }

        public string Instruction
        {
            get => instruction;
            set => instruction = value;
        }

        public string[] Themes
        {
            get => themes;
            set => themes = value;
        }

        public string[] Tegs
        {
            get => tegs;
            set => tegs = value;
        }

        public Test(int _numbOfQuest, string _nameOfTest, string _instruction)
        {
            resultsOfTest = new double[_numbOfQuest];   //Хотя бы одна тема для проверки каких-либо знаний, но будет. Подробнее будет рассмотрено уже в классах тестов по типам.
            nameOfTest = _nameOfTest;
            instruction = _instruction;
            themes = new string[1];
            tegs = new string[1];
        }

        public abstract void preprocessing();
        public abstract void run_test();
        public abstract void postprocessing();
    }
}
