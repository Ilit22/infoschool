using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента пустой страницы см. по адресу http://go.microsoft.com/fwlink/?LinkID=390556

namespace InfoSchool
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class Register : Page
    {
        ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
        public Register()
        {
            this.InitializeComponent();

        }
        private void page_loaded(object sender, RoutedEventArgs e)
        {
            Frame.BackStack.Clear();
        }

        /// <summary>
        /// Вызывается перед отображением этой страницы во фрейме.
        /// </summary>
        /// <param name="e">Данные события, описывающие, каким образом была достигнута эта страница.
        /// Этот параметр обычно используется для настройки страницы.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void i_entered(object sender, PointerRoutedEventArgs e)
        {
            entered_school.Visibility = Visibility.Visible;
            localSettings.Values["i_is"] = (sender as ComboBoxItem).Tag;
        }

        private void school_entered(object sender, PointerRoutedEventArgs e)
        {
            classgrid.Visibility = Visibility.Visible;
            localSettings.Values["place_traning"] = (sender as ComboBoxItem).Tag;
        }

        private void Changeimg(object sender, TappedRoutedEventArgs e)
        {
            for (var i = 0; i < 24; i++)
            {
                if (((BitmapImage)((Image)classgrid.Children.ElementAt(i)).Source).UriSource != new Uri(((Image)sender).BaseUri, "Assets/енот лапа.png"))
                {
                    ((BitmapImage)((Image)classgrid.Children.ElementAt(i)).Source).UriSource = new Uri(((Image)sender).BaseUri, "Assets/енот лапа.png");
                }
            }
                ((BitmapImage)((Image)sender).Source).UriSource = new Uri(((Image)sender).BaseUri, "Assets/енот лапа зел.png");

            localSettings.Values["myclass"] = (string)((Image)sender).Tag;

            go.Visibility = Visibility.Visible;
        }

        private void go_Click(object sender, RoutedEventArgs e)
        {
            if (localSettings.Values["myclass"] != null)
            {
                Frame.Navigate(typeof(MainMenu));
            }
        }
    }
}
