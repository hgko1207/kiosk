using kiosk.Views;
using kiosk.Views.Sub1;
using kiosk.Views.Sub2;
using kiosk.Views.Sub3;
using kiosk.Views.Sub4;
using Prism.Ioc;
using Prism.Unity;
using System.Windows;

namespace kiosk
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainView>();
            containerRegistry.RegisterForNavigation<Sub1View>();
            containerRegistry.RegisterForNavigation<Sub2View>();
            containerRegistry.RegisterForNavigation<Sub3View>();
            containerRegistry.RegisterForNavigation<Sub4View>();

            containerRegistry.RegisterForNavigation<SubView1_01>();
            containerRegistry.RegisterForNavigation<SubView1_02>();
            containerRegistry.RegisterForNavigation<SubView1_03>();
            containerRegistry.RegisterForNavigation<SubView1_04>();

            containerRegistry.RegisterForNavigation<SubView2_01_01>();
            containerRegistry.RegisterForNavigation<SubView2_01_02>();
            containerRegistry.RegisterForNavigation<SubView2_01_03>();
            containerRegistry.RegisterForNavigation<SubView2_02_01>();
            containerRegistry.RegisterForNavigation<SubView2_02_02>();
            containerRegistry.RegisterForNavigation<SubView2_02_03>();
            containerRegistry.RegisterForNavigation<SubView2_03_01>();
            containerRegistry.RegisterForNavigation<SubView2_03_02>();
            containerRegistry.RegisterForNavigation<SubView2_03_03>();
            containerRegistry.RegisterForNavigation<SubView2_04_01>();
            containerRegistry.RegisterForNavigation<SubView2_04_02>();
            containerRegistry.RegisterForNavigation<SubView2_04_03>();
            containerRegistry.RegisterForNavigation<SubView2_05_01>();
            containerRegistry.RegisterForNavigation<SubView2_05_02>();
            containerRegistry.RegisterForNavigation<SubView2_05_03>();
            containerRegistry.RegisterForNavigation<SubView2_06_01>();
            containerRegistry.RegisterForNavigation<SubView2_06_02>();
            containerRegistry.RegisterForNavigation<SubView2_06_03>();
            containerRegistry.RegisterForNavigation<SubView2_07_01>();
            containerRegistry.RegisterForNavigation<SubView2_07_02>();
            containerRegistry.RegisterForNavigation<SubView2_07_03>();
            containerRegistry.RegisterForNavigation<SubView2_08_01>();
            containerRegistry.RegisterForNavigation<SubView2_08_02>();
            containerRegistry.RegisterForNavigation<SubView2_08_03>();
            containerRegistry.RegisterForNavigation<SubView2_09_01>();
            containerRegistry.RegisterForNavigation<SubView2_09_02>();
            containerRegistry.RegisterForNavigation<SubView2_09_03>();

            containerRegistry.RegisterForNavigation<SubView3_01>();
            containerRegistry.RegisterForNavigation<SubView3_02>();
            containerRegistry.RegisterForNavigation<SubView3_03>();
            containerRegistry.RegisterForNavigation<SubView3_04>();
            containerRegistry.RegisterForNavigation<SubView3_05>();

            containerRegistry.RegisterForNavigation<SubView4_01>();
            containerRegistry.RegisterForNavigation<SubView4_02>();
            containerRegistry.RegisterForNavigation<SubView4_03>();
            containerRegistry.RegisterForNavigation<SubView4_04>();
            containerRegistry.RegisterForNavigation<SubView4_05>();
            containerRegistry.RegisterForNavigation<SubView4_06>();
            containerRegistry.RegisterForNavigation<SubView4_07>();
            containerRegistry.RegisterForNavigation<SubView4_08>();
            containerRegistry.RegisterForNavigation<SubView4_09>();
            containerRegistry.RegisterForNavigation<SubView4_10>();
            containerRegistry.RegisterForNavigation<SubView4_11>();
            containerRegistry.RegisterForNavigation<SubView4_12>();
        }
    }
}
