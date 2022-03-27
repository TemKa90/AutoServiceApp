using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutoServiceApp
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        ApplicationContext db;


        public RegPage()
        {
            InitializeComponent();

            db = new ApplicationContext();
        }
        private void Reg_Button_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass1 = passBox_1.Password.Trim();
            string pass2 = passBox_2.Password.Trim();
            string email = textBoxEmail.Text.Trim().ToLower();

            if (login.Length < 5)
            {
                textBoxLogin.ToolTip = "Логин должен состоять минимум из 5 символов";
                textBoxLogin.Background = Brushes.Red;
            }
            else
            {
                textBoxLogin.ToolTip = null;
                textBoxLogin.Background = Brushes.Transparent;
            }
            if (pass1.Length < 8)
            {
                passBox_1.ToolTip = "Пароль должен состоять минимум из 8 символов";
                passBox_1.Background = Brushes.Red;
            }
            else
            {
                passBox_1.ToolTip = null;
                passBox_1.Background = Brushes.Transparent;
            }
            if (pass1 != pass2)
            {
                passBox_2.ToolTip = "Пароли не совпадают";
                passBox_2.Background = Brushes.Red;
            }
            else
            {
                passBox_2.ToolTip = null;
                passBox_2.Background = Brushes.Transparent;
            }
            if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                textBoxEmail.ToolTip = "Это поле введено не корректно!";
                textBoxEmail.Background = Brushes.Red;
            }
            else
            {
                textBoxEmail.ToolTip = null;
                textBoxEmail.Background = Brushes.Transparent;

            }
            User user = new User(login, email, pass1);
            db.Users.Add(user);
            db.SaveChanges();
        }
    }
}
