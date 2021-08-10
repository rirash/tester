namespace tester.Models
{
    public class UserAccount
    {
        private string userLogin;       //Пользовательский логин
        private string userPassword;    //Пользовательский пароль

        public string UserLogin => userLogin;
        public string UserPassword => userPassword;

        public UserAccount(string _userLogin, string _userPassword)
        {
            userLogin = _userLogin;
            userPassword = _userPassword;
        }
    }
}
