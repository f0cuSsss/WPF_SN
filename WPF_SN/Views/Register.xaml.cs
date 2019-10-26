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

namespace WPF_SN.Views
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        RegisterNext rn;
        public Register()
        {
            InitializeComponent();
            rn = new RegisterNext();
        }

        private void btnExitClick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnNextClick(object sender, RoutedEventArgs e)
        {
            this.Hide();
            rn.ShowDialog();
            this.Show();
        }
    }
}
