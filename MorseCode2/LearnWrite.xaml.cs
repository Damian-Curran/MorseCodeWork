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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MorseCode
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LearnWrite : Page
    {
        private string morseCode;

        public LearnWrite()
        {
            this.InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LearningPage), null);
        }

        private void ButtonTapd(object sender, RoutedEventArgs e)
        {
            this.InitializeComponent();
            morseCode += "1";
            Dot.Play();
        }

        private void ButtonHeldd(object sender, RoutedEventArgs e)
        {
            this.InitializeComponent();
            morseCode += "2";
            Dash.Play();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string morse = morseCode;

            switch (morse)
            {
                case "12":
                    Answer.Text = "You entered: a";
                    break;
                case "2111":
                    Answer.Text = "You entered: b";
                    break;
                case "2121":
                    Answer.Text = "You entered: c";
                    break;
                case "211":
                    Answer.Text = "You entered: d";
                    break;
                case "1":
                    Answer.Text = "You entered: e";
                    break;
                case "1121":
                    Answer.Text = "You entered: f";
                    break;
                case "221":
                    Answer.Text = "You entered: g";
                    break;
                case "1111":
                    Answer.Text = "You entered: h";
                    break;
                case "11":
                    Answer.Text = "You entered: i";
                    break;
                case "1222":
                    Answer.Text = "You entered: j";
                    break;
                case "212":
                    Answer.Text = "You entered: k";
                    break;
                case "1211":
                    Answer.Text = "You entered: l";
                    break;
                case "22":
                    Answer.Text = "You entered: m";
                    break;
                case "21":
                    Answer.Text = "You entered: n";
                    break;
                case "222":
                    Answer.Text = "You entered: o";
                    break;
                case "1221":
                    Answer.Text = "You entered: p";
                    break;
                case "2212":
                    Answer.Text = "You entered: q";
                    break;
                case "121":
                    Answer.Text = "You entered: r";
                    break;
                case "111":
                    Answer.Text = "You entered: s";
                    break;
                case "2":
                    Answer.Text = "You entered: t";
                    break;
                case "112":
                    Answer.Text = "You entered: u";
                    break;
                case "1112":
                    Answer.Text = "You entered: v";
                    break;
                case "122":
                    Answer.Text = "You entered: w";
                    break;
                case "2112":
                    Answer.Text = "You entered: x";
                    break;
                case "2122":
                    Answer.Text = "You entered: y";
                    break;
                case "2211":
                    Answer.Text = "You entered: z";
                    break;
                default:
                    Answer.Text = "Invalid entry, press reset and try again";
                    break;
            }
        }

        private void Resett(object sender, RoutedEventArgs e)
        {
            morseCode = "";
            Answer.Text = "";
        }

    }
}
