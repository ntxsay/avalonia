using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using NotWorkigVideoView.ViewModels;
using NotWorkigVideoView.Views;

namespace NotWorkigVideoView
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                };
                desktop.Exit += OnExit;
            }

            base.OnFrameworkInitializationCompleted();
        }
        
        void OnExit(object sender, ControlledApplicationLifetimeExitEventArgs e)
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                if (desktop.MainWindow.Content is VideoViewUserControl userControl && userControl.DataContext is VideoViewUserControlViewModel vm)
                {
                    vm.Dispose();
                    
                }
            }
        }
    }
}