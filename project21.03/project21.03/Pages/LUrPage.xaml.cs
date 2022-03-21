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
    /// Логика взаимодействия для LUrPage.xaml
    /// </summary>
    public partial class LUrPage : Page
    {
        public LUrPage()
        {
            InitializeComponent();
        }

        private void itogButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(kTextBox.Text, out double k) && double.TryParse(bTextBox.Text, out double b))
            {
                KvLUr.LUr(k, b, out string message);
                TextBox1.Text = message;
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = Window.GetWindow(this) as MainWindow;
            window.Frame.Navigate(new ButtonPage());
        }
    }
}
