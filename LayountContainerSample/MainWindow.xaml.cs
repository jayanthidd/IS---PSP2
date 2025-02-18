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

namespace LayountContainerSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            ListBoxItem listBoxItem = (ListBoxItem)listBox.SelectedValue;
            string farbe = listBoxItem.Content.ToString();

            Color color = (Color)ColorConverter.ConvertFromString(farbe);

            myMenu.Background = new SolidColorBrush(color);
        }
    }
}
