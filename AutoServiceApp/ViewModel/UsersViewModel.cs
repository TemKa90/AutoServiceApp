using AutoServiceApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceApp.ViewModel
{
    public class UsersViewModel
    {
        private static Core db = new Core();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool RegUser(string email, string login, string password) {
            Users newUser = new Users
            {
                email = email,
                login = login,
                password = password,
                idRole = 1
            };
            db.context.Users.Add(newUser);
            if (db.context.SaveChanges()>0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }
    }
}
