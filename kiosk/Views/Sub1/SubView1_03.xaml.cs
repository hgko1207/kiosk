using Prism.Regions;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace kiosk.Views.Sub1
{
    public partial class SubView1_03 : UserControl
    {
        private IRegionManager regionManager;

        private int selectedIndex;
        private List<string> pageList;

        private DispatcherTimer timer;

        public SubView1_03(IRegionManager regionManager)
        {
            InitializeComponent();
            this.regionManager = regionManager;

            pageList = new List<string>();
            for (int i = 1; i <= 6; i++)
            {
                pageList.Add("Page" + i);
            }
        }

        public void PreBtnClick(object sender, RoutedEventArgs e)
        {
            PrevMove();
        }

        public void NextBtnClick(object sender, RoutedEventArgs e)
        {
            NextMove();
        }

        private void PrevMove()
        {
            Init();

            --selectedIndex;
            if (selectedIndex < 0)
            {
                selectedIndex = pageList.Count - 1;
            }

            Storyboard storyboard = new Storyboard();
            ThicknessAnimation thicknessAnimationda = new ThicknessAnimation();
            thicknessAnimationda.From = new Thickness(-ContentControl.ActualWidth, 0, 0, 0);
            thicknessAnimationda.To = new Thickness(0);
            thicknessAnimationda.AccelerationRatio = 1;
            thicknessAnimationda.Duration = TimeSpan.FromSeconds(0.25);

            Storyboard.SetTargetProperty(thicknessAnimationda, new PropertyPath("Margin"));
            storyboard.Children.Add(thicknessAnimationda);
            ContentControl.BeginStoryboard(storyboard);

            ContentControl.ContentTemplate = (DataTemplate)FindResource(pageList[selectedIndex]);
        }

        private void NextMove()
        {
            Init();

            ++selectedIndex;
            if (selectedIndex > pageList.Count - 1)
            {
                selectedIndex = 0;
            }

            Storyboard storyboard = new Storyboard();
            ThicknessAnimation thicknessAnimationda = new ThicknessAnimation();
            thicknessAnimationda.From = new Thickness(ContentControl.ActualWidth + 100, 0, 0, 0);
            thicknessAnimationda.To = new Thickness(0);
            thicknessAnimationda.AccelerationRatio = 1;
            thicknessAnimationda.Duration = TimeSpan.FromSeconds(0.25);

            Storyboard.SetTargetProperty(thicknessAnimationda, new PropertyPath("Margin"));
            storyboard.Children.Add(thicknessAnimationda);
            ContentControl.BeginStoryboard(storyboard);

            ContentControl.ContentTemplate = (DataTemplate)FindResource(pageList[selectedIndex]);
        }

        private void TimerSetting()
        {
            timer = new DispatcherTimer();

            //얼마의 주기로 호출할 것인가?
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start(); //타이머 시작
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            NextMove();
        }

        public void Sub03ViewLoaded(object sender, RoutedEventArgs e)
        {
            selectedIndex = 0;
            ContentControl.ContentTemplate = (DataTemplate)FindResource("Page1");

            //TimerSetting();
        }

        public void Sub03ViewUnloaded(object sender, RoutedEventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                timer = null;
            }
        }

        public void HomeBtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(MainView));
        }

        public void PrevBtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(Sub1View));
        }

        private Point startPoint;

        public void PageMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //FrameworkElement element = sender as ContentControl;
            TranslateTransform translate = ContentControl.RenderTransform as TranslateTransform;

            startPoint = e.GetPosition(gridHost);
            ContentControl.CaptureMouse();
        }

        public void PageMouseMove(object sender, MouseEventArgs e)
        {
            TranslateTransform translate = ContentControl.RenderTransform as TranslateTransform;
            if (ContentControl.IsMouseCaptured)
            {
                if (timer != null)
                    timer.Stop();

                double maxSize = ContentControl.ActualWidth / 2;
                if (ContentControl.ActualWidth > 800)
                {
                    maxSize = 260;
                }
                else if (ContentControl.ActualWidth > 600)
                {
                    maxSize = 360;
                }

                if (translate.X < -maxSize - 50 || translate.X > maxSize + 50)
                    return;

                Vector offset = Point.Subtract(e.GetPosition(gridHost), startPoint);
                translate.X = offset.X;
                //translate.Y = startOffset.Y + offset.Y;
            }
        }

        public void PageMouseUpButtonDown(object sender, MouseButtonEventArgs e)
        {
            ContentControl.ReleaseMouseCapture();
            TranslateTransform translate = ContentControl.RenderTransform as TranslateTransform;
            double maxSize = ContentControl.ActualWidth / 2;
            if (ContentControl.ActualWidth > 800)
            {
                maxSize = 260;
            }
            else if (ContentControl.ActualWidth > 600)
            {
                maxSize = 360;
            }

            if (translate.X < -maxSize)
            {
                NextMove();
                if (timer != null)
                    timer.Start();
            }
            else if (translate.X > maxSize)
            {
                PrevMove();
                if (timer != null)
                    timer.Start();
            }
            else
            {
                translate.X = 0;
            }
        }

        private void Init()
        {
            TranslateTransform translate = ContentControl.RenderTransform as TranslateTransform;
            translate.X = 0;
        }
    }
}
