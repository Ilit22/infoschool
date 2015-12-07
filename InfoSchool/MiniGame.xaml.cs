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
        int row = 0, column = 0;
        int[,] field =
        {
            { 0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1 },
            { 1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1 },
            { 1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1 },
            { 1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1 },
            { 1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1 },
            { 1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1 },
            { 1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0,0,0 }
        };
        
        public DispatcherTimer my_timer;
        public string rotation = "stop"; //left, right, up, down


        public MiniGame()
        {
            this.InitializeComponent();

            my_timer = new DispatcherTimer();
            my_timer.Tick += TimerOnTick;
            my_timer.Interval = new TimeSpan(0, 0, 1);
            my_timer.Start();
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
            rotation = "up";
        }

        private void Left_Click(object sender, RoutedEventArgs e)
        {
            rotation = "left";
        }

        private void Right_Click(object sender, RoutedEventArgs e)
        {
            rotation = "right";
        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            rotation = "down";
        }

        private bool checking(int new_row, int new_column) {
            if (new_row>=0 & new_row<=16 && new_column>= 0 && new_column <= 16
                && field[new_row, new_column] == 0
                && field[new_row, new_column+1] == 0
                && field[new_row+1, new_column] == 0
                && field[new_row+1, new_column+1] == 0
            ) {
                row = new_row;
                Grid.SetRow(enot, row);
                column = new_column;
                Grid.SetColumn(enot, column);
                return true;
            }
            else {
                return false;
            }
        }

        private void TimerOnTick(object sender, object o)
        {
            int new_row = row;
            int new_column = column;
            if (rotation == "up")
            {
                new_row--;
            }
            else if (rotation == "left")
            {
                new_column--;
            }
            else if (rotation == "right")
            {
                new_column++;
            }
            else if (rotation == "down")
            {
                new_row++;
            }
            else {
                return;
            }

            if (new_row >= 0 & new_row <= 16 && new_column >= 0 && new_column <= 16
                && field[new_row, new_column] == 0
                && field[new_row, new_column + 1] == 0
                && field[new_row + 1, new_column] == 0
                && field[new_row + 1, new_column + 1] == 0
            )
            {
                row = new_row;
                Grid.SetRow(enot, row);
                column = new_column;
                Grid.SetColumn(enot, column);

            }

        }

    }
}
