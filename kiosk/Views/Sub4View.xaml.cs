using kiosk.Views.Sub4;
using Prism.Regions;
using System.Windows;
using System.Windows.Controls;

namespace kiosk.Views
{
    /// <summary>
    /// Sub4View.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Sub4View : UserControl
    {
        private IRegionManager regionManager;

        public Sub4View(IRegionManager regionManager)
        {
            InitializeComponent();
            this.regionManager = regionManager;
        }

        public void HomeBtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(MainView));
        }

        public void ImgBtn01Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView4_01));
        }

        public void ImgBtn02Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView4_02));
        }

        public void ImgBtn03Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView4_03));
        }

        public void ImgBtn04Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView4_04));
        }

        public void ImgBtn05Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView4_05));
        }

        public void ImgBtn06Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView4_06));
        }

        public void ImgBtn07Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView4_07));
        }

        public void ImgBtn08Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView4_08));
        }

        public void ImgBtn09Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView4_09));
        }

        public void ImgBtn10Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView4_10));
        }

        public void ImgBtn11Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView4_11));
        }

        public void ImgBtn12Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView4_12));
        }
    }
}
