using Prism.Regions;
using System.Windows;
using System.Windows.Controls;

namespace kiosk.Views
{
    /// <summary>
    /// MainPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainView : UserControl
    {
        private IRegionManager regionManager;

        public MainView(IRegionManager regionManager)
        {
            InitializeComponent();

            this.regionManager = regionManager;
        }

        public void Sub1Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(Sub1View));
        }

        public void Sub2Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(Sub2View));
        }

        public void Sub3Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(Sub3View));
        }

        public void Sub4Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(Sub4View));
        }
    }
}
