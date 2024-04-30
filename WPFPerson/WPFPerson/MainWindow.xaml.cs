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

namespace WPFPerson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller controller = new Controller();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            controller.AddPerson();
            DelPers.IsEnabled = true;
            Up.IsEnabled = true;
            Down.IsEnabled = true;
            tbFN.IsEnabled = true;
            tbLN.IsEnabled = true;
            tbAge.IsEnabled = true;
            tbTN.IsEnabled = true;
        }

        private void tbFN_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.CurrentPerson.FirstName = tbFN.Text;
        }

        private void tbLN_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.CurrentPerson.LastName = tbLN.Text;
        }

        private void tbAge_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.CurrentPerson.Age = int.Parse(tbAge.Text);
        }

        private void tbTN_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.CurrentPerson.TelephoneNo = tbTN.Text;
        }

        private void DelPers_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            controller.NextPerson();
        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            controller.PrevPerson();
        }
    }
}