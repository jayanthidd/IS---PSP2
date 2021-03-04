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

namespace DataBindingTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Movie movie = new Movie();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = movie;
            movie.MovieName = "Sound Of Music";
            movie.YearOfRelease = 1965;
            movie.Genre = new List<string>();
            movie.Genre.Add("Adventure");
            movie.Genre.Add("Family");
            movie.Genre.Add("Comedy");
            movie.Genre.Add("Horror");
            movie.Rating = 5;
        }
    }
}
