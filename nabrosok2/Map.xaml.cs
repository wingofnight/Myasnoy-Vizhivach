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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace nabrosok2
{
    /// <summary>
    /// Логика взаимодействия для Map.xaml
    /// </summary>
    public partial class Map : Window
    {   public int colodeCount = 6;
        public List<cards> Dump = new List<cards>();
        public cards[] hand = new cards[2];
        //public List<cards> ColodeCard = new List<cards>();
        public Item arrow = new Item(0, 0, 0, "/image/Arrow_sprite.png");
        public List<Sprite> capses = new List<Sprite>(19);
        public int adress = 0;
        public Map()
        {
            InitializeComponent();

            instalColodeCount();
            writeShopText("Набирай карты!");
            DropShadowEffect effect = new DropShadowEffect();
            effect.BlurRadius = 2;
            effect.Color = Colors.Cyan;
            effect.ShadowDepth = 3;
            effect.Direction = 220;

            Calode0.Effect = effect;
            Calode1.Effect = effect;
            Calode2.Effect = effect;
            Calode3.Effect = effect;
            Calode4.Effect = effect;
            Calode5.Effect = effect;
            //Card_1.Fill = Brushes.White;
            Card_1.IsEnabled = false;
            Card_2.IsEnabled = false;
            rct_arrow.Fill = arrow.Begin.image;
            rct_arrow.IsEnabled = false;
            rct_arrow.Visibility = Visibility.Hidden;
            double x = -0.008;
            double y = 0.006;
            for (int i = 1; i <= 20; i++)
            {
               
                Sprite sprite = new Sprite(x,y,0.12,0.15,"/image/sprite_caps.png");
                capses.Add(sprite);
               //x += 0.01;
                y += 0.158;
                if (i % 5 == 0)
                {
                    x += 0.115;
                    y = 0.006;
                }

            }
           
            Sprite calode = new Sprite("/cart_instance/card_face_4.png");
            Calode0.Fill = calode.image;
            Calode1.Fill = calode.image;
            Calode2.Fill = calode.image;
            Calode3.Fill = calode.image;
            Calode4.Fill = calode.image;
            Calode5.Fill = calode.image;
           
            rct_caps0.Fill = capses[0].image;
            rct_caps1.Fill = capses[1].image;
            rct_caps2.Fill = capses[2].image;
            rct_caps3.Fill = capses[3].image;
            rct_caps4.Fill = capses[4].image;
            rct_caps5.Fill = capses[5].image;
            rct_caps6.Fill = capses[6].image;
            rct_caps7.Fill = capses[7].image;
            rct_caps8.Fill = capses[8].image;
            rct_caps9.Fill = capses[9].image;
            
            rct_caps11.Fill = capses[10].image;
            rct_caps12.Fill = capses[11].image;
            rct_caps13.Fill = capses[12].image;
            rct_caps14.Fill = capses[13].image;
            rct_caps15.Fill = capses[14].image;
            rct_caps16.Fill = capses[15].image;
            rct_caps17.Fill = capses[16].image;
            rct_caps18.Fill = capses[17].image;
            rct_caps19.Fill = capses[18].image;

            Sprite sprite_center = new Sprite(0, 0.798, 0.16, 0.2, "/image/sprite_caps.png");
            rct_caps10_center.Fill = sprite_center.image;

        }

        public void vipe()
        {
            DropShadowEffect effect2 = new DropShadowEffect();
            effect2.BlurRadius = 0;
            effect2.Color = Colors.Black;
            effect2.ShadowDepth = 0;
            effect2.Direction = 220;
            rct_caps0.Effect = effect2;
            rct_caps1.Effect = effect2;
            rct_caps2.Effect = effect2;
            rct_caps3.Effect = effect2;
            rct_caps4.Effect = effect2;
            rct_caps5.Effect = effect2;
            rct_caps6.Effect = effect2;
            rct_caps7.Effect = effect2;
            rct_caps8.Effect = effect2;
            rct_caps9.Effect = effect2;
            rct_caps10_center.Effect = effect2;
            rct_caps11.Effect = effect2;
            rct_caps12.Effect = effect2;
            rct_caps13.Effect = effect2;
            rct_caps14.Effect = effect2;
            rct_caps15.Effect = effect2;
            rct_caps16.Effect = effect2;
            rct_caps17.Effect = effect2;
            rct_caps18.Effect = effect2;
            rct_caps19.Effect = effect2;
          }

        public void neon(cards x)
        {
            switch (x.ID)
            {
                case 0:
                    vipe();
                    rct_caps5.Effect = x.effect;
                    break;
                case 1:
                    vipe();
                    rct_caps3.Effect = x.effect;
                    break;
                case 2:
                    vipe();
                    rct_caps12.Effect = x.effect;
                    break;
                case 3:
                    vipe();
                    rct_caps14.Effect = x.effect;
                    break;
                case 4:
                    vipe(); 
                    rct_caps0.Effect = x.effect;
                    break;
                case 5:
                    vipe();
                    rct_caps19.Effect = x.effect;
                    break;
                case 6:
                    vipe();
                    rct_caps18.Effect = x.effect;
                    break;
                case 7:
                    vipe();
                    rct_caps16.Effect = x.effect;
                    break;
                case 8:
                    vipe();
                    rct_caps15.Effect = x.effect;
                    break;
                case 9:
                    vipe();
                    rct_caps17.Effect = x.effect;
                    break;
                case 10:
                    vipe();
                    rct_caps6.Effect = x.effect;
                    break;
                case 11:
                    vipe();
                    rct_caps13.Effect = x.effect;
                    break;
                case 12:
                    vipe();
                    rct_caps7.Effect = x.effect;
                    break;
                case 13:
                    vipe();
                    rct_caps1.Effect = x.effect;
                    break;    
                case 14:
                    vipe();
                    rct_caps8.Effect = x.effect;
                    break;
                case 15:    
                    vipe();
                    rct_caps4.Effect = x.effect;
                    break;
                case 16:
                    vipe();
                    rct_caps11.Effect = x.effect;
                    break;
                case 17:
                    vipe();
                    rct_caps2.Effect = x.effect;
                    break;
                case 18:    
                    vipe();
                    rct_caps9.Effect = x.effect;
                    break;
               
                   
                default:
                    break;
            }
        }
        private void Media_Ended(object sender, EventArgs e)
        {
            Start.mediaPlayer.Position = TimeSpan.Zero;
            Start.mediaPlayer.Play();
        }
        public void instalColodeCount()
        {
            if (InicializeCarad.cardList.Count >= 6)
            {
                colodeCount = 6;
            }else
            {
                colodeCount = InicializeCarad.cardList.Count;
            }

            if (colodeCount >= 0)//обрати внимание
            {
                Calode0.Visibility = Visibility.Visible;
            }
            if (colodeCount >= 1)
            {
                Calode1.Visibility = Visibility.Visible;
            }
            if (colodeCount >= 2)
            {
                Calode2.Visibility = Visibility.Visible;
            }
            if (colodeCount >= 3)
            {
                Calode3.Visibility = Visibility.Visible;
            }
            if (colodeCount >= 4)
            {
                Calode4.Visibility = Visibility.Visible;
            }
            if (colodeCount >= 5)
            {
                Calode5.Visibility = Visibility.Visible;
            }
        }

        private async void writeShopText(string text)
        {
            txtBl_map_yellow.Text = text;
            Canvas.SetZIndex(txtBl_map_yellow, 3);
        }

        private void writeClear()
        {
            txtBl_map_yellow.Text = "";
            Canvas.SetZIndex(txtBl_map_yellow, 0);
        }
//===========================
        private void Card_1_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            neon(hand[0]);
            DropShadowEffect effectCard = new DropShadowEffect();
            
            effectCard.BlurRadius = 3;
            effectCard.Color = Colors.Pink;
            effectCard.ShadowDepth = 4;
            effectCard.Direction = 220;
            DropShadowEffect effectCard2 = new DropShadowEffect();
            effectCard2.BlurRadius = 3;
            
            effectCard2.ShadowDepth = 4;
            effectCard2.Direction = 220;
            Card_1.Effect = effectCard;
            effectCard2.Color = Colors.GreenYellow;
            Card_2.Effect = effectCard2;
            writeShopText("Ну чё? пошли?");
            rct_arrow.IsEnabled = true;
            rct_arrow.Visibility = Visibility.Visible;
            adress = hand[0].ID;
            Locations.location.currentCart = hand[0];
           
        }
        private void Card_2_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            neon(hand[1]);
            DropShadowEffect effectCard = new DropShadowEffect();
           
            effectCard.Color = Colors.Pink;
            effectCard.ShadowDepth = 4;
            effectCard.Direction = 220;
            DropShadowEffect effectCard2 = new DropShadowEffect();
            effectCard2.BlurRadius = 3;
            
            effectCard2.ShadowDepth = 4;
            effectCard2.Direction = 220;
            Card_2.Effect = effectCard;
            effectCard2.Color = Colors.GreenYellow;
            Card_1.Effect = effectCard2;
            writeShopText("Ну чё? пошли?");
            rct_arrow.IsEnabled = true;
            rct_arrow.Visibility = Visibility.Visible;
            adress = hand[1].ID;
            Locations.location.currentCart = hand[1];
           
        }
        //=======================стрелка========================

        private void rct_arrow_MouseEnter(object sender, MouseEventArgs e)
        {
            rct_arrow.Fill = arrow.Enter.image;
        }

        private void rct_arrow_MouseLeave(object sender, MouseEventArgs e)
        {
            rct_arrow.Fill = arrow.Begin.image;
        }

        private void rct_arrow_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            rct_arrow.Fill = arrow.Click.image;
        }

        private void rct_arrow_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
           
            rct_arrow.Fill = arrow.Begin.image;
            Locations.location.Visibility = Visibility.Visible;
            Locations.location.LocationBackground.Background = InitializeInstance.instances[adress].bacground.image;
            //  Locations.location.writeText(InitializeInstance.instances[adress].firstReaction);
            Locations.location.writeClear();
            Locations.location.ID = InitializeInstance.instances[adress].ID;
            Locations.location.writeText(InitializeInstance.instances[adress].instalReaction());
            Locations.location.invetory_drow();
            this.Visibility = Visibility.Collapsed;
            
        }

      

        protected override void OnClosed(EventArgs e)
        {

            App.Current.Shutdown();
        }

        private void Calode_MouseEnter(object sender, MouseEventArgs e)
        {
           
        }

        private void Calode_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            DropShadowEffect effectCard = new DropShadowEffect();
            effectCard.BlurRadius = 3;
            effectCard.Color = Colors.GreenYellow;
            effectCard.ShadowDepth = 4;
            effectCard.Direction = 220;

            Card_1.Effect = effectCard;
            Card_2.Effect = effectCard;
            writeShopText("Выбери карту!");
            Card_1.IsEnabled = true;
            Card_2.IsEnabled = true;
            Random rand1 = new Random();
            int x = 0;
            if (InicializeCarad.cardList.Count > 0)
            {
               x  = rand1.Next(InicializeCarad.cardList.Count);
            }
           
            //========================================================
            if (colodeCount >= 1)
            {
                hand[0] = InicializeCarad.cardList[x];
                InicializeCarad.cardList.RemoveAt(x);
                Card_1.Fill = hand[0].bacground.image;
                colodeCount--;
            }
            if (colodeCount >= 1) 
            {
                rand1 = new Random();
                x = rand1.Next(InicializeCarad.cardList.Count);
                hand[1] = InicializeCarad.cardList[x];
                InicializeCarad.cardList.RemoveAt(x);
                Card_2.Fill = hand[1].bacground.image;
                colodeCount--;
            }
            if (colodeCount < 1)
            {
                Locations.location.motion = 2;
            }
            
           //======================================================
            Calode0.IsEnabled = false;
            Calode1.IsEnabled = false;
            Calode2.IsEnabled = false;
            Calode3.IsEnabled = false;
            Calode4.IsEnabled = false;
            Calode5.IsEnabled = false;
           // txtBl_map_yellow.Text = colodeCount.ToString();
           
            

            if (colodeCount <= 0)
            {
                Calode0.Visibility = Visibility.Hidden;
            }
            if (colodeCount <= 1)
            {
                Calode1.Visibility = Visibility.Hidden;
            }
            if (colodeCount <= 2)
            {
                Calode2.Visibility = Visibility.Hidden;
            }
            if (colodeCount <= 3)
            {
                Calode3.Visibility = Visibility.Hidden;
            }
            if (colodeCount <= 4)
            {
                Calode4.Visibility = Visibility.Hidden;
            }
            if (colodeCount <= 5)
            {
                Calode5.Visibility = Visibility.Hidden;
            }
        }

       

        //==========================кепсы======================

    }
}
