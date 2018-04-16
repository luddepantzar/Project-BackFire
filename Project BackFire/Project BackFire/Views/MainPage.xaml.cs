using System;
using Project_BackFire.ViewModels;
using Windows.UI.Xaml;
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

        private void Button_PointerMoved(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            Opacity = 100;
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Opacity = 100;
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
            DateTime TimeNow = new DateTime();
            TimeNow = DateTime.Now;
            String CurrentDatetime = TimeNow.ToString();
        }
    }
}
