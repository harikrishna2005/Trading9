using System.Windows;
using BotV1;
using Prism.Ioc;
using Prism.Modularity;
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

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);

            var botModule = typeof(BotV1Module);
            var moduleInfo = new ModuleInfo() { ModuleName = botModule.Name,
                ModuleType = botModule.AssemblyQualifiedName,
                InitializationMode = InitializationMode.WhenAvailable
            };
            moduleCatalog.AddModule(moduleInfo);

        }
    }
}
