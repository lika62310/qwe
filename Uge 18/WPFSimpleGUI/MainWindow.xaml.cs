using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace WPFSimpleGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = tbLine1.Text;
            tbLine1.Text = tbLine2.Text;
            tbLine2.Text = tbLine3.Text;
            tbLine3.Text = tbLine4.Text;
            tbLine4.Text = text;
        }

        private void bScrollDown_Click(object sender, RoutedEventArgs e)
        {
            string text = tbLine4.Text;
            tbLine4.Text = tbLine3.Text;
            tbLine3.Text = tbLine2.Text;
            tbLine2.Text = tbLine1.Text;
            tbLine1.Text = text;
        }

        private void bClear_Click(object sender, RoutedEventArgs e)
        {
            tbLine1.Text = "";
            tbLine2.Text = "";
            tbLine3.Text = "";
            tbLine4.Text = "";
        }
    }
}