using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Navigation;
using Microsoft.Win32;
using System.Media;

namespace nabrosok2
{
    /// <summary>
    /// Логика взаимодействия для Start.xaml
    /// </summary>
    public partial class Start : Window
    {
        public static MediaPlayer mediaPlayer = new MediaPlayer();
        int count = 0;
        public Start()
        {
            InitializeComponent();
            txt_1.Text = Convert.ToString( Player.Day);
           // OpenFileDialog openFileDialog = new OpenFileDialog();
           // openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
           
                mediaPlayer.Open(new Uri(System.IO.Directory.GetCurrentDirectory() + "/menu.mp3", UriKind.RelativeOrAbsolute));
                mediaPlayer.Play();
        }

        
     
        protected override void OnClosed(EventArgs e)
        {

            App.Current.Shutdown();
        }

        private void Media_Ended(object sender, EventArgs e)
        {
            mediaPlayer.Position = TimeSpan.Zero;
            mediaPlayer.Play();
        }
        private void PlaybackMusic()
        {
            mediaPlayer.Open(new Uri(System.IO.Directory.GetCurrentDirectory() + "/bgmusic.mp3", UriKind.RelativeOrAbsolute));

            mediaPlayer.MediaEnded += new EventHandler(Media_Ended);
            mediaPlayer.Play();
        }
        private void Grid_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            count++;
            Sprite first = new Sprite("/Start/1_titr_.png");
             Sprite second = new Sprite("/Start/2_titr_.png");
            Sprite thright = new Sprite("/Start/3_titr_.png");

            if (count == 1) Starts.Background = first.image;
            if (count == 2) Starts.Background = second.image;
             if (count == 3) Starts.Background = thright.image;
            if (count == 4)
            {
                PlaybackMusic();

                // string adress = "\\bgmusic.wav";
                // SoundPlayer sp = new SoundPlayer(new Uri(System.IO.Directory.GetCurrentDirectory() + adress, UriKind.RelativeOrAbsolute));


                //sp.Play();
                // sp.PlayLooping();

                Locations.Admin.Show();
                Locations.Admin.Visibility = Visibility.Hidden;
                Locations.map.Show();
                Locations.map.Visibility = Visibility.Hidden;
                Locations.location.Show();
                Locations.location.Visibility = Visibility.Hidden;
                Locations.car.Show();
                Locations.car.Visibility = Visibility.Hidden;
                Locations.camp.Show();
                
                Hide();
            }

        }
    }
}
