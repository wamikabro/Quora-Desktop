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

namespace Quora_Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Maximize the window to the full screen
            WindowState = WindowState.Maximized;

            searchTextBox.GotFocus += SearchTextBox_GotFocus;
            searchTextBox.LostFocus += SearchTextBox_LostFocus;
        }

        private void SearchTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Search Quora")
            {
                textBox.Text = "";
            }
            textBox.Foreground = System.Windows.Media.Brushes.Black;
        }

        private void SearchTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Search Quora";
            }
            textBox.Foreground = System.Windows.Media.Brushes.Gray;
        }
    }
}
