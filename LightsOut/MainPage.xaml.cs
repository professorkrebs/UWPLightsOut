using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LightsOut
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private SolidColorBrush offBrush = new SolidColorBrush(Color.FromArgb(255, 135, 94, 153));
        private SolidColorBrush onBrush = new SolidColorBrush(Color.FromArgb(255, 255, 0, 138));
        private bool isFlipped = false;
        public MainPage()
        {
            this.InitializeComponent();
            int rows = GameGrid.RowDefinitions.Count;
            int cols = GameGrid.ColumnDefinitions.Count;

            for(int row = 0; row < rows; row++)
            {
                for(int col = 0; col < cols; col++)
                {
                    Rectangle rect = new Rectangle();
                    rect.Fill = offBrush;
                    rect.Margin = new Thickness(2);

                    Grid.SetColumn(rect, col);
                    Grid.SetRow(rect, row);

                    GameGrid.Children.Add(rect);
                }
            }
        }

        #region Old Event Handlers
        //private async void ActivateButton_Click(object sender, RoutedEventArgs e)
        //{

        //    //var dialog = new MessageDialog("Activate was clicked!");
        //    //await dialog.ShowAsync();
        //    isFlipped = !isFlipped;

        //    Rect1.Fill = isFlipped ? offBrush : onBrush;
        //    Rect2.Fill = isFlipped ? onBrush : offBrush;

        //    //if(isFlipped)
        //    //{
        //    //    Rect1.Fill = orangeBrush;
        //    //    Rect2.Fill = blueBrush;
        //    //}
        //    //else
        //    //{
        //    //    Rect1.Fill = blueBrush;
        //    //    Rect2.Fill = orangeBrush;
        //    //}

        //}

        //private void Rect1_Tapped(object sender, TappedRoutedEventArgs e)
        //{
        //    Rect2.Fill = Rect1.Fill;
        //}

        //private void Rect2_Tapped(object sender, TappedRoutedEventArgs e)
        //{
        //    Rect1.Fill = Rect2.Fill;
        //}
        #endregion
    }
}
