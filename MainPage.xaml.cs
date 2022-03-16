using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace Wacky_Stories_Creator
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void SelectTheme(object sender, RoutedEventArgs e)
        {
            //TODO create drop down option list
        }

        private void CreateStories(object sender, RoutedEventArgs e)
        {
            //TODO create route to page to enter words in form fields
        }

        private void QuitApp(object sender, RoutedEventArgs e)
        {
            Window.Current.Close();
        }
    }
}
