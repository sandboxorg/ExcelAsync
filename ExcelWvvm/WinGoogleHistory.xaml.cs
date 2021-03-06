﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExcelWvvm
{
    /// <summary>
    /// Interaction logic for WinGoogleHistory.xaml
    /// </summary>
    public partial class WinGoogleHistory : Window
    {
        object[,] result = null;
        public WinGoogleHistory()
        {
            InitializeComponent();
            this.Left = 200;
            this.Top = 200;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            result = GoogleHistoryManager.GoogleHistory(this.tbSecurityId.Text, DateTime.Parse(this.tbStartDate.Text), DateTime.Parse(this.tbEndDate.Text));
            if (ExcelHandler.WriteToRangeHandler != null)
            {
                ExcelHandler.WriteToRangeHandler(result);
            }
        }
    }
}
