using MaterialDesignThemes.Wpf;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;

namespace WpfApp2
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly IRegionManager _regionManager;

        public DelegateCommand OpenTabCommand { get; private set; }

        public MainWindowViewModel(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            _regionManager = regionManager;
            _eventAggregator = eventAggregator;
            OpenTabCommand = new DelegateCommand(ExecuteOpenTabCommand);

            _eventAggregator.GetEvent<ShowDialogEvent>().Subscribe(ShowDialog);
        }

        private void ExecuteOpenTabCommand()
        {
            var parameters = new NavigationParameters();
            _regionManager.RequestNavigate("ContentRegion", "TabView", parameters);
        }

        private  void ShowDialog()
        {
             DialogHost.Show(new object(), "RootDialogHostIdentifier");
            var a = 1;
        }
    }
}
