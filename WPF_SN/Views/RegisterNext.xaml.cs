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
using WPF_SN.ViewModels;

namespace WPF_SN.Views
{
    /// <summary>
    /// Interaction logic for RegisterNext.xaml
    /// </summary>
    public partial class RegisterNext : Window
    {
        public RegisterNext()
        {
            InitializeComponent();
            //this.DataContext = ViewModels.RegisterNextViewModel;
            DataContext = new RegisterNextViewModel();
        }

        private void btnExitClick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnBackClick(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
