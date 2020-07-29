using kiosk.Views.Sub1;
using Prism.Regions;
using System.Windows;
using System.Windows.Controls;

namespace kiosk.Views
{
    /// <summary>
    /// Sub1Page.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Sub1View : UserControl
    {
        private IRegionManager regionManager;

        public Sub1View(IRegionManager regionManager)
        {
            InitializeComponent();

            this.regionManager = regionManager;
        }

        public void Sub1Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView1_01));
        }

        public void Sub2Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView1_02));
        }

        public void Sub3Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView1_03));
        }

        public void Sub4Click(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView1_04));
        }

        public void HomeBtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(MainView));
        }
    }
}
