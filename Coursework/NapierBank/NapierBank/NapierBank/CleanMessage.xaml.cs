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
    /// Interaction logic for CleanMessage.xaml
    /// </summary>
    public partial class CleanMessage : Window
    {

        public CleanMessage(Email m)
        {
            InitializeComponent();

            txtType.Text = "Email";
            txtSender.Text = m.Sender;
            txtSubject.Text = m.Subject;
            txtMessage.Text = m.MessageText;
        

        }
        public CleanMessage(SMS m)
        {
            InitializeComponent();

            txtType.Text = "SMS";
            txtSender.Text = m.Sender;
            lblSubject.Visibility = Visibility.Collapsed;
            txtSubject.Visibility = Visibility.Collapsed;
            txtMessage.Text = m.MessageText;


        }
        public CleanMessage(Tweet m)
        {
            InitializeComponent();

            txtType.Text = "Tweet";
            txtSender.Text = m.Sender;
            lblSubject.Visibility = Visibility.Collapsed;
            txtSubject.Visibility = Visibility.Collapsed;
            txtMessage.Text = m.MessageText;


        }



    }
}
