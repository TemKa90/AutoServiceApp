using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CheckStringLibrary
{
    public class StringCheckClass
    {
        /// <summary>
        /// проверка на правильность введенного для создания логина 
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public static bool CorrectLogin(string login)
        {
            var input = login;
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]"); ///проверка на спецсимволы
            if (login.Length < 5)
            {
                return false;
            }
            else if(hasSymbols.IsMatch(input))
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// проверка на корректноть создания пароля
        /// </summary>
        /// <param name="pass1"></param>
        /// <returns></returns>
        public static bool CorrectPassword(string pass1)
        {
            var input = pass1;
            var hasNumber = new Regex(@"[0-9]+"); ///проверка на наличие цифр
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]"); ///проверка на спецсимволы
            var hasLowerChar = new Regex(@"[a-z]+");///проверка на наличие символов нижнего регистра
            var hasUpperChar = new Regex(@"[A-Z]+");///проверка на наличие символов верхнего регистра
            if (pass1.Length < 8)
            {
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                return false;
            }
            else if (!hasLowerChar.IsMatch(input))
            {
                return false;
            }
            else if (!hasSymbols.IsMatch(input))
            {
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// проверка на сходство пароля с его повторением
        /// </summary>
        /// <param name="pass1"></param>
        /// <param name="pass2"></param>
        /// <returns></returns>
        public static bool SamePassword(string pass1, string pass2)
        {
            if (pass2 != pass1)
            {
                return false;
            }
            return true; 
        }
        /// <summary>
        /// проверка на корректный почтовый адресс
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool CorrectMail(string email)
        {
            var trueMail = new Regex(@"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)");///проверка на правильность почты
            if (!trueMail.IsMatch(email))
            {
                return false;
            }
            return true;
        }
    }
}
