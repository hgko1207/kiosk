using kiosk.Views.Sub2;
using Prism.Regions;
using System.Windows;
using System.Windows.Controls;

namespace kiosk.Views
{
    /// <summary>
    /// Sub2View.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Sub2View : UserControl
    {
        private IRegionManager regionManager;

        public Sub2View(IRegionManager regionManager)
        {
            InitializeComponent();
            this.regionManager = regionManager;
        }
        
        public void HomeBtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(MainView));
        }

        public void Sub1BtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView2_01_01));
        }

        public void Sub2BtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView2_02_01));
        }

        public void Sub3BtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView2_03_01));
        }

        public void Sub4BtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView2_04_01));
        }

        public void Sub5BtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView2_05_01));
        }

        public void Sub6BtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView2_06_01));
        }

        public void Sub7BtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView2_07_01));
        }

        public void Sub8BtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView2_08_01));
        }

        public void Sub9BtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView2_09_01));
        }

        private void StackPanel_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }
    }
}
