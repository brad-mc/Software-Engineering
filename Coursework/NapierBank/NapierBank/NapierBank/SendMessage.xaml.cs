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
           
           


        }

        
        //This button allows the user to input messages in plain text
        private void btnSendMessage_Click(object sender, RoutedEventArgs e)
        {

            string message;
            try
            {
                message = txtMessageHeader.Text + txtMessage.Text;
                Sanitise.SanitiseMessage(message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid Entry");
            }    
               
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
           // MainWindow mw = new MainWindow();
            this.Hide();
          //  mw.Show();
            
        }
    }
}
