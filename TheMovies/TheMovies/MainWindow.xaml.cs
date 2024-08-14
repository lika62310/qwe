﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TheMovies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MovieRepository MovieRepo;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            MovieRepo = new MovieRepository();
            lbMovies.ItemsSource = MovieRepo.Movies;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MovieRepo.AddMovie(new Movie(tbTitle.Text, int.Parse(tbDuration.Text), tbGenre.Text));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //lbMovies.Items.Remove(lbMovies.SelectedItem);
            MovieRepo.RemoveMovie(lbMovies.Items.IndexOf(lbMovies.SelectedItem));      
        }
    }
}