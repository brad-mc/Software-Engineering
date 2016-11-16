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
        }

        private void btnSanitize_Click(object sender, RoutedEventArgs e)
        {
            message = txtMessage.Text;
            messageHeader = message.Substring(0, 10);
            body = txtMessage.Text;
            messageType = messageHeader[0];

            switch (messageType)
            {
                case ('S'):
                    {
                        SMS smsm = new SMS();
                        break;
                    }
                case ('E'):
                    {
                        Email emailm = new Email();
                        break;
                    }
                case ('T'):
                    {
                        Tweet tweetm = new Tweet(body, messageHeader);

                        break;
                    }
            }
        }
    }
}
