using System;
using System.IO;

namespace tester.Models
{
    public class OneRightAlternativeTest : Test
    {
        OneRightAlternativeQuestion[] questList;                    //Список вопросов
        private bool stopTest;                                      //Закончен ли тест?
        private bool errorTest;                                     //Ошибка теста
        private int idxOfShowQuestion;                              //Индекс выводимого на экран вопроса

        public bool StopTest
        {
            get => stopTest;
            set => stopTest = value;
        }

        public bool ErrorTest
        {
            get => errorTest;
            set => errorTest = value;
        }

        public int IdxOfShowQuestion
        {
            get => idxOfShowQuestion;
            set => idxOfShowQuestion = value;
        }

        public OneRightAlternativeTest(int _numbOfQuest, string _nameOfTest, string _instruction) : base(_numbOfQuest, _nameOfTest, _instruction)
        {
            stopTest = false;
            errorTest = false;
            idxOfShowQuestion = 0;
            questList = fillOutTheTestWithQuestion();
        }

        private void fillOutThemesAndTegs (string[] line)
        {
            Themes = new string[line.Length];
            Tegs = new string[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                string[] temp = line[i].Split('_');
                Themes[i] = temp[0];
                Tegs[i] = temp[1];
            }
        }

        private OneRightAlternativeQuestion[] fillOutTheTestWithQuestion() //Заполнение списка вопросов + перемешивание в них альтернатив
        {
            OneRightAlternativeQuestion[] result = new OneRightAlternativeQuestion[1];
            //место для исключения! поиск файла
            string path = AppDomain.CurrentDomain.BaseDirectory + @"/Tests/" + NameOfTest + ".txt";
            StreamReader sr = new(path);

            //место для исключения! ошибка записи тем и тегов
            //Запоминаем темы, на которые будет проведен тест и теги к ним (нужны для того, чтобы обозначить принадлежность альтернативы в вопросе к той или иной теме)
            fillOutThemesAndTegs(sr.ReadLine()!.Split('|')); // тема1_тег1|тема2_тег2|...

            //место для исключени! ошибка записи инструкции
            Instruction = sr.ReadLine()!;
           

            



            return result;
        }

        
        
        public override void preprocessing()
        {
            
        }

        public override void run_test()
        { 

        }

        public override void postprocessing()
        {

        }
    }
}
