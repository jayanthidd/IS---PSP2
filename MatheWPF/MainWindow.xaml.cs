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

namespace MatheWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MathModell model;
        public MainWindow()
        {
            InitializeComponent();
            model = new MathModell();
            model.ResetGame();
            this.DataContext = model;
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            model.CheckAnswer();
            model.GenerateNewQuestion();
        }

        private void StartNewGame(object sender, RoutedEventArgs e)
        {
            model.ResetGame();
        }

    }
}
