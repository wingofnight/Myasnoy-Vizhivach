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

namespace nabrosok2
{
  

    public partial class Location : Window
    {
        Sprite background = new Sprite("/location/tractor.jpg");
        Item arrow = new Item(0, 0, 0, "/image/backy4.png");
       public int motion = 0;
        public  cards currentCart;
        public int ID = 0;
       public bool finish = false;
        public Location()
        {
            InitializeComponent();
            LocationBackground.Background = background.image;
            rct_arrow.Fill = arrow.Begin.image;
           
            invetory_drow();
        }

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
            if (motion <2)
            {
                
                motion++;
                rct_arrow.Fill = arrow.Begin.image;
                if (Locations.map.hand[0] != null)
                {
                    Locations.map.Dump.Add(Locations.map.hand[0]);
                }
                if (Locations.map.hand[1] != null)
                {
                    Locations.map.Dump.Add(Locations.map.hand[1]);
                }

                
                if (finish)
                {
                    Locations.map.Dump.Remove(currentCart);
                    finish = false;
                    DestroyCaps(currentCart);
                }
                Array.Clear(Locations.map.hand, 0, 1);
                Array.Clear(Locations.map.hand, 1, 1);//можно сократить Locations.map.hand, 0, 2
                Locations.map.Card_1.Fill = null;
                Locations.map.Card_2.Fill = null;
                Locations.map.adress = 0;
                Locations.map.rct_arrow.Visibility = Visibility.Hidden;
                Locations.map.Card_1.IsEnabled = false;
                Locations.map.Card_2.IsEnabled = false;
              
                Locations.map.Calode0.IsEnabled = true;
                Locations.map.Calode1.IsEnabled = true;
                Locations.map.Calode2.IsEnabled = true;
                Locations.map.Calode3.IsEnabled = true;
                Locations.map.Calode4.IsEnabled = true;
                Locations.map.Calode5.IsEnabled = true;

                Locations.map.Visibility = Visibility.Visible;
                this.Visibility = Visibility.Collapsed;
            }
            else
            {
                Locations.map.Calode0.IsEnabled = true;
                Locations.map.Calode1.IsEnabled = true;
                Locations.map.Calode2.IsEnabled = true;
                Locations.map.Calode3.IsEnabled = true;
                Locations.map.Calode4.IsEnabled = true;
                Locations.map.Calode5.IsEnabled = true;

                Locations.map.rct_arrow.IsEnabled = false;
                Locations.map.rct_arrow.Visibility = Visibility.Hidden;
                Locations.map.Card_1.Fill = null;
                Locations.map.Card_2.Fill = null;
                Locations.map.Card_1.IsEnabled = false;
                Locations.map.Card_2.IsEnabled = false;
                motion = 0;
                if (Locations.map.hand[0] != null)
                {
                    Locations.map.Dump.Add(Locations.map.hand[0]);
                }
                if (Locations.map.hand[1] != null)
                {
                    Locations.map.Dump.Add(Locations.map.hand[1]);
                }
                if (finish)
                {
                    Locations.map.Dump.Remove(currentCart);
                    finish = false;
                    DestroyCaps(currentCart);
                }
                Array.Clear(Locations.map.hand, 0, 1);
                Array.Clear(Locations.map.hand, 1, 1);
                
                Locations.car.invetory_drow();
               
               
              
                foreach (var item in Locations.map.Dump)
                {
                      InicializeCarad.cardList.Add(item);
                }

                Locations.map.Dump.Clear();

               // Locations.map.ColodeCard = new List<cards>();
                Locations.car.Visibility = Visibility.Visible;
                this.Visibility = Visibility.Collapsed;
            }
        }

        public void DestroyCaps(cards x)
        {
            switch (x.ID)
            {
                case 0:
                    Locations.map.rct_caps5.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    Locations.map.rct_caps3.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    Locations.map.rct_caps12.Visibility = Visibility.Hidden;
                    break;
                case 3:

                    Locations.map.rct_caps14.Visibility = Visibility.Hidden;
                    break;
                case 4:

                    Locations.map.rct_caps0.Visibility = Visibility.Hidden;
                    break;
                case 5:

                    Locations.map.rct_caps19.Visibility = Visibility.Hidden;
                    break;
                case 6:

                    Locations.map.rct_caps18.Visibility = Visibility.Hidden;
                    break;
                case 7:

                    Locations.map.rct_caps16.Visibility = Visibility.Hidden;
                    break;
                case 8:

                    Locations.map.rct_caps15.Visibility = Visibility.Hidden;
                    break;
                case 9:

                    Locations.map.rct_caps17.Visibility = Visibility.Hidden;
                    break;
                case 10:

                    Locations.map.rct_caps6.Visibility = Visibility.Hidden;
                    break;
                case 11:

                    Locations.map.rct_caps13.Visibility = Visibility.Hidden;
                    break;
                case 12:

                    Locations.map.rct_caps7.Visibility = Visibility.Hidden;
                    break;
                case 13:

                    Locations.map.rct_caps1.Visibility = Visibility.Hidden;
                    break;
                case 14:

                    Locations.map.rct_caps8.Visibility = Visibility.Hidden;
                    break;
                case 15:

                    Locations.map.rct_caps4.Visibility = Visibility.Hidden;
                    break;
                case 16:

                    Locations.map.rct_caps11.Visibility = Visibility.Hidden;
                    break;
                case 17:

                    Locations.map.rct_caps2.Visibility = Visibility.Hidden;
                    break;
                case 18:

                    Locations.map.rct_caps9.Visibility = Visibility.Hidden;
                    break;


                default:
                    break;
            }
        }


        //=======================================================инвентарь==================

        public void invetory_drow()
        {
            if (Player.inventory.Count != 0)
            {
                rct_inv0.Fill = Player.inventory[0].Begin.image;
            }
            else
            {
                rct_inv0.Fill = null;
            }

            if (Player.inventory.Count > 1)
            {
                rct_inv1.Fill = Player.inventory[1].Begin.image;
            }
            else
            {
                rct_inv1.Fill = null;
            }

            if (Player.inventory.Count > 2)
            {
                rct_inv2.Fill = Player.inventory[2].Begin.image;
            }
            else
            {
                rct_inv2.Fill = null;
            }

            if (Player.inventory.Count > 3)
            {
                rct_inv3.Fill = Player.inventory[3].Begin.image;
            }
            else
            {
                rct_inv3.Fill = null;
            }

            if (Player.inventory.Count > 4)
            {
                rct_inv4.Fill = Player.inventory[4].Begin.image;
            }
            else
            {
                rct_inv4.Fill = null;
            }

            if (Player.inventory.Count > 5)
            {
                rct_inv5.Fill = Player.inventory[5].Begin.image;
            }
            else
            {
                rct_inv5.Fill = null;
            }

        }
        public void writeText(string text)// тут был  async 
        {
           // int ID = InitializeInstance.instances[Locations.map.adress].ID;
            if ( ID == 0 || ID == 6 || ID == 13 || ID == 14 )
            {
                txtbl_info_left.Text = text;
                Canvas.SetZIndex(txtbl_info_left, 0);
            }
            else
            {
                txtbl_info_right.Text = text;
                Canvas.SetZIndex(txtbl_info_right, 0);
            }
           
        }

        public void writeClear()
        {
            txtbl_info_right.Text = "";
            Canvas.SetZIndex(txtbl_info_left, 0);
            txtbl_info_left.Text = "";
            Canvas.SetZIndex(txtbl_info_left, 0);
        }

        //============================Инвентарь
        private void rct_inv0_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Player.inventory.Count != 0)
            {
                rct_inv0.Fill = Player.inventory[0].Enter.image;
            }
        }

        private void rct_inv0_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Player.inventory.Count != 0)
            {
                rct_inv0.Fill = Player.inventory[0].Begin.image;
            }
        }

        private void rct_inv0_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Player.inventory.Count != 0)
            {
                rct_inv0.Fill = Player.inventory[0].Click.image;
            }
        }

        private void rct_inv0_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Player.inventory.Count != 0)
            {
                rct_inv0.Fill = Player.inventory[0].Enter.image;
                InitializeInstance.instances[Locations.map.adress].chekItem(Player.inventory[0]);
            }

        }


        private void rct_inv1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Player.inventory.Count > 1)
            {
                rct_inv1.Fill = Player.inventory[1].Enter.image;

            }
        }

        private void rct_inv1_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Player.inventory.Count > 1) rct_inv1.Fill = Player.inventory[1].Begin.image;
        }

        private void rct_inv1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Player.inventory.Count > 1) rct_inv1.Fill = Player.inventory[1].Click.image;
        }

        private void rct_inv1_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Player.inventory.Count > 1)
            {
                rct_inv1.Fill = Player.inventory[1].Enter.image;
                InitializeInstance.instances[Locations.map.adress].chekItem(Player.inventory[1]);
            }
        }


        private void rct_inv2_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Player.inventory.Count > 2) rct_inv2.Fill = Player.inventory[2].Enter.image;
        }

        private void rct_inv2_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Player.inventory.Count > 2) rct_inv2.Fill = Player.inventory[2].Begin.image;
        }

        private void rct_inv2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Player.inventory.Count > 2) rct_inv2.Fill = Player.inventory[2].Click.image;
        }

        private void rct_inv2_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Player.inventory.Count > 2)
            {
                rct_inv2.Fill = Player.inventory[2].Enter.image;
                InitializeInstance.instances[Locations.map.adress].chekItem(Player.inventory[2]);
            }
        }


        private void rct_inv3_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Player.inventory.Count > 3) rct_inv3.Fill = Player.inventory[3].Enter.image;
        }

        private void rct_inv3_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Player.inventory.Count > 3) rct_inv3.Fill = Player.inventory[3].Begin.image;
        }

        private void rct_inv3_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Player.inventory.Count > 3) rct_inv3.Fill = Player.inventory[3].Click.image;
        }

        private void rct_inv3_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Player.inventory.Count > 3)
            {
                rct_inv3.Fill = Player.inventory[3].Enter.image;
                InitializeInstance.instances[Locations.map.adress].chekItem(Player.inventory[3]);
            }
        }


        private void rct_inv4_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Player.inventory.Count > 4) rct_inv4.Fill = Player.inventory[4].Enter.image;
        }

        private void rct_inv4_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Player.inventory.Count > 4) rct_inv4.Fill = Player.inventory[4].Begin.image;
        }

        private void rct_inv4_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Player.inventory.Count >= 4) rct_inv4.Fill = Player.inventory[4].Click.image;
        }

        private void rct_inv4_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Player.inventory.Count > 4)
            {
                rct_inv4.Fill = Player.inventory[4].Enter.image;
                InitializeInstance.instances[Locations.map.adress].chekItem(Player.inventory[4]);
            }
        }


        private void rct_inv5_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Player.inventory.Count > 5) rct_inv5.Fill = Player.inventory[5].Enter.image;
        }

        private void rct_inv5_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Player.inventory.Count > 5) rct_inv5.Fill = Player.inventory[5].Begin.image;
        }

        private void rct_inv5_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Player.inventory.Count > 5) rct_inv5.Fill = Player.inventory[5].Click.image;
        }

        private void rct_inv5_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Player.inventory.Count > 5)
            {
                rct_inv5.Fill = Player.inventory[5].Enter.image;
                InitializeInstance.instances[Locations.map.adress].chekItem(Player.inventory[5]);
            }
        }

        protected override void OnClosed(EventArgs e)
        {

            App.Current.Shutdown();
        }

    }
}
