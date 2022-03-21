
using AlgorithmLibrary;
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

namespace project21._03.Pages
{
    /// <summary>
    /// Логика взаимодействия для KvUrPage.xaml
    /// </summary>
    public partial class KvUrPage : Page
    {
        public KvUrPage()
        {
            InitializeComponent();
        }

        private void itogButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(aTextBox.Text, out double a) && double.TryParse(bTextBox.Text, out double b) && double.TryParse(cTextBox.Text, out double c))
            {
                KvLUr.KvUr(a, b, c, out string message);
                TextBox.Text = message;
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = Window.GetWindow(this) as MainWindow;
            window.Frame.Navigate(new ButtonPage());
        }
    }
}
