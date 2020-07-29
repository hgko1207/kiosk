using Prism.Regions;
using System.Windows;
using System.Windows.Controls;

namespace kiosk.Views.Sub2
{
    /// <summary>
    /// SubView2_01.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SubView2_04_02 : UserControl
    {
        private IRegionManager regionManager;

        public SubView2_04_02(IRegionManager regionManager)
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
            regionManager.RequestNavigate("ContentRegion", nameof(SubView2_05_01));
        }

        public void LeftBtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView2_04_01));
        }

        public void RightBtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView2_04_03));
        }
    }
}
