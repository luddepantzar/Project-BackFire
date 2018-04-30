using System;
using Project_BackFire.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Input;
using Windows.UI.ViewManagement;
using Windows.UI;
using Windows.UI.Xaml.Media.Animation;
using System.Collections.Generic;
using Microsoft.Toolkit.Uwp.UI.Animations;
using System.Linq;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.Foundation.Collections;
using System.IO;
using Windows.Foundation;
using System.Windows;
using Microsoft.Win32;
using Windows.UI.Xaml.Media.Imaging;

namespace Project_BackFire.Views
{
    public sealed partial class Main : Page
    {


        List<DependencyObject> List { get; set; }
        DependencyObject ImageArray { get; set; }
        DispatcherTimer Timer = new DispatcherTimer();
        private Storyboard rotationfront1 = new Storyboard();
        private Storyboard rotationback1 = new Storyboard();
        private Storyboard rotationback2 = new Storyboard();
        private Storyboard rotationback3 = new Storyboard();
        private Storyboard rotationback4 = new Storyboard();
        private Storyboard rotationback5 = new Storyboard();
        private Storyboard rotationback6 = new Storyboard();
        private Storyboard rotationback7 = new Storyboard();
        private Storyboard rotationback8 = new Storyboard();
        private Storyboard rotationfront2 = new Storyboard();
        private Storyboard rotationfront3 = new Storyboard();
        private Storyboard rotationfront4 = new Storyboard();
        private Storyboard rotationfront5 = new Storyboard();
        private Storyboard rotationfront6 = new Storyboard();
        private Storyboard rotationfront7 = new Storyboard();
        private Storyboard rotationfront8 = new Storyboard();
        private Storyboard BorderOpacity = new Storyboard();


        SolidColorBrush GreenBrush = new SolidColorBrush(Color.FromArgb(200, 23, 255, 0));
        SolidColorBrush RedBrush = new SolidColorBrush(Color.FromArgb(200, 211, 63, 73));
        SolidColorBrush YellowBrush = new SolidColorBrush(Color.FromArgb(200, 239, 153, 32));

           
        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }

        public Main()
        {
            InitializeComponent();
            DataContext = this;
            Timer.Tick += TimerTick;
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;
            AnimationBack();
            AnimationFront();           
        


            AnimationFront();

            FlipCardConditions();
        

      
        }

        public void AnimationFront()
        {
            List = new List<DependencyObject>();

            List.Add(Imgbox1);
            List.Add(Imgbox2);
            List.Add(Imgbox3);
            List.Add(Imgbox4);
            List.Add(Imgbox5);
            List.Add(Imgbox6);
            List.Add(Imgbox7);
            List.Add(Imgbox8);
            //DependencyObject AllImages = ImageArray[1];
            //for(var i = 0; i < ImageArray.Length; i++)
            //{
            //    AllImages = ImageArray[i];
            //}
            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 0.0;
            animation1.To = 180.0;
            animation1.BeginTime = TimeSpan.FromSeconds(0);
            animation1.RepeatBehavior = new RepeatBehavior(1);
            animation1.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation1, List[0]);
            Storyboard.SetTargetProperty(animation1, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationfront1.Children.Clear();
            rotationfront1.Children.Add(animation1);

            DoubleAnimation animation3 = new DoubleAnimation();
            animation3.From = 0.0;
            animation3.To = 180.0;
            animation3.BeginTime = TimeSpan.FromSeconds(0);
            animation3.RepeatBehavior = new RepeatBehavior(1);
            animation3.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation3, List[1]);
            Storyboard.SetTargetProperty(animation3, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationfront2.Children.Clear();
            rotationfront2.Children.Add(animation3);

            DoubleAnimation animation5 = new DoubleAnimation();
            animation5.From = 0.0;
            animation5.To = 180.0;
            animation5.BeginTime = TimeSpan.FromSeconds(0);
            animation5.RepeatBehavior = new RepeatBehavior(1);
            animation5.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation5, List[2]);
            Storyboard.SetTargetProperty(animation5, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationfront3.Children.Clear();
            rotationfront3.Children.Add(animation5);

            DoubleAnimation animation7 = new DoubleAnimation();
            animation7.From = 0.0;
            animation7.To = 180.0;
            animation7.BeginTime = TimeSpan.FromSeconds(0);
            animation7.RepeatBehavior = new RepeatBehavior(1);
            animation7.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation7, List[3]);
            Storyboard.SetTargetProperty(animation7, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationfront4.Children.Clear();
            rotationfront4.Children.Add(animation7);

            DoubleAnimation animation9 = new DoubleAnimation();
            animation9.From = 0.0;
            animation9.To = 180.0;
            animation9.BeginTime = TimeSpan.FromSeconds(0);
            animation9.RepeatBehavior = new RepeatBehavior(1);
            animation9.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation9, List[4]);
            Storyboard.SetTargetProperty(animation9, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationfront5.Children.Clear();
            rotationfront5.Children.Add(animation9);

            DoubleAnimation animation11 = new DoubleAnimation();
            animation11.From = 0.0;
            animation11.To = 180.0;
            animation11.BeginTime = TimeSpan.FromSeconds(0);
            animation11.RepeatBehavior = new RepeatBehavior(1);
            animation11.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation11, List[5]);
            Storyboard.SetTargetProperty(animation11, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationfront6.Children.Clear();
            rotationfront6.Children.Add(animation11);

            DoubleAnimation animation13 = new DoubleAnimation();
            animation13.From = 0.0;
            animation13.To = 180.0;
            animation13.BeginTime = TimeSpan.FromSeconds(0);
            animation13.RepeatBehavior = new RepeatBehavior(1);
            animation13.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation13, List[6]);
            Storyboard.SetTargetProperty(animation13, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationfront7.Children.Clear();
            rotationfront7.Children.Add(animation13);

            DoubleAnimation animation15 = new DoubleAnimation();
            animation15.From = 0.0;
            animation15.To = 180.0;
            animation15.BeginTime = TimeSpan.FromSeconds(0);
            animation15.RepeatBehavior = new RepeatBehavior(1);
            animation15.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation15, List[7]);
            Storyboard.SetTargetProperty(animation15, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationfront8.Children.Clear();
            rotationfront8.Children.Add(animation15);
        }

        public void AnimationBack()
        {
            DependencyObject[] list = new DependencyObject[8] { BackImg1, BackImg2, BackImg3, BackImg4, BackImg5, BackImg6, BackImg7, BackImg8 };
            DoubleAnimation animation2 = new DoubleAnimation();
            animation2.From = 180;
            animation2.To = 360;
            animation2.BeginTime = TimeSpan.FromSeconds(0);
            animation2.RepeatBehavior = new RepeatBehavior(1);
            animation2.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation2, list[0]);
            Storyboard.SetTargetProperty(animation2, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationback1.Children.Clear();
            rotationback1.Children.Add(animation2);

            DoubleAnimation animation4 = new DoubleAnimation();
            animation4.From = 180;
            animation4.To = 360;
            animation4.BeginTime = TimeSpan.FromSeconds(0);
            animation4.RepeatBehavior = new RepeatBehavior(1);
            animation4.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation4, list[1]);
            Storyboard.SetTargetProperty(animation4, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationback2.Children.Clear();
            rotationback2.Children.Add(animation4);

            DoubleAnimation animation6 = new DoubleAnimation();
            animation6.From = 180;
            animation6.To = 360;
            animation6.BeginTime = TimeSpan.FromSeconds(0);
            animation6.RepeatBehavior = new RepeatBehavior(1);
            animation6.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation6, list[2]);
            Storyboard.SetTargetProperty(animation6, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationback3.Children.Clear();
            rotationback3.Children.Add(animation6);

            DoubleAnimation animation8 = new DoubleAnimation();
            animation8.From = 180;
            animation8.To = 360;
            animation8.BeginTime = TimeSpan.FromSeconds(0);
            animation8.RepeatBehavior = new RepeatBehavior(1);
            animation8.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation8, list[3]);
            Storyboard.SetTargetProperty(animation8, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationback4.Children.Clear();
            rotationback4.Children.Add(animation8);

            DoubleAnimation animation10 = new DoubleAnimation();
            animation10.From = 180;
            animation10.To = 360;
            animation10.BeginTime = TimeSpan.FromSeconds(0);
            animation10.RepeatBehavior = new RepeatBehavior(1);
            animation10.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation10, list[4]);
            Storyboard.SetTargetProperty(animation10, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationback5.Children.Clear();
            rotationback5.Children.Add(animation10);

            DoubleAnimation animation12 = new DoubleAnimation();
            animation12.From = 180;
            animation12.To = 360;
            animation12.BeginTime = TimeSpan.FromSeconds(0);
            animation12.RepeatBehavior = new RepeatBehavior(1);
            animation12.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation12, list[5]);
            Storyboard.SetTargetProperty(animation12, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationback6.Children.Clear();
            rotationback6.Children.Add(animation12);

            DoubleAnimation animation14 = new DoubleAnimation();
            animation14.From = 180;
            animation14.To = 360;
            animation14.BeginTime = TimeSpan.FromSeconds(0);
            animation14.RepeatBehavior = new RepeatBehavior(1);
            animation14.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation14, list[6]);
            Storyboard.SetTargetProperty(animation14, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationback7.Children.Clear();
            rotationback7.Children.Add(animation14);

            DoubleAnimation animation16 = new DoubleAnimation();
            animation16.From = 180;
            animation16.To = 360;
            animation16.BeginTime = TimeSpan.FromSeconds(0);
            animation16.RepeatBehavior = new RepeatBehavior(1);
            animation16.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation16, list[7]);
            Storyboard.SetTargetProperty(animation16, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationback8.Children.Clear();
            rotationback8.Children.Add(animation16);
        }

        private void TimerTick(object sender, object e)
        {
            TimeDate.Text = DateTime.Now.ToString("HH:mm");
            TodaysDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
        }

        private void TimerTick2(object sender, object e)
        {
            TimeDate12h.Text = DateTime.Now.ToString("hh:mm");
            TodaysDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void Bighours_Click(object sender, RoutedEventArgs e)
        {
            TimerTick2(sender, e);
        }

        private void Smallhours_Click(object sender, RoutedEventArgs e)
        {
            TimerTick(sender, e);
        }

        private void Animation()
        {
            Imgbox1.Fade(duration: 1000, delay: 0, value: 0).Start();
            Imgbox2.Fade(duration: 1000, delay: 0, value: 0).Start();
            Imgbox3.Fade(duration: 1000, delay: 0, value: 0).Start();
            Imgbox4.Fade(duration: 1000, delay: 0, value: 0).Start();
            Imgbox5.Fade(duration: 1000, delay: 0, value: 0).Start();
            Imgbox6.Fade(duration: 1000, delay: 0, value: 0).Start();
            Imgbox7.Fade(duration: 1000, delay: 0, value: 0).Start();
            Imgbox8.Fade(duration: 1000, delay: 0, value: 0).Start();

            rotationfront1.Begin();
            rotationfront2.Begin();
            rotationfront3.Begin();
            rotationfront4.Begin();
            rotationfront5.Begin();
            rotationfront6.Begin();
            rotationfront7.Begin();
            rotationfront8.Begin();
            rotationback1.Begin();
            rotationback2.Begin();
            rotationback3.Begin();
            rotationback4.Begin();
            rotationback5.Begin();
            rotationback6.Begin();
            rotationback7.Begin();
            rotationback8.Begin();
        }

        private void Fade()
        {
            BackImg1.Opacity = 0;
            BackImg2.Opacity = 0;
            BackImg3.Opacity = 0;
            BackImg4.Opacity = 0;
            BackImg5.Opacity = 0;
            BackImg6.Opacity = 0;
            BackImg7.Opacity = 0;
            BackImg8.Opacity = 0;

            grid1.Opacity = 0;
            grid2.Opacity = 0;
            grid3.Opacity = 0;
            grid4.Opacity = 0;
            grid5.Opacity = 0;
            grid6.Opacity = 0;
            grid7.Opacity = 0;
            grid8.Opacity = 0;

            grid1.Fade(duration: 4000, delay: 3000, value: 1).StartAsync();
            grid1.Fade(duration: 4000, delay: 3000, value: 1).StartAsync();
            grid2.Fade(duration: 4000, delay: 3000, value: 1).StartAsync();
            grid3.Fade(duration: 4000, delay: 3000, value: 1).StartAsync();
            grid4.Fade(duration: 4000, delay: 3000, value: 1).StartAsync();
            grid5.Fade(duration: 4000, delay: 3000, value: 1).StartAsync();
            grid6.Fade(duration: 4000, delay: 3000, value: 1).StartAsync();
            grid7.Fade(duration: 4000, delay: 3000, value: 1).StartAsync();
            grid8.Fade(duration: 4000, delay: 3000, value: 1).StartAsync();

            BackImg1.Fade(duration: 4000, delay: 1200, value: 1).StartAsync();
            BackImg2.Fade(duration: 4000, delay: 1200, value: 1).StartAsync();
            BackImg3.Fade(duration: 4000, delay: 1200, value: 1).StartAsync();
            BackImg4.Fade(duration: 4000, delay: 1200, value: 1).StartAsync();
            BackImg5.Fade(duration: 4000, delay: 1200, value: 1).StartAsync();
            BackImg6.Fade(duration: 4000, delay: 1200, value: 1).StartAsync();
            BackImg7.Fade(duration: 4000, delay: 1200, value: 1).StartAsync();
            BackImg8.Fade(duration: 4000, delay: 1200, value: 1).StartAsync();

            rotationback8.Begin();

            rotationback8.Begin();         

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Animation();
            Fade();

            Imgbox1.Fade(duration: 1000, delay: 0, value: 0).Start();
            Imgbox2.Fade(duration: 1000, delay: 0, value: 0).Start();
            Imgbox3.Fade(duration: 1000, delay: 0, value: 0).Start();
            Imgbox4.Fade(duration: 1000, delay: 0, value: 0).Start();
            Imgbox5.Fade(duration: 1000, delay: 0, value: 0).Start();
            Imgbox6.Fade(duration: 1000, delay: 0, value: 0).Start();
            Imgbox7.Fade(duration: 1000, delay: 0, value: 0).Start();
            Imgbox8.Fade(duration: 1000, delay: 0, value: 0).Start();


            Imgbox1.Fade(duration: 1500, delay: 0, value: 0).Start();
            Imgbox2.Fade(duration: 1500, delay: 0, value: 0).Start();
            Imgbox3.Fade(duration: 1500, delay: 0, value: 0).Start();
            Imgbox4.Fade(duration: 1500, delay: 0, value: 0).Start();
            Imgbox5.Fade(duration: 1500, delay: 0, value: 0).Start();
            Imgbox6.Fade(duration: 1500, delay: 0, value: 0).Start();
            Imgbox7.Fade(duration: 1500, delay: 0, value: 0).Start();
            Imgbox8.Fade(duration: 1500, delay: 0, value: 0).Start();

            BackImg1.Fade(duration: 100, delay: 0, value: 0).Start();
            BackImg2.Fade(duration: 100, delay: 0, value: 0).Start();
            BackImg3.Fade(duration: 100, delay: 0, value: 0).Start();
            BackImg4.Fade(duration: 100, delay: 0, value: 0).Start();
            BackImg5.Fade(duration: 100, delay: 0, value: 0).Start();
            BackImg6.Fade(duration: 100, delay: 0, value: 0).Start();
            BackImg7.Fade(duration: 100, delay: 0, value: 0).Start();
            BackImg8.Fade(duration: 100, delay: 0, value: 0).Start();

            BackImg1.Fade(duration: 4000, delay: 2000, value: 1).Start();
            BackImg2.Fade(duration: 4000, delay: 2000, value: 1).Start();
            BackImg3.Fade(duration: 4000, delay: 2000, value: 1).Start();
            BackImg4.Fade(duration: 4000, delay: 2000, value: 1).Start();
            BackImg5.Fade(duration: 4000, delay: 2000, value: 1).Start();
            BackImg6.Fade(duration: 4000, delay: 2000, value: 1).Start();
            BackImg7.Fade(duration: 4000, delay: 2000, value: 1).Start();
            BackImg8.Fade(duration: 4000, delay: 2000, value: 1).Start();

        }

        private void FlipCardConditions()
        {

            //if (List.Count < 8)
            //{
            //    rotationback1.Stop();
            //    rotationfront1.Stop();
            //    //rotationBorder1.Stop();
            //}
            //else if (List.Count > 8)
            //{
            //    rotationback1.Stop();
            //    rotationfront1.Stop();
            //    DispatcherTimer tm8 = new DispatcherTimer();
            //    tm8.Interval = TimeSpan.FromSeconds(1.4);
            //    tm8.Tick += (sender, args) =>
            //    {
            //        rotationback1.Begin();
            //        rotationfront1.Begin();
            //        //rotationBorder1.Begin();
            //        tm8.Stop();
            //    };
            //    tm8.Start();
            //}
        }

        private void button1_PointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            btn1.Visibility = Visibility.Visible;
        }

        public void button1_PointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            btn1.Visibility = Visibility.Collapsed;
            DateTime TimeNow = new DateTime();
            TimeNow = DateTime.Now;
            string CurrentDatetime = TimeNow.ToString();
        }

        private void colordefault_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Background = (LinearGradientBrush)Resources["theme3b"];
            MenuBar.Background = (LinearGradientBrush)Resources["theme3a"];
        }

        private void color1_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Background = (LinearGradientBrush)Resources["theme2a"];
            MenuBar.Background = (LinearGradientBrush)Resources["theme2b"];


            MenuBar.Background = (LinearGradientBrush)Resources["theme2b"];

            MenuBar.Background = (LinearGradientBrush)Resources["theme2b"];


        }

        private void color2_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Background = (LinearGradientBrush)Resources["theme1a"];
            MenuBar.Background = (LinearGradientBrush)Resources["theme1b"];
        }

        private void color3_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Background = (LinearGradientBrush)Resources["theme4a"];
            MenuBar.Background = (LinearGradientBrush)Resources["theme4b"];
        }

        private void SettingsMenu_Click(object sender, RoutedEventArgs e)
        {
            /*
           */
        }

        //public void OnPointerMoved(object Sender, PointerRoutedEventArgs e)
        //{
        //    CmdBar.ClosedDisplayMode = AppBarClosedDisplayMode.Compact;
        //    DispatcherTimer ButtonTimer = new DispatcherTimer();
        //    ButtonTimer.Interval = TimeSpan.FromSeconds(5);
        //    ButtonTimer.Tick += (sender, args) =>
        //    {
        //        CmdBar.ClosedDisplayMode = AppBarClosedDisplayMode.Hidden;
        //        ButtonTimer.Stop();
        //    };
        //    ButtonTimer.Start();
        //}

        public void OnPointerMoved(object Sender, PointerRoutedEventArgs e)
        {
            CmdBar.ClosedDisplayMode = AppBarClosedDisplayMode.Compact;
            DispatcherTimer ButtonTimer = new DispatcherTimer();
            ButtonTimer.Interval = TimeSpan.FromSeconds(5);
            ButtonTimer.Tick += (sender, args) =>
            {
                CmdBar.ClosedDisplayMode = AppBarClosedDisplayMode.Hidden;
                ButtonTimer.Stop();
            };
            ButtonTimer.Start();
}
        private void SettingsButtonAppBar_Click(object sender, RoutedEventArgs e)
        {
            SettingsGrid.Visibility = Visibility.Visible;
            GeneralSettingsGrid.Visibility = Visibility.Visible;
            ApiSettingsGrid.Visibility = Visibility.Collapsed;
            CmdBar.ClosedDisplayMode = AppBarClosedDisplayMode.Compact;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void LeaveSettingsMenu_Click(object sender, RoutedEventArgs e)
        {
            SettingsGrid.Visibility = Visibility.Collapsed;
        }

        private void ApiButton_Click(object sender, RoutedEventArgs e)
        {
            ApiSettingsGrid.Visibility = Visibility.Visible;
            GeneralSettingsGrid.Visibility = Visibility.Collapsed;
        }

        private void GeneralSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            GeneralSettingsGrid.Visibility = Visibility.Visible;
            ApiSettingsGrid.Visibility = Visibility.Collapsed;
        }

        private void ColorPicker_ColorChanged(ColorPicker sender, ColorChangedEventArgs args)
        {
            ContentArea.Background = new SolidColorBrush(args.NewColor);
            //ContentArea.Background = new LinearGradientBrush(
            //    new GradientStopCollection(args.NewColor, 0.0, 0.1, 0.2),
            //    new GradientStopCollection(System.Drawing.Color.FromArgb(56, 56, 56, 100), 0.75)); //Standard second color for the gradient.
            ////ContentArea.Background       
            //ContentArea.Background = new GradientBrush(
            //    new Point(),
            //    new Point(),
            //    args.NewColor,
            //    Color.FromArgb(56, 56, 56, 100));
        }
        private void ColorPicker_ColorChanged_1(ColorPicker sender, ColorChangedEventArgs args)
        {
            MenuBar.Background = new SolidColorBrush(args.NewColor);
        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            TimeDate.Visibility = Visibility.Collapsed;
            TimeDate12h.Visibility = Visibility.Visible;
        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            TimeDate.Visibility = Visibility.Visible;
            TimeDate12h.Visibility = Visibility.Collapsed;
        }

        private void ContentArea_Tapped(object Sender, TappedRoutedEventArgs e)
        {
            CmdBar.ClosedDisplayMode = AppBarClosedDisplayMode.Compact;
            DispatcherTimer ButtonTimer = new DispatcherTimer();
            ButtonTimer.Interval = TimeSpan.FromSeconds(20);
            ButtonTimer.Tick += (sender, args) =>
            {
                CmdBar.ClosedDisplayMode = AppBarClosedDisplayMode.Hidden;
                ButtonTimer.Stop();
            };
            ButtonTimer.Start();
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            //    timebtn.Content = "12 Timmars klocka";
            //    TimeDate12h.Text = DateTime.Now.ToString("hh:mm");
        }

        private void timebtn_Unchecked(object sender, RoutedEventArgs e)
        {
            //    timebtn.Content = "24 Timmars klocka";
            //    TimeDate12h.Text = DateTime.Now.ToString("HH:mm");
        }

        public void RectangleGridDefaultColor()
        {
            //
        }

        private void grid1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            
            RectangelGrid1.Fill = RedBrush;
            RectangelGrid2.Fill = RedBrush;
            RectangelGrid3.Fill = RedBrush;
            RectangelGrid4.Fill = RedBrush;
            RectangelGrid5.Fill = RedBrush;
            RectangelGrid6.Fill = RedBrush;
            RectangelGrid7.Fill = RedBrush;
            RectangelGrid8.Fill = RedBrush;

            DispatcherTimer ColorTimer = new DispatcherTimer();
            ColorTimer.Interval = TimeSpan.FromSeconds(5);
            ColorTimer.Tick += (Sender, args) =>
            {
                RectangelGrid1.Fill = YellowBrush;
                RectangelGrid2.Fill = YellowBrush;
                RectangelGrid3.Fill = YellowBrush;
                RectangelGrid4.Fill = YellowBrush;
                RectangelGrid5.Fill = YellowBrush;
                RectangelGrid6.Fill = YellowBrush;
                RectangelGrid7.Fill = YellowBrush;
                RectangelGrid8.Fill = YellowBrush;
                ColorTimer.Stop();

                DispatcherTimer ColorTimer2 = new DispatcherTimer();
                ColorTimer2.Interval = TimeSpan.FromMinutes(45);
                ColorTimer2.Tick += (Zender, Args) =>
                {
                    RectangelGrid1.Fill = GreenBrush;
                    RectangelGrid2.Fill = GreenBrush;
                    RectangelGrid3.Fill = GreenBrush;
                    RectangelGrid4.Fill = GreenBrush;
                    RectangelGrid5.Fill = GreenBrush;
                    RectangelGrid6.Fill = GreenBrush;
                    RectangelGrid7.Fill = GreenBrush;
                    RectangelGrid8.Fill = GreenBrush;
                    ColorTimer2.Stop();
                };
                ColorTimer2.Start();
            };

            ColorTimer.Start();
        }

            //    timebtn.Content = "24 Timmars klocka";
            //    TimeDate12h.Text = DateTime.Now.ToString("HH:mm");


       public void Image_Loaded(object sender, RoutedEventArgs e)
        {
            Image img = sender as Image;
            BitmapImage bitmapImage = new BitmapImage();         
            bitmapImage.UriSource = new Uri(img.BaseUri, "ms-appx:///Images/test_logo.png");
            //Image img = new Image();
            //img.Source = new BitmapImage(new Uri("ms-appx:///Images/test_logo.png"));
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (Grid4x2.Visibility == Visibility.Collapsed)
            {
                Grid4x2.Visibility = Visibility.Visible;
                Grid2x2.Visibility = Visibility.Collapsed;
                Grid2x3.Visibility = Visibility.Collapsed;
                Grid3x2.Visibility = Visibility.Collapsed;
            }
            else
            {
                Grid4x2.Visibility = Visibility.Collapsed;
            }

        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (Grid3x2.Visibility == Visibility.Collapsed)
            {
                Grid3x2.Visibility = Visibility.Visible;
                Grid2x2.Visibility = Visibility.Collapsed;
                Grid2x3.Visibility = Visibility.Collapsed;
                Grid4x2.Visibility = Visibility.Collapsed;


            }
            
            else if (Grid3x2.Visibility == Visibility.Visible) 
            {
                Grid3x2.Visibility = Visibility.Collapsed;
            }


        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {

            if (Grid2x3.Visibility == Visibility.Collapsed)
            {
                Grid2x3.Visibility = Visibility.Visible;
                Grid2x2.Visibility = Visibility.Collapsed;
                Grid3x2.Visibility = Visibility.Collapsed;

                Grid2x2.Visibility = Visibility.Collapsed;              
                Grid3x2.Visibility = Visibility.Collapsed;
                Grid4x2.Visibility = Visibility.Collapsed;
            }
            else
            {
                Grid2x3.Visibility = Visibility.Collapsed;
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (Grid2x2.Visibility == Visibility.Collapsed)
            {
                Grid2x2.Visibility = Visibility.Visible;
                Grid2x3.Visibility = Visibility.Collapsed;
                Grid3x2.Visibility = Visibility.Collapsed;
                Grid3x2.Visibility = Visibility.Collapsed;
                Grid4x2.Visibility = Visibility.Collapsed;
            }
            else
            {
                Grid2x2.Visibility = Visibility.Collapsed;
            }
        }

        private void rndbtn_Click(object sender, RoutedEventArgs e)
        {

            Random rnd = new Random();
            int value = rnd.Next(0, 5); // creates a number between 0 and 5


            switch (value)
            {

                case 1:
                    //Gör en animation
                    BackImg1.Opacity = 0;
                    grid1.Opacity = 0;
                    rotationfront1.Begin();
                    rotationback1.Begin();
                    Imgbox1.Fade(duration: 1000, delay: 0, value: 0).Start();
                    grid1.Fade(duration: 4000, delay: 3000, value: 1).StartAsync();
                    BackImg1.Fade(duration: 4000, delay: 1200, value: 1).StartAsync();
                    break;

                case 2:
                    //Bli Röd
                    RectangelGrid1.Fill = RedBrush;
                    RectangelGrid2.Fill = RedBrush;
                    RectangelGrid3.Fill = RedBrush;
                    RectangelGrid4.Fill = RedBrush;
                    RectangelGrid5.Fill = RedBrush;
                    RectangelGrid6.Fill = RedBrush;
                    RectangelGrid7.Fill = RedBrush;
                    RectangelGrid8.Fill = RedBrush;
                    break;

                case 3:
                    //Bli Gul
                    RectangelGrid1.Fill = YellowBrush;
                    RectangelGrid2.Fill = YellowBrush;
                    RectangelGrid3.Fill = YellowBrush;
                    RectangelGrid4.Fill = YellowBrush;
                    RectangelGrid5.Fill = YellowBrush;
                    RectangelGrid6.Fill = YellowBrush;
                    RectangelGrid7.Fill = YellowBrush;
                    RectangelGrid8.Fill = YellowBrush;
                    break;

                case 4:
                    //Gör animation på övreraden
                    break;

                case 5:
                    //gör animation på undreraden
                    break;

                default:
                    RectangelGrid1.Fill = GreenBrush;
                    RectangelGrid2.Fill = GreenBrush;
                    RectangelGrid3.Fill = GreenBrush;
                    RectangelGrid4.Fill = GreenBrush;
                    RectangelGrid5.Fill = GreenBrush;
                    RectangelGrid6.Fill = GreenBrush;
                    RectangelGrid7.Fill = GreenBrush;
                    RectangelGrid8.Fill = GreenBrush;
                    break;


            }
        }

        private async void imgbtn_Click(object sender, RoutedEventArgs e)
        {
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            picker.FileTypeFilter.Add(".jpg");
            picker.FileTypeFilter.Add(".jpeg");
            picker.FileTypeFilter.Add(".png");

            Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();
            if (file != null)
            {
                //Application now has read/write access to the picked file
                //this.textBlock.Text = "Picked photo: " + file.Path;
                //Imgbox1.Source = new ImageSource(file.Path);

               Logo.Source = new BitmapImage(new Uri(file.Path));
                          
            }
            else
            {
               //
            }

        }
    }

}
