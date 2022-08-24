using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace nabrosok2
{
   
    public partial class MainWindow : Window
    {
        Sprite campBackground = new Sprite("/image/background_camp3.jpg");
       // Item printer = new Item(0, 0, 0, "/image/test_sprite.png");
       // Sprite card_printer = new Sprite("/image/Card_Printer.png");
        Item btn_accept = new Item(0, -0.5, 0, "/image/btn_sprite.png", 0, 0.350, 0, 0.690);
        Item btn_cansel = new Item(0, 0.5, 0, "/image/btn_sprite.png", 0, 0.350, 0, 0.690);
        Item item_0;
       // List<Item> inventory = new List<Item>(6);
       public Item[] shop_item = new Item[8];
        int current_pos;
        List<string> fullInventory = new List<string> { "Эй! Не наглей, у тебя только 4 кармана!", "С тебя хватит", "Магазин закрыт на обед", "Жадность гуся сгубила", "Витринный образец, не продается!", "Здесь строить нельзя!", "Нам не хватает минералов!", "Тебе бы выпить таблеток от жадности.", "Расширение инвентаря купишь в DLC.", "Нельзя сотворить здесь!", "Нужно больше золота!"};
        List<string> niceChoice = new List<string> { "Найс чойс", "Безделушка, но сойдет", "Ты что, псих?", "Зачем тебе это?", "Улётная штука", "Хреновина!", "Думаешь сделать из этого ракету?", "Это что? Сова?", "Собираешься это съесть?", "Это может плохо закочиться!","Все с тобой понятно...","У каждого свои тараканы в голове","Товар возврату и обмену не подлежит!"};
        Sprite btn_cansel_inventary = new Sprite("/image/btn_cansel.png");
        Item arrow = new Item(0,0,0,"/image/Arrow_sprite.png");
        int counter_days = 0;
        
        
        public MainWindow()
        {
            InitializeComponent();
            Player.Day++;
            rct_btn_accept.IsEnabled = false;
            rct_btn_cansel.IsEnabled = false;
            rct_btn_accept.Visibility = Visibility.Hidden;
            rct_btn_cansel.Visibility = Visibility.Hidden;
            
            rct_btn_accept.Fill = btn_accept.Begin.image;
            rct_btn_cansel.Fill = btn_cansel.Begin.image;

            rct_arrow.Fill = arrow.Begin.image;

            window_shop.Background = campBackground.image;
            InicializeCarad.initialize();
            InitializeInstance.initialize();
            Inicialize.initializeItem();
            //item_0 = printer;
           // item_0.Card = card_printer;

           
            instalShop();
            invetory_drow();
            shop_drow();
        }

        public void updateCamp()
        {
           
            instalShop();
            invetory_drow();
            shop_drow();
        }
      

        public void removeDeck()
        {
            foreach (var item in shop_item)
            {
                if (item != null)
                Player.deck_item.Add(item);
            }
            Array.Clear(shop_item);
        }

        public void instalShop()
        {//тут какой-то баг связанный с машиной.
            
                for (int i = 0; i < 8; i++)
                {
                if (Player.deck_item.Count !=0)
                {
                    Random rand = new Random();
                    int x = rand.Next(Player.deck_item.Count);
                    shop_item[i] = Player.deck_item[x];
                    Player.deck_item.RemoveAt(x);
                }
                }
           
            
           
        }
        
        private void shop_chek_sale(int position)
        {
            current_pos = position;
            rct_cardPrev.Fill = shop_item[position].Card.image;
            rct_btn_accept.IsEnabled = true;
            rct_btn_cansel.IsEnabled = true;
            rct_btn_accept.Visibility = Visibility.Visible;
            rct_btn_cansel.Visibility = Visibility.Visible;
        }

        private void shop_close()
        {
            rct_cardPrev.Fill = null;
            rct_btn_accept.IsEnabled = false;
            rct_btn_cansel.IsEnabled = false;
            rct_btn_accept.Visibility = Visibility.Hidden;
            rct_btn_cansel.Visibility = Visibility.Hidden;
        }

        private void shop_sale(int position)
        {
            if (Player.inventory.Count < 4)
            {
                Player.inventory.Add(shop_item[position]);
                Player.deck_item.Remove(shop_item[position]);
                Array.Clear(shop_item, position, 1);
                invetory_drow();
                shop_drow();
                Random random = new Random();
                writeShopText(niceChoice[random.Next(niceChoice.Count)]);
            }
            else
            {
                Random random = new Random();
                writeShopText(fullInventory[random.Next(fullInventory.Count)]);
            }
        }

        private async void writeShopText(string text)
        {
            txtBl_shop_yellow.Text = text;
            Canvas.SetZIndex(txtBl_shop_yellow, 3);
            await Task.Delay(2000);
            writeClear();
        }

        private void writeClear()
        {
            txtBl_shop_yellow.Text = "";
            Canvas.SetZIndex(txtBl_shop_yellow, 0);
        }

        public void shop_drow()
        {
            if (shop_item[0]!= null)
            {
               rct_ft00.Fill = shop_item[0].Begin.image;
               
            }
            else
            {
                rct_ft00.Fill = null;
            }

            if (shop_item[1] != null)
            {
                rct_ft01.Fill = shop_item[1].Begin.image;
            }
            else
            {
                rct_ft01.Fill = null;
            }

            if (shop_item[2] != null)
            {
                rct_ft10.Fill = shop_item[2].Begin.image;
            }
            else
            {
                rct_ft10.Fill = null;
            }

            if (shop_item[3] != null)
            {
                rct_ft11.Fill = shop_item[3].Begin.image;
            }
            else
            {
                rct_ft11.Fill = null;
            }

            if (shop_item[4] != null)
            {
                rct_ft20.Fill = shop_item[4].Begin.image;
            }
            else
            {
                rct_ft20.Fill = null;
            }

            if (shop_item[5] != null)
            {
                rct_ft21.Fill = shop_item[5].Begin.image;
            }
            else
            {
                rct_ft21.Fill = null;
            }

            if (shop_item[6] != null)
            {
                rct_ft30.Fill = shop_item[6].Begin.image;
            }
            else
            {
                rct_ft30.Fill = null;
            }

            if (shop_item[7] != null)
            {
                rct_ft31.Fill = shop_item[7].Begin.image;
            }
            else
            {
                rct_ft31.Fill = null;
            }
        }
        public void invetory_drow()
        {
            if (Player.inventory.Count != 0)
            {
                rct_inv0.Fill = Player.inventory[0].Begin.image;
                rct_canel0.Fill = btn_cansel_inventary.image;
                rct_canel0.IsEnabled = true;
            }
            else
            {
               // rct_canel0.IsEnabled = false;
                rct_inv0.Fill = null;
                rct_canel0.Fill = null;
            }

            if (Player.inventory.Count > 1)
            {
                rct_inv1.Fill = Player.inventory[1].Begin.image;
                rct_canel1.Fill = btn_cansel_inventary.image;
                rct_canel1.IsEnabled = true;
            }
            else
            {
                //rct_canel1.IsEnabled = false;
                rct_inv1.Fill = null;
                rct_canel1.Fill = null;
            }

            if (Player.inventory.Count > 2)
            {
                rct_inv2.Fill = Player.inventory[2].Begin.image;
                rct_canel2.Fill = btn_cansel_inventary.image;
                rct_canel2.IsEnabled = true;
            }
            else
            {
               // rct_canel2.IsEnabled = false;
                rct_inv2.Fill = null;
                rct_canel2.Fill = null;
            }

            if (Player.inventory.Count > 3)
            {
                rct_inv3.Fill = Player.inventory[3].Begin.image;
                rct_canel3.Fill = btn_cansel_inventary.image;
                rct_canel3.IsEnabled = true;
            }
            else
            {
               // rct_canel3.IsEnabled = false;
                rct_inv3.Fill = null;
                rct_canel3.Fill = null;
            }

            if (Player.inventory.Count > 4)
            {
                rct_inv4.Fill = Player.inventory[4].Begin.image;
                rct_canel4.Fill = btn_cansel_inventary.image;
                rct_canel4.IsEnabled = true;
            }
            else
            {
               // rct_canel4.IsEnabled = false;
                rct_inv4.Fill = null;
                rct_canel4.Fill = null;
            }

            if (Player.inventory.Count > 5)
            {
                rct_inv5.Fill = Player.inventory[5].Begin.image;
                rct_canel5.Fill = btn_cansel_inventary.image;
                rct_canel5.IsEnabled = true;
            }
            else
            {
               // rct_canel5.IsEnabled = false;
                rct_inv5.Fill = null;
                rct_canel5.Fill = null;
            }

        }

        //===============================подтверждение=================================
        private void rct_btn_accept_MouseEnter(object sender, MouseEventArgs e)
        {
            rct_btn_accept.Fill = btn_accept.Enter.image;
        }

        private void rct_btn_accept_MouseLeave(object sender, MouseEventArgs e)
        {
            rct_btn_accept.Fill = btn_accept.Begin.image;
            rct_bg00.Opacity = 1;
        }

        private void rct_btn_accept_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            rct_btn_accept.Fill = btn_accept.Click.image;
        }

        private void rct_btn_accept_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            shop_sale(current_pos);
            shop_close();
           
        }


        private void rct_btn_cansel_MouseEnter(object sender, MouseEventArgs e)
        {
            rct_btn_cansel.Fill = btn_cansel.Enter.image;
        }

        private void rct_btn_cansel_MouseLeave(object sender, MouseEventArgs e)
        {
            rct_btn_cansel.Fill = btn_cansel.Begin.image;
        }

        private void rct_btn_cansel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            rct_btn_cansel.Fill = btn_cansel.Click.image;
        }

        private void rct_btn_cansel_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
           shop_close();
        }

        //=====================================магаз============================

        private void rct_ft00_MouseEnter(object sender, MouseEventArgs e)
        {
            if (shop_item[0]!= null)
            {
                rct_ft00.Fill = shop_item[0].Enter.image;
            }
            rct_bg00.Opacity = 0.4;
        }

        private void rct_ft00_MouseLeave(object sender, MouseEventArgs e)
        {
            if (shop_item[0] != null)
            {
                rct_ft00.Fill = shop_item[0].Begin.image;
            }
            rct_bg00.Opacity = 1;
        }

        private void rct_ft00_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (shop_item[0] != null)
            {
                rct_ft00.Fill = shop_item[0].Click.image;
            }
            rct_bg00.Opacity = 0.4;
        }

        private void rct_ft00_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (shop_item[0] != null)
            {
                shop_chek_sale(0);
            }
            rct_ft00.Fill = null;
            rct_bg00.Opacity = 0.4;
        }



        private void rct_ft01_MouseEnter(object sender, MouseEventArgs e)
        {
            if (shop_item[1] != null)
            {
                rct_ft01.Fill = shop_item[1].Enter.image;
            }
            rct_bg01.Opacity = 0.4;

        }

        private void rct_ft01_MouseLeave(object sender, MouseEventArgs e)
        {
            if (shop_item[1] != null)
            {
                rct_ft01.Fill = shop_item[1].Begin.image;
            }
            rct_bg01.Opacity = 1;
        }

        private void rct_ft01_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (shop_item[1] != null)
            {
                rct_ft01.Fill = shop_item[1].Click.image;
            }
            rct_bg01.Opacity = 0.4;
        }

        private void rct_ft01_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            shop_chek_sale(1);
            rct_ft01.Fill = null;
            rct_bg01.Opacity = 0.4;
        }



        private void rct_ft10_MouseEnter(object sender, MouseEventArgs e)
        {
            if (shop_item[2] != null)
            {
                rct_ft10.Fill = shop_item[2].Enter.image;
            }
            rct_bg10.Opacity = 0.4;

        }

        private void rct_ft10_MouseLeave(object sender, MouseEventArgs e)
        {
            if (shop_item[2] != null)
            {
                rct_ft10.Fill = shop_item[2].Begin.image;
            }
            rct_bg10.Opacity = 1;
        }

        private void rct_ft10_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (shop_item[2] != null)
            {
                rct_ft10.Fill = shop_item[2].Click.image;
            }
            rct_bg10.Opacity = 0.4;
        }

        private void rct_ft10_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            shop_chek_sale(2);
            rct_ft10.Fill = null;
            rct_bg10.Opacity = 0.4;
        }



        private void rct_ft11_MouseEnter(object sender, MouseEventArgs e)
        {
            if (shop_item[3] != null)
            {
                rct_ft11.Fill = shop_item[3].Enter.image;
            }
            rct_bg11.Opacity = 0.4;
        }

        private void rct_ft11_MouseLeave(object sender, MouseEventArgs e)
        {
            if (shop_item[3] != null)
            {
                rct_ft11.Fill = shop_item[3].Begin.image;
            }
            rct_bg11.Opacity = 1;
        }

        private void rct_ft11_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (shop_item[3] != null)
            {
                rct_ft11.Fill = shop_item[3].Click.image;
            }
            rct_bg11.Opacity = 0.4;
        }

        private void rct_ft11_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            shop_chek_sale(3);
            rct_ft11.Fill = null;
            rct_bg11.Opacity = 0.4;
        }

        private void rct_ft20_MouseEnter(object sender, MouseEventArgs e)
        {
            if (shop_item[4] != null)
            {
                rct_ft20.Fill = shop_item[4].Enter.image;
            }
            rct_bg20.Opacity = 0.4;

        }

        private void rct_ft20_MouseLeave(object sender, MouseEventArgs e)
        {
            if (shop_item[4] != null)
            {
                rct_ft20.Fill = shop_item[4].Begin.image;
            }
            rct_bg20.Opacity = 1;
        }

        private void rct_ft20_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (shop_item[4] != null)
            {
                rct_ft20.Fill = shop_item[4].Click.image;
            }
            rct_bg20.Opacity = 0.4;
        }

        private void rct_ft20_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            shop_chek_sale(4);
            rct_ft20.Fill = null;
            rct_bg20.Opacity = 0.4;
        }


        private void rct_ft21_MouseEnter(object sender, MouseEventArgs e)
        {
            if (shop_item[5] != null)
            {
                rct_ft21.Fill = shop_item[5].Enter.image;
            }
            rct_bg21.Opacity = 0.4;

        }

        private void rct_ft21_MouseLeave(object sender, MouseEventArgs e)
        {
            if (shop_item[5] != null)
            {
                rct_ft21.Fill = shop_item[5].Begin.image;
            }
            rct_bg21.Opacity = 1;
        }

        private void rct_ft21_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (shop_item[5] != null)
            {
                rct_ft21.Fill = shop_item[5].Click.image;
            }
            rct_bg21.Opacity = 0.4;
        }

        private void rct_ft21_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            shop_chek_sale(5);
            rct_ft21.Fill = null;
            rct_bg21.Opacity = 0.4;
        }

        private void rct_ft30_MouseEnter(object sender, MouseEventArgs e)
        {
            if (shop_item[6] != null)
            {
                rct_ft30.Fill = shop_item[6].Enter.image;
            }
            rct_bg30.Opacity = 0.4;

        }

        private void rct_ft30_MouseLeave(object sender, MouseEventArgs e)
        {
            if (shop_item[6] != null)
            {
                rct_ft30.Fill = shop_item[6].Begin.image;
            }
            rct_bg30.Opacity = 1;
        }

        private void rct_ft30_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (shop_item[6] != null)
            {
                rct_ft30.Fill = shop_item[6].Click.image;
            }
            rct_bg30.Opacity = 0.4;
        }

        private void rct_ft30_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            shop_chek_sale(6);
            rct_ft30.Fill = null;
            rct_bg30.Opacity = 0.4;
        }


        private void rct_ft31_MouseEnter(object sender, MouseEventArgs e)
        {
            if (shop_item[7] != null)
            {
                rct_ft31.Fill = shop_item[7].Enter.image;
            }
            rct_bg31.Opacity = 0.4;
        }

        private void rct_ft31_MouseLeave(object sender, MouseEventArgs e)
        {
            if (shop_item[7] != null)
            {
                rct_ft31.Fill = shop_item[7].Begin.image;
            }
            rct_bg31.Opacity = 1;
        }

        private void rct_ft31_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (shop_item[7] != null)
            {
                rct_ft31.Fill = shop_item[7].Click.image;
            }
            rct_bg31.Opacity = 0.4;
        }

        private void rct_ft31_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            shop_chek_sale(7);
            rct_ft31.Fill = null;
            rct_bg31.Opacity = 0.4;
        }

        //========================================низ====================================

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
                rct_cardPrev.Fill = Player.inventory[0].Card.image;
            }
        }


        private void rct_inv1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Player.inventory.Count >1)
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
                rct_cardPrev.Fill = Player.inventory[1].Card.image;
                rct_inv1.Fill = Player.inventory[1].Enter.image;
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
                rct_cardPrev.Fill = Player.inventory[2].Card.image;
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
                rct_cardPrev.Fill = Player.inventory[3].Card.image;
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
                rct_cardPrev.Fill = Player.inventory[4].Card.image;
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
                rct_cardPrev.Fill = Player.inventory[0].Card.image;
            }
        }

        //=======================================кнопки сброса карт========================

        private void rct_canel0_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Player.inventory.RemoveAt(0);
            invetory_drow();
           // rct_canel0.IsEnabled = false;
        }
        private void rct_canel1_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Player.inventory.RemoveAt(1);
            invetory_drow();
            //rct_canel1.IsEnabled = false;
        }
        private void rct_canel2_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Player.inventory.RemoveAt(2);
            invetory_drow();
            //rct_canel2.IsEnabled = false;
        }
        private void rct_canel3_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Player.inventory.RemoveAt(3);
            invetory_drow();
           //rct_canel3.IsEnabled = false;
        }
        private void rct_canel4_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Player.inventory.RemoveAt(4);
            invetory_drow();
           // rct_canel4.IsEnabled = false;
        }
        private void rct_canel5_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Player.inventory.RemoveAt(5);
            invetory_drow();
           // rct_canel5.IsEnabled = false;
        }



        //==============================Стрелочка=================================


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
            Locations.location.invetory_drow();

            if (InicializeCarad.cardList.Count > 0)
            {
                counter_days++;
                rct_arrow.Fill = arrow.Begin.image;
                Locations.car.txtbl_counter.Text = counter_days.ToString();
                removeDeck();
                Locations.map.instalColodeCount();
                Locations.map.Visibility = Visibility.Visible;
                this.Visibility = Visibility.Collapsed;
            }
            else
            {
                Locations.car.Visibility = Visibility.Visible;
                this.Visibility = Visibility.Collapsed;
            }
        }

        private void Media_Ended(object sender, EventArgs e)
        {
            Start.mediaPlayer.Position = TimeSpan.Zero;
            Start.mediaPlayer.Play();
        }
        protected override void OnClosed(EventArgs e)
        {
            App.Current.Shutdown();
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            Locations.Admin.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Collapsed;
        }
    }
}
