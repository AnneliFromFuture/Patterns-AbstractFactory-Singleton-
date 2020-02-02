namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //пользователь зашел в программу
            PasswordManager.SetPassword("password");

            //в программе получили пароль пользователя
            string password = PasswordManager.GetPassword();

            //пользователь забыл пароль, и пароль сбросился до дефолтного - 1234
            PasswordManager.ResetPassword();

            password = PasswordManager.GetPassword();
        }
    }
}
