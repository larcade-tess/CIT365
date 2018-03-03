using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GlazerCalcTessLarcade
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public enum ItemCollection
        {
            Black = 1,
            Blue = 2,
            Brown = 3
        };

        public MainPage()
        {
            this.InitializeComponent();
            List<ItemCollection> ItemCollectionList = Enum.GetValues(typeof(ItemCollection)).Cast<ItemCollection>().ToList();
            tint.ItemsSource = ItemCollectionList;
        }

        //    Console.WriteLine( "The length of the wood is " +
        // woodLength + " feet" ) ;
        // Console.WriteLine( "The area of the glass is " +
        // glassArea + " square metres" ) ;


        private async void KeyUpWidth(object sender, KeyRoutedEventArgs e)
        {
            if ((e.Key == VirtualKey.Number1) || (e.Key == VirtualKey.Number2) || (e.Key == VirtualKey.Number3)
                || (e.Key == VirtualKey.Number4) || (e.Key == VirtualKey.Number5) || (e.Key == VirtualKey.Number6)
                || (e.Key == VirtualKey.Number7) || (e.Key == VirtualKey.Number8) || (e.Key == VirtualKey.Number9)
                || (e.Key == VirtualKey.Number0) || (e.Key == VirtualKey.NumberPad1) || (e.Key == VirtualKey.NumberPad2)
                || (e.Key == VirtualKey.NumberPad3) || (e.Key == VirtualKey.NumberPad4) || (e.Key == VirtualKey.NumberPad5)
                || (e.Key == VirtualKey.Number6) || (e.Key == VirtualKey.NumberPad7) || (e.Key == VirtualKey.NumberPad8)
                || (e.Key == VirtualKey.NumberPad9) || (e.Key == VirtualKey.NumberPad0) || (e.Key == VirtualKey.Decimal))
            {
                e.Handled = true;
            }
            else
            {
                width.Text = String.Empty;
                var dialog = new MessageDialog("Please enter a digit");
                await dialog.ShowAsync();
            }
        }
        private async void KeyUpHeight(object sender, KeyRoutedEventArgs e)
        {
            if ((e.Key == VirtualKey.Number1) || (e.Key == VirtualKey.Number2) || (e.Key == VirtualKey.Number3)
                || (e.Key == VirtualKey.Number4) || (e.Key == VirtualKey.Number5) || (e.Key == VirtualKey.Number6)
                || (e.Key == VirtualKey.Number7) || (e.Key == VirtualKey.Number8) || (e.Key == VirtualKey.Number9)
                || (e.Key == VirtualKey.Number0) || (e.Key == VirtualKey.NumberPad1) || (e.Key == VirtualKey.NumberPad2)
                || (e.Key == VirtualKey.NumberPad3) || (e.Key == VirtualKey.NumberPad4) || (e.Key == VirtualKey.NumberPad5)
                || (e.Key == VirtualKey.Number6) || (e.Key == VirtualKey.NumberPad7) || (e.Key == VirtualKey.NumberPad8)
                || (e.Key == VirtualKey.NumberPad9) || (e.Key == VirtualKey.NumberPad0) || (e.Key == VirtualKey.Decimal))
            {
                e.Handled = true;
            }
            else
            {
                height.Text = String.Empty;
                var dialog = new MessageDialog("Please enter a digit");
                await dialog.ShowAsync();
                e.Handled = false;
            }
        }

        private void SliderValue(object sender, RangeBaseValueChangedEventArgs e)
        {
            string msg = String.Format("Current value: {0}", e.NewValue);
            this.slider.Text = msg;
        }



        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            const double MAX_WIDTH = 5.0;
            const double MIN_WIDTH = 0.5;
            double w = Double.Parse(width.Text);
            string message = "Error: Width needs to be between " + MIN_WIDTH + " and " + MAX_WIDTH;
            try
            {
                if (w <= MAX_WIDTH && w >= MIN_WIDTH)
                {
                    
                }
                else
                {
                    // Show message box
                    width.Text = String.Empty;
                    var dialog = new MessageDialog(message);
                    await dialog.ShowAsync();
                }
            }
            catch (Exception ex)
            {
                var dialog = new MessageDialog(ex.Message);
                await dialog.ShowAsync();
                throw;

            }

            const double MAX_HEIGHT = 3.0;
            const double MIN_HEIGHT = 0.75;
            double h = Convert.ToDouble(height.Text);
            string message2 = "Error: Height needs to be between " + MIN_HEIGHT + " and " + MAX_HEIGHT;
            try
            {

                if (h <= MAX_HEIGHT && h >= MIN_HEIGHT)
                {
                    
                }
                else
                {
                    // Show message box
                    height.Text = String.Empty;
                    var dialog = new MessageDialog(message2);
                    await dialog.ShowAsync();
                }
            }
            catch (Exception ex)
            {
                var dialog = new MessageDialog(ex.Message);
                await dialog.ShowAsync();
                throw;

            }

            w = Double.Parse(width.Text);
            h = Double.Parse(height.Text);
            double s = slide.Value;
            var woodL = ((2 * (w + h) * 3.25) * s);
            var glassA = ((2 * (w + h)) * s);


            width_input.Text = width.Text;
            height_input.Text = height.Text;
            CalcLength.Text = Convert.ToString(woodL) + " Feet";
            CalcArea.Text = Convert.ToString(glassA) + " Square Metres";
            date.Text = DateTime.Now.Date.ToString("MM, dd, yyyy");
        }
    }
}
