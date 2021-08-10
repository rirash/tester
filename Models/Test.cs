namespace tester.Models
{
    public abstract class Test
    {
        private string testType { get; set; }               //Тип теста. Еще в разработке))
        private bool availabilityOfImages { get; set; }     //Если картинки в тесте?

        public Test(string _testType, bool _availabilityOfImages)
        {
            testType = _testType;
            availabilityOfImages = _availabilityOfImages;
        }

        public abstract void preprocessing();
        public abstract void run_test();
        public abstract void postprocessing();
    }
}
