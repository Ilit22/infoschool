using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента пустой страницы см. по адресу http://go.microsoft.com/fwlink/?LinkID=390556

namespace InfoSchool
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainMenu : Page
    {
        ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
        DispatcherTimer dtimer = new DispatcherTimer();
        DateTime dt;
        DateTime dt2;
        public MainMenu()
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

        private void stackpanel_loaded(object sender, RoutedEventArgs e)
        {
            cab.Text = localSettings.Values["myclass"].ToString();
        }

        private void back_view(object sender, PointerRoutedEventArgs e)
        {
            ((StackPanel)sender).Background = new SolidColorBrush(Color.FromArgb(10, 255, 255, 255));
        }
        private void back_view2(object sender, PointerRoutedEventArgs e)
        {
            ((StackPanel)sender).Background = new SolidColorBrush(Color.FromArgb(50, 0, 0, 0));
        }

        private void timel_loaded(object sender, RoutedEventArgs e)
        {
            dtimer = new DispatcherTimer();
            dtimer.Tick += dtimer_tick;
            dtimer.Interval = new TimeSpan(0, 0, 1);
            dtimer.Start();
        }
        void dtimer_tick(object sender, object e)
        {
            int res=14;
            dt = DateTime.Now;

            int[,] hms =
            {
                {8, 30, 1}, //1 
                {9, 15, 2},
                {9, 30, 1}, //2
                {10, 15, 2},
                {10, 35, 1}, //3
                {11, 20, 2},
                {11, 35, 1}, //4
                {12, 20, 2},
                {12, 30, 1}, //5
                {13, 15, 2},
                {13, 25, 1}, //6
                {14, 10, 2},
                {14, 30, 1}, //7
                {15, 15, 2},
                {24, 00, 2}
            };

            for (int i = 14; i >= 0; i--)
            {
                if (dt.Hour < hms[i, 0] || (dt.Hour == hms[i, 0] && dt.Minute < hms[i, 1]))
                {
                    res = i;
                }
            }
            dt2 = new DateTime(dt.Year, dt.Month, dt.Day, hms[res, 0], hms[res, 1], 00);
            if (res==14) {
                dt2 = new DateTime(dt2.Ticks + 3060000000);
            }


            var dt3 = new DateTime(dt2.Ticks - dt.Ticks);
            timel.Text = dt3.ToString("HH:mm:ss");
        }

        private void teachers_tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(TeacherChoice));
        }

        private void lessons_tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Lessons));
        }

        private void dishes_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Eating));
        }

        private void minigame_tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(MiniGame));
        }

        private void map_tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Map));
        }

        private void settings_tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Settings));
        }
    }
}
