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
using System.Windows.Navigation;
using System.Windows.Shapes;

using MahApps.Metro.Controls;

namespace SaneBomber
{
    /// <summary>
    /// Interaction logic for SaneBomberMainPanel.xaml
    /// </summary>
    public partial class SaneBomberMainPanel
    {
        public SaneBomberMainPanel()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyTextBox.Text = "Wanna blow something up???";
        }
    }
}
