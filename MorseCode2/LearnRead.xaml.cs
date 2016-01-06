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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MorseCode
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LearnRead : Page
    {
        private int questionNumber;

        public LearnRead()
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
            this._contentLoaded = false;
            InitializeComponent();
        }

        public int randomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 25);

            return randomNumber;
        }

        public void Image_Loaded(object sender, RoutedEventArgs e)
        {
            this.InitializeComponent();

            char image;

            questionNumber = randomNumber();

            switch (questionNumber)
            {
                case 0:
                    image = 'a';
                    Image imggg = sender as Image;
                    if (imggg != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imggg.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imggg.Source = bitmapImage;
                    }
                    break;
                case 1:
                    image = 'b';
                    Image imgq = sender as Image;
                    if (imgq != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imgq.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imgq.Source = bitmapImage;
                    }
                    break;
                case 2:
                    image = 'c';
                    Image imgw = sender as Image;
                    if (imgw != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imgw.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imgw.Source = bitmapImage;
                    }
                    break;
                case 3:
                    image = 'd';
                    Image imge = sender as Image;
                    if (imge != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imge.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imge.Source = bitmapImage;
                    }
                    break;
                case 4:
                    image = 'e';
                    Image imgr = sender as Image;
                    if (imgr != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imgr.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imgr.Source = bitmapImage;
                    }
                    break;
                case 5:
                    image = 'f';
                    Image imgt = sender as Image;
                    if (imgt != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imgt.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imgt.Source = bitmapImage;
                    }
                    break;
                case 6:
                    image = 'g';
                    Image imgy = sender as Image;
                    if (imgy != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imgy.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imgy.Source = bitmapImage;
                    }
                    break;
                case 7:
                    image = 'h';
                    Image imgu = sender as Image;
                    if (imgu != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imgu.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imgu.Source = bitmapImage;
                    }
                    break;
                case 8:
                    image = 'i';
                    Image imgi = sender as Image;
                    if (imgi != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imgi.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imgi.Source = bitmapImage;
                    }
                    break;
                case 9:
                    image = 'j';
                    Image imgo = sender as Image;
                    if (imgo != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imgo.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imgo.Source = bitmapImage;
                    }
                    break;
                case 10:
                    image = 'k';
                    Image imgp = sender as Image;
                    if (imgp != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imgp.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imgp.Source = bitmapImage;
                    }
                    break;
                case 11:
                    image = 'l';
                    Image imga = sender as Image;
                    if (imga != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imga.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imga.Source = bitmapImage;
                    }
                    break;
                case 12:
                    image = 'm';
                    Image imgs = sender as Image;
                    if (imgs != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imgs.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imgs.Source = bitmapImage;
                    }
                    break;
                case 13:
                    image = 'n';
                    Image imgd = sender as Image;
                    if (imgd != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imgd.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imgd.Source = bitmapImage;
                    }
                    break;
                case 14:
                    image = 'o';
                    Image imgf = sender as Image;
                    if (imgf != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imgf.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imgf.Source = bitmapImage;
                    }
                    break;
                case 15:
                    image = 'p';
                    Image imgh = sender as Image;
                    if (imgh != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imgh.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imgh.Source = bitmapImage;
                    }
                    break;
                case 16:
                    image = 'q';
                    Image imgj = sender as Image;
                    if (imgj != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imgj.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imgj.Source = bitmapImage;
                    }
                    break;
                case 17:
                    image = 'r';
                    Image imgk = sender as Image;
                    if (imgk != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imgk.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imgk.Source = bitmapImage;
                    }
                    break;
                case 18:
                    image = 's';
                    Image imgl = sender as Image;
                    if (imgl != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imgl.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imgl.Source = bitmapImage;
                    }
                    break;
                case 19:
                    image = 't';
                    Image imgz = sender as Image;
                    if (imgz != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imgz.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imgz.Source = bitmapImage;
                    }
                    break;
                case 20:
                    image = 'u';
                    Image imgx = sender as Image;
                    if (imgx != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imgx.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imgx.Source = bitmapImage;
                    }
                    break;
                case 21:
                    image = 'v';
                    Image imgc = sender as Image;
                    if (imgc != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imgc.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imgc.Source = bitmapImage;
                    }
                    break;
                case 22:
                    image = 'w';
                    Image imgv = sender as Image;
                    if (imgv != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imgv.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imgv.Source = bitmapImage;
                    }
                    break;
                case 23:
                    image = 'x';
                    Image imgb = sender as Image;
                    if (imgb != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imgb.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imgb.Source = bitmapImage;
                    }
                    break;
                case 24:
                    image = 'y';
                    Image imgg = sender as Image;
                    if (imgg != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        imgg.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        imgg.Source = bitmapImage;
                    }
                    break;
                case 25:
                    image = 'z';
                    Image img = sender as Image;
                    if (img != null)
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        img.Width = bitmapImage.DecodePixelWidth = 280;
                        bitmapImage.UriSource = new Uri("ms-appx:///MorseLetters/" + image + ".jpg");
                        img.Source = bitmapImage;
                    }
                    break;
            }
        }

    }
}
