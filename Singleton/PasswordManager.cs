namespace Singleton
{
    public class PasswordManager
    {
        private static string _password;
        private const string _defaultPassword = "1234";
        private PasswordManager _manager;

        private PasswordManager()
        {
            if (_manager == null)
                _manager = new PasswordManager();
        }

        public static string GetPassword()
        {
            if (_password == null)
                _password = string.Empty;
            return _password;
        }

        public static void SetPassword(string password)
        {
            _password = password;
        }

        public static void ResetPassword()
        {
            _password = _defaultPassword;
        }
    }
}
