using Prism.Regions;
using System.Windows;
using System.Windows.Controls;

namespace kiosk.Views.Sub2
{
    /// <summary>
    /// SubView2_01.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SubView2_07_01 : UserControl
    {
        private IRegionManager regionManager;

        public SubView2_07_01(IRegionManager regionManager)
        {
            InitializeComponent();
            this.regionManager = regionManager;
        }

        public void HomeBtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(MainView));
        }

        public void PrevBtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(Sub2View));
        }

        public void NextBtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView2_08_01));
        }

        public void RightBtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView2_07_02));
        }
    }
}
