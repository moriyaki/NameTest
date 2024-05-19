using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NameTest.Views;

namespace NameTest.ViewModels
{
    public interface IMainWindowViewModel
    {
        public string Name { get; set; }
    }

    public class MainWindowViewModel : ObservableObject, IMainWindowViewModel
    {
        public RelayCommand NameCommand { get; set; }

        public MainWindowViewModel()
        {
            NameCommand = new RelayCommand(
                () =>
                {
                    var viewNameWindow = new Views.ViewName();
                    viewNameWindow.Show();
                },
                () => !string.IsNullOrEmpty(_name)
            );
        }

        private string _name = string.Empty;
        public string Name
        {
            get => _name;
            set
            {
                SetProperty(ref _name, value);
                NameCommand.NotifyCanExecuteChanged();
            }
        }
    }
}
