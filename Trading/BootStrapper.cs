using System.Windows;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Unity;

namespace Trading
{
    class BootStrapper : PrismBootstrapper
    {
        

        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }


        protected override void InitializeShell(DependencyObject shell)
        {
            base.InitializeShell(shell);
            App.Current.MainWindow = (Window)shell;
            App.Current.MainWindow.Show();

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //throw new System.NotImplementedException();
            
        }
    }
}
