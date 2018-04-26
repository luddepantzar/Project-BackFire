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
using System.Drawing;
using System.Linq;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.Foundation;
using Windows.Foundation.Collections;
using System.IO;

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
        private Storyboard rotationBorder1 = new Storyboard();
        private Storyboard rotationBorder2 = new Storyboard();
        private Storyboard rotationBorder3 = new Storyboard();
        private Storyboard rotationBorder4 = new Storyboard();
        private Storyboard rotationBorder5 = new Storyboard();
        private Storyboard rotationBorder6 = new Storyboard();
        private Storyboard rotationBorder7 = new Storyboard();
        private Storyboard rotationBorder8 = new Storyboard();

        private Storyboard BorderOpacity = new Storyboard();

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
            FlipCardConditions();
            
            this.DataContext = new MainViewModel();
            this.InitializeComponent();
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
            TodaysDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }
        private void Smallhours_Click(object sender, RoutedEventArgs e)
        {
            TimerTick(sender, e);
        }
        public void OpacityImage2()
        {
            BackImg1.Opacity = 0;
            DispatcherTimer tm1 = new DispatcherTimer();
            tm1.Interval = TimeSpan.FromSeconds(1.4);
            tm1.Tick += (sender, args) =>
            {
                BackImg1.Opacity = 100;
                tm1.Stop();
            };
            tm1.Start();

            BackImg2.Opacity = 0;
            DispatcherTimer tm2 = new DispatcherTimer();
            tm2.Interval = TimeSpan.FromSeconds(1.4);
            tm2.Tick += (sender, args) =>
            {
                BackImg2.Opacity = 100;
                tm2.Stop();
            };
            tm2.Start();

            BackImg3.Opacity = 0;
            DispatcherTimer tm3 = new DispatcherTimer();
            tm3.Interval = TimeSpan.FromSeconds(1.4);
            tm3.Tick += (sender, args) =>
            {
                BackImg3.Opacity = 100;
                tm3.Stop();
            };
            tm3.Start();

            BackImg4.Opacity = 0;
            DispatcherTimer tm4 = new DispatcherTimer();
            tm4.Interval = TimeSpan.FromSeconds(1.4);
            tm4.Tick += (sender, args) =>
            {
                BackImg4.Opacity = 100;
                tm4.Stop();
            };
            tm4.Start();

            BackImg5.Opacity = 0;
            DispatcherTimer tm5 = new DispatcherTimer();
            tm5.Interval = TimeSpan.FromSeconds(1.4);
            tm5.Tick += (sender, args) =>
            {
                BackImg5.Opacity = 100;
                tm5.Stop();
            };
            tm5.Start();

            BackImg6.Opacity = 0;
            DispatcherTimer tm6 = new DispatcherTimer();
            tm6.Interval = TimeSpan.FromSeconds(1.4);
            tm6.Tick += (sender, args) =>
            {
                BackImg6.Opacity = 100;
                tm6.Stop();
            };
            tm6.Start();

            BackImg7.Opacity = 0;
            DispatcherTimer tm7 = new DispatcherTimer();
            tm7.Interval = TimeSpan.FromSeconds(1.4);
            tm7.Tick += (sender, args) =>
            {
                BackImg7.Opacity = 100;
                tm7.Stop();
            };
            tm7.Start();

            BackImg8.Opacity = 0;
            DispatcherTimer tm8 = new DispatcherTimer();
            tm8.Interval = TimeSpan.FromSeconds(1.4);
            tm8.Tick += (sender, args) =>
            {
                BackImg8.Opacity = 100;
                tm8.Stop();
            };
            tm8.Start();

        }

        private void Animation()
        {
            BorderOpacity.Begin();
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
            rotationBorder1.Begin();
            rotationBorder2.Begin();
            rotationBorder3.Begin();
            rotationBorder4.Begin();
            rotationBorder5.Begin();
            rotationBorder6.Begin();
            rotationBorder7.Begin();
            rotationBorder8.Begin();
            OpacityImage2();

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Animation();

            grid1.Fade(duration: 50, delay: 0, value: 0).Start();
            grid2.Fade(duration: 50, delay: 0, value: 0).Start();
            grid3.Fade(duration: 50, delay: 0, value: 0).Start();
            grid4.Fade(duration: 50, delay: 0, value: 0).Start();
            grid5.Fade(duration: 50, delay: 0, value: 0).Start();
            grid6.Fade(duration: 50, delay: 0, value: 0).Start();
            grid7.Fade(duration: 50, delay: 0, value: 0).Start();
            grid8.Fade(duration: 50, delay: 0, value: 0).Start();

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

            grid1.Fade(duration: 1000, delay: 10000, value: 1).Start();
            grid2.Fade(duration: 1000, delay: 10000, value: 1).Start();
            grid3.Fade(duration: 1000, delay: 10000, value: 1).Start();
            grid4.Fade(duration: 1000, delay: 10000, value: 1).Start();
            grid5.Fade(duration: 1000, delay: 10000, value: 1).Start();
            grid6.Fade(duration: 1000, delay: 10000, value: 1).Start();
            grid7.Fade(duration: 1000, delay: 10000, value: 1).Start();
            grid8.Fade(duration: 1000, delay: 106000, value: 1).Start();
        }
        private void FlipCardConditions()
        {
            if (List.Count < 8)
            {
                rotationback1.Stop();
                rotationfront1.Stop();
                //rotationBorder1.Stop();
            }
            else if (List.Count > 8)
            {
                rotationback1.Stop();
                rotationfront1.Stop();
                DispatcherTimer tm8 = new DispatcherTimer();
                tm8.Interval = TimeSpan.FromSeconds(1.4);
                tm8.Tick += (sender, args) =>
                {
                    rotationback1.Begin();
                    rotationfront1.Begin();
                    //rotationBorder1.Begin();
                    tm8.Stop();
                };
                tm8.Start();
            }
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
            ThemeGrid.Visibility = Visibility.Collapsed;
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
        private void ThemeButton_Click(object sender, RoutedEventArgs e)
        {
            ThemeGrid.Visibility = Visibility.Visible;
            GeneralSettingsGrid.Visibility = Visibility.Collapsed;
            ApiSettingsGrid.Visibility = Visibility.Collapsed;
        }
        private void ApiButton_Click(object sender, RoutedEventArgs e)
        {
            ApiSettingsGrid.Visibility = Visibility.Visible;
            GeneralSettingsGrid.Visibility = Visibility.Collapsed;
            ThemeGrid.Visibility = Visibility.Collapsed;
        }
        private void GeneralSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            GeneralSettingsGrid.Visibility = Visibility.Visible;
            ThemeGrid.Visibility = Visibility.Collapsed;
            ApiSettingsGrid.Visibility = Visibility.Collapsed;
        }

        private void ColorPicker_ColorChanged(ColorPicker sender, ColorChangedEventArgs args)
        {
            ////ContentArea.Background       
            //ContentArea.Background = new GradientBrush(
            //    new Point(),
            //    new Point(),
            //    args.NewColor,
            //    Color.FromArgb(56, 56, 56, 100));

            ContentArea.Background = new LinearGradientBrush(
                ); //Standard second color for the gradient.
        }
        private void ColorPicker_ColorChanged_1(ColorPicker sender, ColorChangedEventArgs args)
        {
            MenuBar.Background = new SolidColorBrush(args.NewColor);
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {

            grid1.Fade(duration: 4000, delay: 0, value: 1f).Start();
            grid2.Fade(duration: 4000, delay: 0, value: 1f).Start();
            grid3.Fade(duration: 4000, delay: 0, value: 1f).Start();
            grid4.Fade(duration: 4000, delay: 0, value: 1f).Start();
            grid5.Fade(duration: 4000, delay: 0, value: 1f).Start();
            grid6.Fade(duration: 4000, delay: 0, value: 1f).Start();
            grid7.Fade(duration: 4000, delay: 0, value: 1f).Start();
            grid8.Fade(duration: 4000, delay: 0, value: 1f).Start();
        }
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Imgbox1.Fade(duration: 4000, delay: 0, value: 1f).Start();
            Imgbox2.Fade(duration: 4000, delay: 0, value: 1f).Start();
            Imgbox3.Fade(duration: 4000, delay: 0, value: 1f).Start();
            Imgbox4.Fade(duration: 4000, delay: 0, value: 1f).Start();
            Imgbox5.Fade(duration: 4000, delay: 0, value: 1f).Start();
            Imgbox6.Fade(duration: 4000, delay: 0, value: 1f).Start();
            Imgbox7.Fade(duration: 4000, delay: 0, value: 1f).Start();
            Imgbox8.Fade(duration: 4000, delay: 0, value: 1f).Start();
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
    }
}
