using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;

namespace WpfApp2.ViewModels
{
    public class TabViewModel : BindableBase 
    {
        private readonly IEventAggregator _eventAggregator;
        public DelegateCommand ShowDialogCommand { get; private set; }

        public TabViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            ShowDialogCommand = new DelegateCommand(ExecuteShowDialogCommand);
        }

        private void ExecuteShowDialogCommand()
        {
            _eventAggregator.GetEvent<ShowDialogEvent>().Publish();
        }
    }
}