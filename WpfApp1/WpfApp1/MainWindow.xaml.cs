using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TextBox LoginEl;
        public TextBox EmailEl;
        public PasswordBox PasEl;
        public MainWindow()
        {
            InitializeComponent();
        }

        public static string ValidateText(string text, int minLen, int maxLen, string tooSmallText, string tooBigText, string goodText)
        {
            if (text.Length < minLen)
                return tooSmallText;
            if (text.Length > maxLen)
                return tooBigText;
            return goodText;
        }

        public static string ValidateEmail(string text, string goood, string bad)
        {
            Regex mailReg = new Regex(@".+@.+\..+");
            if (!mailReg.IsMatch(text))
                return bad;
            return goood;
        }

        public void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            i1.Content = ValidateText(t1.Text, 4, 35, "Слишком коротко", "Слишком длинно", "Идеально");

        }

        private void t2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void t2_PasswordChanged(object sender, RoutedEventArgs e)
        {
            i2.Content = ValidateText(t2.Password, 10, 100, "Слишком коротко", "Слишком длинно", "Идеально");
        }

        public void t3_TextChanged(object sender, TextChangedEventArgs e)
        {
            i3.Content = ValidateEmail(t3.Text, "Идеально", "Это не почта");
        }
    }
}
