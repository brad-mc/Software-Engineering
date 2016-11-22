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
using System.Windows.Shapes;

namespace NapierBank
{
    /// <summary>
    /// Interaction logic for SendMessage.xaml
    /// </summary>
    public partial class SendMessage : Window
    {
        int id = 100000001;
         

        public SendMessage()
        {
            InitializeComponent();
            cbbType.Items.Add("Email");
            cbbType.Items.Add("SMS");
            cbbType.Items.Add("Tweet");

           


        }

        private void cbbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cbbType.SelectedIndex)
            {
                case 0:
                    {
                        lblSender.Content = "Email";
                        lblSubject.Visibility = Visibility.Visible;
                        txtSubject.MaxLength = 20;
                        txtSubject.Visibility = Visibility.Visible;
                        txtMessage.MaxLength = 1028;
                        break;
                    }
                case 1:
                    {
                        lblSender.Content = "Phone Number";
                        lblSubject.Visibility = Visibility.Hidden;
                        txtSubject.Visibility = Visibility.Hidden;
                        txtMessage.MaxLength = 140;
                        break;
                    }
                case 2:
                    {
                        lblSender.Content = "Twitter Handle";
                        lblSubject.Visibility = Visibility.Hidden;
                        txtSubject.Visibility = Visibility.Hidden;
                        txtMessage.MaxLength = 140;
                        break;
                    }
            }

        }

        private void btnSendMessage_Click(object sender, RoutedEventArgs e)
        {

            string message;
            int i = 0;
            char[] subject = new char[20]; 
            foreach (char c in txtSubject.Text)
            {
                
                subject[i] = c;
                i = i + 1;
            }

            string s = new string(subject);

            switch (cbbType.SelectedIndex)
            {
                case 0:
                    {
                        id = id + 1;
                        message = "E" + id +" "+ txtSender.Text +" "+ s +" "+ txtMessage.Text;
                        Sanitise.SanitiseMessage(message);
                        break; 
                    }
                case 1:
                    {
                        id = id + 1;
                        message = "S" + id + " "+ txtSender.Text + " " + txtMessage.Text;
                        Sanitise.SanitiseMessage(message);
                        break;
                    }
                case 2:
                    {
                        id = id + 1;
                        message = "S" + id + " " + txtSender.Text + " " + txtMessage.Text;
                        Sanitise.SanitiseMessage(message);
                        break;
                    }

            }
        }
    }
}
