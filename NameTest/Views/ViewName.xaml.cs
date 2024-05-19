using System.Windows;
using CommunityToolkit.Mvvm.DependencyInjection;
using NameTest.ViewModels;

namespace NameTest.Views
{
    /// <summary>
    /// ViewName.xaml の相互作用ロジック
    /// </summary>
    public partial class ViewName : Window
    {
        public ViewName()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetService<IViewNameViewModel>();
        }
    }
}
