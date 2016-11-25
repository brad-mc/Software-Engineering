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

namespace NapierBank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        char sms = 'S';
        char email = 'E';
        char tweet = 'T';
        char messageType;
        string message;
        string messageHeader;
        string body;
        public MainWindow()
        {
            InitializeComponent();
            CSV.readCSV();
        }

        private void btnSanitize_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSendMessage_Click(object sender, RoutedEventArgs e)
        {
            SendMessage sm = new SendMessage();
            sm.Show();
           // this.Hide();
        }

        private void btnTrendMentionSIR_Click(object sender, RoutedEventArgs e)
        {
            TrendingAndMentions tm = new TrendingAndMentions();
            tm.Show();
            //this.Hide();
        }

        private void btnFileRead_Click(object sender, RoutedEventArgs e)
        {
            FileRead fileread = new FileRead();
            fileread.Show();
        }

        private void btnViewMessages_Click(object sender, RoutedEventArgs e)
        {
            ViewMessages vm = new ViewMessages();
            vm.Show();
        }

        private void btnViewSIR_Click(object sender, RoutedEventArgs e)
        {
            SIRView sir = new SIRView();
            sir.Show();
        }
    }
}
