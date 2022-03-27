using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceApp
{
    class User
    {
        public int IdUser { get; set; }

        private string login, email, password;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public User() { }

        public User(string Login, string Email, string Password)
        {
            this.Login = Login;
            this.Email = Email;
            this.Password = Password;

        }


    }
}
