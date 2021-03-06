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

namespace PartyOnlineWindows
{
    /// <summary>
    /// UpdateCheck.xaml 的交互逻辑
    /// </summary>
    public partial class UpdateCheck : Window
    {
        private string Status = "Status";

        public UpdateCheck()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();

            var statusBanding = new Binding();
            statusBanding.Source = Status;
            statusBanding.Path = new PropertyPath(".");
            LabelStatus.SetBinding(Label.ContentProperty, statusBanding);
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
