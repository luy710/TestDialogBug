using Prism.Ioc;
using Prism.Unity;
using System.Windows;
using WpfApp2.Views;
//using Microsoft.Practices.Unity;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary> 
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<TabView>();
            containerRegistry.RegisterSingleton<ShowDialogEvent>();
        }
    }
}