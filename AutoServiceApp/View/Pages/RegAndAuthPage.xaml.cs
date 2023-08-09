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
    /// Логика взаимодействия для RegAndAuthPage.xaml
    /// </summary>
    public partial class RegAndAuthPage : Page
    {
        private RegPage regPage;
        private AuthPage authPage;
        public RegAndAuthPage()
        {
            InitializeComponent();
        }

        MainWindow mw = Application.Current.MainWindow as MainWindow;

        private void Reg_Button(object sender, RoutedEventArgs e)
        {
            if (regPage == null)
            {
                regPage = new RegPage();
            }
            mw.MainFrame.Content = regPage;
        }


        private void Auth_Button(object sender, RoutedEventArgs e)
        {
            if (authPage == null)
            {
                authPage = new AuthPage();
            }
            mw.MainFrame.Content = authPage;
        }
    }
}
