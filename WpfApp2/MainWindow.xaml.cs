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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        public MainWindow()
        {
            InitializeComponent();


        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            L.Content = W.Height.ToString() + "x" + W.Width.ToString();
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            W.Height = rand.Next(50, 100) + 400;
            W.Width = rand.Next(50, 100) + 600;
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)rand.Next(1, 255), (byte)rand.Next(1, 255), (byte)rand.Next(1, 233)));
            W.Background = brush;
        }

        int length = 6;
        private void B4_Click(object sender, RoutedEventArgs e)
        {
            B1.Content = new string(Enumerable.Repeat(chars, length).Select(s => s[rand.Next(s.Length)]).ToArray());
            B2.Content = new string(Enumerable.Repeat(chars, length).Select(s => s[rand.Next(s.Length)]).ToArray());
            B3.Content = new string(Enumerable.Repeat(chars, length).Select(s => s[rand.Next(s.Length)]).ToArray());
            B4.Content = new string(Enumerable.Repeat(chars, length).Select(s => s[rand.Next(s.Length)]).ToArray());
            B5.Content = new string(Enumerable.Repeat(chars, length).Select(s => s[rand.Next(s.Length)]).ToArray());
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            switch (rand.Next(0, 4))
            {
                case 0:
                    B1.Visibility = Visibility.Collapsed;
                    break;
                case 1:
                    B2.Visibility = Visibility.Collapsed;
                    break;
                case 2:
                    B3.Visibility = Visibility.Collapsed;
                    break;
                case 3:
                    B4.Visibility = Visibility.Collapsed; 
                    break;

                default:
                    break;
            }
        }
    }
}
