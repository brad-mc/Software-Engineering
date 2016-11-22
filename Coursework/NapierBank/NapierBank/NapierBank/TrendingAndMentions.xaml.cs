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
    /// Interaction logic for TrendingAndMentions.xaml
    /// </summary>
    public partial class TrendingAndMentions : Window
    {
        public TrendingAndMentions()
        {
            InitializeComponent();

            var trending = MessageList.hashTags.GroupBy(x => x).Select(g => new { Value = g.Key, Count = g.Count() }).OrderByDescending(x => x.Count);
            foreach (var x in trending)
            {
                lstTrending.Items.Add(x.Value);
            }

            foreach(string s in MessageList.sirList)
            {
                lstSIR.Items.Add(s);
            }
            foreach (string s in MessageList.mentions)
            {
                lst_Mentions.Items.Add(s);
            }
        }
    }
}
