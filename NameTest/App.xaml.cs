using System;
using System.Configuration;
using System.Data;
using System.Windows;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using NameTest.ViewModels;

namespace NameTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// サービスの登録
        /// </summary>
        public App()
        {
            Services = ConfigureServices();
            Ioc.Default.ConfigureServices(Services);
        }

        /// <summary>
        /// 現在の App インスタンスを使うために取得する
        /// </summary>
        public new static App Current => (App)Application.Current;

        /// <summary>
        /// サービスプロバイダ
        /// </summary>
        public IServiceProvider Services { get; }

        /// <summary>
        /// サービスをここで登録する
        /// </summary>
        /// <returns></returns>
        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // ViewModel
            services.AddSingleton<IMainWindowViewModel, MainWindowViewModel>();
            // ViewNmae の ViewModel を登録する
            services.AddSingleton<IViewNameViewModel, ViewNameViewModel>();
            return services.BuildServiceProvider();
        }
    }
}
