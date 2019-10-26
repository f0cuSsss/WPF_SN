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
using System.Windows.Shapes;
using WPF_SN.Views;

namespace WPF_SN
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExitClick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnRegisterClick(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.ShowDialog();
        }
        // 

    }
}
