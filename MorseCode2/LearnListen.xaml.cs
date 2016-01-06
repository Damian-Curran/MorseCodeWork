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
    public sealed partial class LearnListen : Page
    {
        private int questionNumber;

        public LearnListen()
        {
            this.InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LearningPage), null);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string answer = AnswerBox.Text;
            int j;
            j = questionNumber;

            switch (answer)
            {
                case "a":
                case "A":
                    if (j == 0)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "b":
                case "B":
                    if (j == 1)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "c":
                case "C":
                    if (j == 2)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "d":
                case "D":
                    if (j == 3)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "e":
                case "E":
                    if (j == 4)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "f":
                case "F":
                    if (j == 5)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "g":
                case "G":
                    if (j == 6)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "h":
                case "H":
                    if (j == 7)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "i":
                case "I":
                    if (j == 8)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "j":
                case "J":
                    if (j == 9)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "k":
                case "K":
                    if (j == 10)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "l":
                case "L":
                    if (j == 11)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "m":
                case "M":
                    if (j == 12)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "n":
                case "N":
                    if (j == 13)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "o":
                case "O":
                    if (j == 14)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "p":
                case "P":
                    if (j == 15)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "q":
                case "Q":
                    if (j == 16)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "r":
                case "R":
                    if (j == 17)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "s":
                case "S":
                    if (j == 18)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "t":
                case "T":
                    if (j == 19)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "u":
                case "U":
                    if (j == 20)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "v":
                case "V":
                    if (j == 21)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "w":
                case "W":
                    if (j == 22)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "x":
                case "X":
                    if (j == 23)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "y":
                case "Y":
                    if (j == 24)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
                case "z":
                case "Z":
                    if (j == 25)
                    {
                        Correct.Text = "Correct";
                    }
                    else
                        Correct.Text = "Incorrect";
                    break;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int answer = questionNumber;

            switch (questionNumber)
            {
                case 0:
                    Answer.Text = "Answer is: a";
                    break;
                case 1:
                    Answer.Text = "Answer is: b";
                    break;
                case 2:
                    Answer.Text = "Answer is: c";
                    break;
                case 3:
                    Answer.Text = "Answer is: d";
                    break;
                case 4:
                    Answer.Text = "Answer is: e";
                    break;
                case 5:
                    Answer.Text = "Answer is: f";
                    break;
                case 6:
                    Answer.Text = "Answer is: g";
                    break;
                case 7:
                    Answer.Text = "Answer is: h";
                    break;
                case 8:
                    Answer.Text = "Answer is: i";
                    break;
                case 9:
                    Answer.Text = "Answer is: j";
                    break;
                case 10:
                    Answer.Text = "Answer is: k";
                    break;
                case 11:
                    Answer.Text = "Answer is: l";
                    break;
                case 12:
                    Answer.Text = "Answer is: m";
                    break;
                case 13:
                    Answer.Text = "Answer is: n";
                    break;
                case 14:
                    Answer.Text = "Answer is: o";
                    break;
                case 15:
                    Answer.Text = "Answer is: p";
                    break;
                case 16:
                    Answer.Text = "Answer is: q";
                    break;
                case 17:
                    Answer.Text = "Answer is: r";
                    break;
                case 18:
                    Answer.Text = "Answer is: s";
                    break;
                case 19:
                    Answer.Text = "Answer is: t";
                    break;
                case 20:
                    Answer.Text = "Answer is: u";
                    break;
                case 21:
                    Answer.Text = "Answer is: v";
                    break;
                case 22:
                    Answer.Text = "Answer is: w";
                    break;
                case 23:
                    Answer.Text = "Answer is: x";
                    break;
                case 24:
                    Answer.Text = "Answer is: y";
                    break;
                case 25:
                    Answer.Text = "Answer is: z";
                    break;
            }
        }

        public int randomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 25);

            return randomNumber;
        }

        private void Media1_MediaOpened(object sender, RoutedEventArgs e)
        {
            media1.Play();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            this.InitializeComponent();

            AnswerBox.Text = "";
            Answer.Text = "";
            Correct.Text = "";

            char image;

            questionNumber = randomNumber();

            switch (questionNumber)
            {
                case 0:
                    image = 'a';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 1:
                    image = 'b';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 2:
                    image = 'c';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 3:
                    image = 'd';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 4:
                    image = 'e';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 5:
                    image = 'f';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 6:
                    image = 'g';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 7:
                    image = 'h';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 8:
                    image = 'i';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 9:
                    image = 'j';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 10:
                    image = 'k';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 11:
                    image = 'l';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 12:
                    image = 'm';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 13:
                    image = 'n';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 14:
                    image = 'o';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 15:
                    image = 'p';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 16:
                    image = 'q';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 17:
                    image = 'r';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 18:
                    image = 's';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 19:
                    image = 't';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 20:
                    image = 'u';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 21:
                    image = 'v';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 22:
                    image = 'w';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 23:
                    image = 'x';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 24:
                    image = 'y';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
                case 25:
                    image = 'z';
                    media1.Source = new Uri("ms-appx:///MorseMP3/" + image + ".mp3", UriKind.Absolute);
                    break;
            }
        }
    }
}
