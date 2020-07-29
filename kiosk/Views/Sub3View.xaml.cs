using kiosk.Views.Sub3;
using Prism.Regions;
using System.Windows;
using System.Windows.Controls;

namespace kiosk.Views
{
    /// <summary>
    /// Sub3View.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Sub3View : UserControl
    {
        private IRegionManager regionManager;

        public Sub3View(IRegionManager regionManager)
        {
            InitializeComponent();
            this.regionManager = regionManager;
        }

        public void HomeBtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(MainView));
        }

        public void VideoBtn01Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView3_01));
        }

        public void VideoBtn02Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView3_02));
        }

        public void VideoBtn03Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView3_03));
        }

        public void VideoBtn04Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView3_04));
        }

        public void VideoBtn05Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView3_05));
        }
    }
}
