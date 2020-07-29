﻿using Prism.Regions;
using System.Windows;
using System.Windows.Controls;

namespace kiosk.Views.Sub4
{
    /// <summary>
    /// Sub02View.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SubView4_07 : UserControl
    {
        private IRegionManager regionManager;

        public SubView4_07(IRegionManager regionManager)
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
            regionManager.RequestNavigate("ContentRegion", nameof(SubView4_06));
        }

        public void NextBtnClick(object sender, RoutedEventArgs e)
        {
            regionManager.RequestNavigate("ContentRegion", nameof(SubView4_08));
        }
    }
}
