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
using WPF_SN.Models;
using WPF_SN.ViewModels;

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
            DataContext = new RegisterViewModel();
        }

        private void btnExitClick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        #region Singleton
        private static Register instance;
        public static Register getInstance()
        {
            if (instance == null)
                instance = new Register();
            return instance;
        }
        #endregion

        public void showForm()
        {
            this.Hide();
            rn.ShowDialog();
            this.Show();
        }
    }
}
