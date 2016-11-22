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
    /// Interaction logic for ViewMessages.xaml
    /// </summary>
    public partial class ViewMessages : Window
    {
        public ViewMessages()
        {
            InitializeComponent();

            foreach(SMS m in MessageList.smsList)
            {
                lstSMS.Items.Add(m.MessageHeader + " " + m.Sender);
            }
            foreach (Email m in MessageList.emailList)
            {
                lstEmail.Items.Add(m.MessageHeader + " " + m.Sender +" " + m.Subject);
            }
            foreach (Tweet m in MessageList.tweetList)
            {
                lstTweet.Items.Add(m.MessageHeader + " " + m.Sender);
            }
        }

        private void lstSMS_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lstEmail.SelectedItem = null;
            lstTweet.SelectedItem = null;
        }

        private void lstEmail_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lstSMS.SelectedItem = null;
            lstTweet.SelectedItem = null;
        }

        private void lstTweet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lstEmail.SelectedItem = null;
            lstSMS.SelectedItem = null;

            
        }
        private void lstTweet_OnClick(object sender, SelectionChangedEventArgs e)
        {
            int i = lstTweet.SelectedIndex;
            CleanMessage cm = new CleanMessage(MessageList.tweetList[i]);
            cm.Show();
        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            if(lstTweet.SelectedItem != null)
            {
                int i = lstTweet.SelectedIndex;
                CleanMessage cm = new CleanMessage(MessageList.tweetList[i]);
                cm.Show();
            }
            if (lstEmail.SelectedItem != null)
            {
                int i = lstEmail.SelectedIndex;
                CleanMessage cm = new CleanMessage(MessageList.emailList[i]);
                cm.Show();
            }
            if (lstSMS.SelectedItem != null)
            {
                int i = lstSMS.SelectedIndex;
                CleanMessage cm = new CleanMessage(MessageList.smsList[i]);
                cm.Show();
            }
        }
    }
}
