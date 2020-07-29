using Prism.Regions;
using System.Windows;
using System.Windows.Controls;

namespace kiosk.Views.Sub4
{
    /// <summary>
    /// Sub01View.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SubView4_01 : UserControl
    {
        private IRegionManager regionManager;

        public SubView4_01(IRegionManager regionManager)
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
            regionManager.RequestNavigate("ContentRegion", nameof(Sub4View));
        }

        public void NextBtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView4_02));
        }
    }
}
