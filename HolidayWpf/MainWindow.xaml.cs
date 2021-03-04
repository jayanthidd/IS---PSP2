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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HolidayWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel main = new MainWindowViewModel();
        public MainWindow()
        {
            this.DataContext = main;
            InitializeComponent();
        }

        private void AddNew(object sender, RoutedEventArgs e)
        {
            main.AddNewVacation();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            SearchWindow searchWindow = new SearchWindow();
            searchWindow.ShowDialog();
            var searchtext = searchWindow.Search.SearchText;// accessing the data entered into the search box from the search window
            main.SearchText = searchtext; // saving down that information into a property in the main window model class
            main.Filter(); // calling the filter function in the main class
        }

        private void DeleteVacation(object sender, RoutedEventArgs e)
        {
            main.DeleteVacation();
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            main.NewVacation.Vorgemerkt = true;
        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            main.NewVacation.Vorgemerkt = false;
        }
    }
}
