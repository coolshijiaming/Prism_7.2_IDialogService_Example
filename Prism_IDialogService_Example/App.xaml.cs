using Prism.Unity;
using System.Windows;
using Prism.Ioc;
using Prism_IDialogService_Example.ViewModels;
using Prism_IDialogService_Example.Views;

namespace Prism_IDialogService_Example
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell() => Container.Resolve<MainWindow>();

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<NewPaymentDialogView, NewPaymentDialogViewModel>();
        }
    }
}
