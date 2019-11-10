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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_SN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Messanger : UserControl
    {
        public Messanger()
        {
            InitializeComponent();
            //this.ResizeMode = ResizeMode.CanResize;
            DataContext = new MessangerViewModel();
        }

        bool StateClosed = true;

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //DragMove();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            //System.Windows.Application.Current.Shutdown();
            //Close();
            Environment.Exit(0);
        }

        private void btnFull_Click(object sender, RoutedEventArgs e)
        {
            //WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
            //if (WindowState == WindowState.Maximized)
            //{
            //    mainGrid.MinWidth = 300;
            //    mainGrid.MaxWidth = 600;
            //    WindowState = WindowState.Normal;
            //}
            //else
            //{
            //    mainGrid.MinWidth = 500;
            //    mainGrid.MaxWidth = 1300;
            //    WindowState = WindowState.Maximized;
            //}
        }

        private void btnRollDown_Click(object sender, RoutedEventArgs e)
        {
            //WindowState = WindowState.Minimized;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //WPF_SN.ChatBot.ChatBotView cbv = new WPF_SN.ChatBotView();
            //cbv.ShowDialog();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            //if (ButtonCloseMenu.Visibility == Visibility.Visible)
            //{
            //    ButtonCloseMenu.Visibility = Visibility.Collapsed;
            //    ;
            //}
            //else
            //{
            //    ButtonCloseMenu.Visibility = Visibility.Visible;
            //    ButtonOpenMenu.Visibility = Visibility.Collapsed;
            //}

            //ButtonOpenMenu.Visibility = ButtonOpenMenu.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;



            if (StateClosed)
            {
                //menuGrid.Width = GridLength.Auto;
                Storyboard sb = this.FindResource("OpenMenu") as Storyboard;
                sb.Begin();
            }
            else
            {
                Storyboard sb = this.FindResource("CloseMenu") as Storyboard;
                sb.Begin();
            }

            StateClosed = !StateClosed;

        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //UserControl usc = null;
            //GridMain.Children.Clear();

            //switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            //{
            //    case "ItemHome":
            //        usc = new UserControlHome();
            //        GridMain.Children.Add(usc);
            //        break;
            //    case "ItemCreate":
            //        usc = new UserControlCreate();
            //        GridMain.Children.Add(usc);
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
