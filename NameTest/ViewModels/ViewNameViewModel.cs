using CommunityToolkit.Mvvm.ComponentModel;

namespace NameTest.ViewModels
{
    interface IViewNameViewModel;

    public class ViewNameViewModel : ObservableObject, IViewNameViewModel
    {
        private string _name = string.Empty;
        public string Name
        {
            get => _name;
            set
            {
                SetProperty(ref _name, value);
                _mainWindowViewModel.Name = value;
            }
        }

        // コンストラクタインジェクションで注入された ViewModel を保持する
        private readonly IMainWindowViewModel _mainWindowViewModel;

        // コンストラクタインジェクションを行っている
        public ViewNameViewModel(IMainWindowViewModel mainWindowViewModel)
        {
            _mainWindowViewModel = mainWindowViewModel;
            Name = _mainWindowViewModel.Name;
        }
    }
}
