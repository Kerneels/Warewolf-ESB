﻿using System.Net.Mime;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;
using Dev2.Common.Interfaces.PopupController;
using Dev2.Common.Interfaces.Studio.ViewModels.Dialogues;

namespace Warewolf.Studio.Views
{
    /// <summary>
    /// Interaction logic for DialogWindow.xaml
    /// </summary>
    public partial class DialogWindow : IActionDialogueWindow
    {
        public DialogWindow()
        {
            InitializeComponent();
            IsModal = true;
            
        }

        #region Implementation of IDialogueWindow

        public void ShowThis(IDialogueTemplate serverPopup)
        {
            DataContext = serverPopup;

          
            
            var blurEffect = new BlurEffect { Radius = 10 };
            //MediaTypeNames.Application.Current.MainWindow.Effect = blurEffect;
            var window = new Window { WindowStyle = WindowStyle.None, AllowsTransparency = true, Background = Brushes.Transparent, SizeToContent = SizeToContent.WidthAndHeight, ResizeMode = ResizeMode.NoResize, WindowStartupLocation = WindowStartupLocation.CenterScreen, Content = this };
            window.ShowDialog();
           
        }

        #endregion
    }
}
