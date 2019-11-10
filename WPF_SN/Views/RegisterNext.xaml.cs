using System;
using System.Windows;
using System.Windows.Controls;
using WPF_SN.Models;
using WPF_SN.ViewModels;

namespace WPF_SN.Views
{
    public partial class RegisterNext : UserControl
    {
        public RegisterNext()
        {
            InitializeComponent();
            DataContext = new RegisterNextViewModel();
        }

        private void btnExitClick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        //private void btnBackClick(object sender, RoutedEventArgs e)
        //{
        //    this.Hide();
        //}

        private void Password_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!Password.Password.Equals(String.Empty) && Password.Password.Equals(Password2.Password))
            {
                setPassword(Password2.Password);
            }
        }

        private void Password2_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!Password2.Password.Equals(String.Empty) && Password.Password.Equals(Password2.Password))
            {
                setPassword(Password2.Password);
            }
        }

        private void setPassword(String pass)
        {
            RegisterNextModel.getInstance().Password = pass;
        }
    }
}
