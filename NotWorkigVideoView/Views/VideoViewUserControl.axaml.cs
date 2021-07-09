using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using NotWorkigVideoView.ViewModels;

namespace NotWorkigVideoView.Views
{
    public class VideoViewUserControl : UserControl
    {
        public VideoViewUserControl()
        {
            InitializeComponent();
            this.DataContext = new VideoViewUserControlViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void StyledElement_OnInitialized(object? sender, EventArgs e)
        {
            var vm = DataContext as VideoViewUserControlViewModel;
            vm?.Play();
        }
    }
}