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

namespace Contract_Monthly_Claim_System
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

        private void PCBtn_Click(object sender, RoutedEventArgs e)
        {
           Programmr_Coordinator PC = new Programmr_Coordinator();
            this.Visibility = Visibility.Hidden;
            PC.Show();

        }

        private void LecturerBtn_Click(object sender, RoutedEventArgs e)
        {
            Lecturer lecturer = new Lecturer();
            this.Visibility = Visibility.Hidden;
            lecturer.Show();

        }

        private void AMBtn_Click(object sender, RoutedEventArgs e)
        {
            Programmr_Coordinator AM = new Programmr_Coordinator();
            this.Visibility = Visibility.Hidden;
            AM.Show();

        }
    }
}