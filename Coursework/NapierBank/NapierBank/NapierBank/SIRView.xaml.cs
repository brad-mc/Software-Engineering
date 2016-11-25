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
    /// Interaction logic for SIRView.xaml
    /// </summary>
    public partial class SIRView : Window
    {
        public SIRView()
        {
            InitializeComponent();

            foreach(Email e in MessageList.sirList)
            {
                lstSIR.Items.Add(e.SIRSortCode + " " + e.SIRIncident);
            }
        }

        private void btnViewSIR_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int i = lstSIR.SelectedIndex;
                CleanMessage cm = new CleanMessage(MessageList.sirList[i]);
                cm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No incident selected");
            }
        }
    }
}
