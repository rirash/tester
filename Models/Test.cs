namespace tester.Models
{
    public abstract class Test
    {
        private string testType;              //Тип теста. Еще в разработке))
        private bool availabilityOfImages;    //Если картинки в тесте?

        public string TestType => testType;
        public bool AvailabilityOfImages => availabilityOfImages;

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
