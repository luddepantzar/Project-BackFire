using System;

using Project_BackFire.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Project_BackFire.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

            
        }
    }
}
