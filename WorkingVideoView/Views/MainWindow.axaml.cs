using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using WorkingVideoView.ViewModels;

namespace WorkingVideoView.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        
        private void OnOpened(object sender, EventArgs e)
        {
            var vm = DataContext as MainWindowViewModel;
            vm?.Play();
        }
    }
}