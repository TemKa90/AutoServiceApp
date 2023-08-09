using AutoServiceApp.View.Pages;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RegAndAuthPage regAndAuthPage;
        private RegPage regPage;
        private AuthPage authPage;

        public MainWindow()
        {
            InitializeComponent();
            if (regAndAuthPage == null)
            {
                regAndAuthPage = new RegAndAuthPage();
            }
            RegOrAuth.Content = regAndAuthPage;
        }

        //private void Reg_Button(object sender, RoutedEventArgs e)
        //{
        //    if (regPage == null)
        //    {
        //        regPage = new RegPage();
        //    }
        //    MainFrame.Content = regPage;
        //}

        //private void Auth_Button(object sender, RoutedEventArgs e)
        //{
        //    if (authPage == null)
        //    {
        //        authPage = new AuthPage();
        //    }
        //    MainFrame.Content = authPage;
        //}
    }
}
