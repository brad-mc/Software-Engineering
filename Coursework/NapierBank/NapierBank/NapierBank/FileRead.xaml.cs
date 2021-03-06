﻿using System;
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
    /// Interaction logic for FileRead.xaml
    /// </summary>
    public partial class FileRead : Window
    {
        public FileRead()
        {
            InitializeComponent();
        }
        //This button sends the path entered into the text box to a method that reads the messages in the text file
        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ReadFile.read(txtFilePath.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid File Name");
            }
        }
    }
}
