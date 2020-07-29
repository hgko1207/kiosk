using kiosk.Views;
using Prism.Ioc;
using Prism.Regions;
using System.Windows;

namespace kiosk
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();

            regionManager.RegisterViewWithRegion("ContentRegion", typeof(MainView));
        }
    }
}
