using AutoServiceApp.model;
using AutoServiceApp.ViewModel;
using CheckStringLibrary;
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

namespace AutoServiceApp.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        Core db=new Core();


        public RegPage()
        {
            InitializeComponent();

          
        }
        private void Reg_Button_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass1 = passBox_1.Password.Trim();
            string pass2 = passBox_2.Password.Trim();
            string email = textBoxEmail.Text.Trim().ToLower();

            if (StringCheckClass.CorrectLogin(login) ==false)
            {
                textBoxLogin.ToolTip = "Длина логина меньше 5 символов или есть недопустимые символы";
                textBoxLogin.Background = Brushes.Red;
            }
            else if(StringCheckClass.CorrectLogin(login) == true)
            {
                textBoxLogin.ToolTip = null;
                textBoxLogin.Background = Brushes.Transparent;
            }
            if (StringCheckClass.CorrectPassword(pass1) ==false)
            {
                passBox_1.ToolTip = "Пароль должен иметь цифры и буквы всех регистров ";
                passBox_1.Background = Brushes.Red;
            }
            else if(StringCheckClass.CorrectPassword(pass1) == true)
            {
                passBox_1.ToolTip = null;
                passBox_1.Background = Brushes.Transparent;
            }
            if (StringCheckClass.SamePassword(pass2,pass1) == false)
            {
                passBox_2.ToolTip = "Пароли не совпадают";
                passBox_2.Background = Brushes.Red;
            }
            else if(StringCheckClass.SamePassword(pass2, pass1) == true)
            {
                passBox_2.ToolTip = null;
                passBox_2.Background = Brushes.Transparent;
            }
            if (StringCheckClass.CorrectMail(email) == false)
            {
                textBoxEmail.ToolTip = "Это поле введено не корректно!";
                textBoxEmail.Background = Brushes.Red;
            }
            else if(StringCheckClass.CorrectMail(email) == true)
            {
                textBoxEmail.ToolTip = null;
                textBoxEmail.Background = Brushes.Transparent;

            }
            ///если все условия создания аккаунта выдают результат true, вызывается функция вносящая информацию в бд и выдающая соотвутствующее уведомление
            if (StringCheckClass.CorrectLogin(login) == true && StringCheckClass.CorrectPassword(pass1) == true && StringCheckClass.SamePassword(pass2, pass1) == true && StringCheckClass.CorrectMail(email) == true)
            {
                if (UsersViewModel.RegUser(email,login, pass1) ==true)
                {
                    CreateAccButton.Content = "успешная регистрация";
                    ///MessageBox.Show("Успешная регистрация");
                    
                }
                else
                {
                    CreateAccButton.Content = "не успешная регистрация";
                    ///MessageBox.Show("Что-то пошло не так");
                }
            }
        }
    }
}
