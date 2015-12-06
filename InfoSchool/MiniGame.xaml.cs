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

// Документацию по шаблону элемента пустой страницы см. по адресу http://go.microsoft.com/fwlink/?LinkID=390556


// 18 * 16 = 288


namespace InfoSchool
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MiniGame : Page
    {
        public MiniGame()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Вызывается перед отображением этой страницы во фрейме.
        /// </summary>
        /// <param name="e">Данные события, описывающие, каким образом была достигнута эта страница.
        /// Этот параметр обычно используется для настройки страницы.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            int row = Grid.GetRow(enot) - 1;
            if (row > 0)
            {
                Grid.SetRow(enot, row);
            }
        }

        private void Left_Click(object sender, RoutedEventArgs e)
        {
            int column = Grid.GetColumn(enot) - 1;
            if (column > 0)
            {
                Grid.SetColumn(enot, column);
            }
        }

        private void Right_Click(object sender, RoutedEventArgs e)
        {
            int column = Grid.GetColumn(enot) + 1;
            if (column <= 16)
            {
                Grid.SetColumn(enot, column);
            }
        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            int row = Grid.GetRow(enot) + 1;
            if (row <= 16)
            {
                Grid.SetRow(enot, row);
            }
        }


    }
}
