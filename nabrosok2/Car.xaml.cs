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
using System.Windows.Media.Effects;

namespace nabrosok2
{

    public partial class Car : Window
    {
      
       int tape = 0;
        bool pillow = false;
        List<string> relicsBad   = new List<string>() {"Нет, вам точно не нужно это в автомобиле.", "Вы попробуете в следующий раз, в этот ничего не вышло.", 
            "Сомнения гложут вас - понимаете вы ли хоть что-то в автомобиле?","Так не пойдет.", "Ронг!", "Сначала кажется, что эта вещь идеально должна подойти," +
            "а потом непонятно, куда она должна подойти.", "Ты знаешь, что такое безумие?"  };

        Item arrow = new Item(0, 0, 0, "/image/camp.png");
        public Car()
        {
            InitializeComponent();

            invetory_drow();
            rct_arrow.Fill = arrow.Begin.image;
            txtbl_counter.Text = Player.Day.ToString();
        }

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
                chekItem(Player.inventory[0]);
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
                chekItem(Player.inventory[1]);
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
                chekItem(Player.inventory[2]);
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
                chekItem(Player.inventory[3]);
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
                chekItem(Player.inventory[4]);
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
                chekItem(Player.inventory[5]);
            }
        }

        
        protected override void OnClosed(EventArgs e)
        {

            App.Current.Shutdown();
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
              foreach (var item in Player.inventory)
           {
               Player.deck_item.Add(item);
           }
         
            Player.inventory.Clear();
            // instalShop();
            //Locations.camp.invetory_drow();
            // Locations.camp.shop_drow();
            Locations.camp.prgrs_bar_camp.Value = prgrs_bar.Value;
            Locations.camp.updateCamp();
            Locations.camp.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Collapsed;
         
        }
        private void Media_Ended(object sender, EventArgs e)
        {
            Start.mediaPlayer.Position = TimeSpan.Zero;
            Start.mediaPlayer.Play();
        }
        public void instalShop()
        {

           
            if (Player.deck_item.Count > 8)
            {
                for (int i = 0; i < 8; i++)
                {
                    Random rand = new Random();
                    int x = rand.Next(Player.deck_item.Count);
                    Locations.camp.shop_item[i] = Player.deck_item[x];
                    Player.deck_item.RemoveAt(x);
                }
            }
            else
            {
                for (int i = 0; i < Player.deck_item.Count; i++)
                {
                    Random rand = new Random();
                    int x = rand.Next(Player.deck_item.Count);
                    Locations.camp.shop_item[i] = Player.deck_item[x];
                    Player.deck_item.RemoveAt(x);
                }

            }
        }

        public void carReady()
        {
            if (prgrs_bar.Value >= 100)
            {
                elips_startEngine.Visibility = Visibility.Visible;
            }
        }

        public void chekItem(Item item)
        {
            int id = 0;
            id = item.ID;
            switch (id)
            {
                case 11:
                    if (item.usules)
                    {
                        img_med.Visibility = Visibility.Visible;
                        prgrs_bar.Value += 100 / 14;
                        carReady();
                        Player.inventory.Remove(item);
                        invetory_drow();
                        txtbl_car.Text = "В дороге может случится всякое, лучше быть готовым к проверкам.";
                        tape++;
                        break;
                    }
                    else
                    {
                        txtbl_car.Text = "Аптечка может еще пригодиться в приключениях! Придержу пока у себя.";
                        break;
                    }
                   

                case 34:
                    img_will.Visibility = Visibility.Visible;
                    prgrs_bar.Value += 100 / 14;
                    tape++;
                    carReady();
                    Player.inventory.Remove(item);
                    invetory_drow();
                    txtbl_car.Text = "Неужели приделать четвертое колесо к машине - это удачная идея?";
                    break;

                case 19:
                    img_deck.Visibility = Visibility.Visible;
                    prgrs_bar.Value += 100 / 14;
                    carReady();
                    Player.inventory.Remove(item);
                    invetory_drow();
                    txtbl_car.Text = "Если сильно ударить, то вал рулевой колонки пробьет доску. Но дизайнер решил сделать из нее бампер.";
                    tape++;
                    break;


                case 13:
                    img_akum.Visibility = Visibility.Visible;
                    prgrs_bar.Value += 100 / 14;
                    carReady();
                    Player.inventory.Remove(item);
                    invetory_drow();
                    txtbl_car.Text = "После некоторой модификации капота в нем появляется большая дыра, и аккумулятор занимает логичное положение в автомобиле.";
                    break;

                case 22:
                    img_ognetush.Visibility = Visibility.Visible;
                    prgrs_bar.Value += 100 / 14;
                    carReady();
                    Player.inventory.Remove(item);
                    invetory_drow();
                    txtbl_car.Text = "Экстрим должен быть безопасным. Проверяйте сроки годности.";
                    tape++;
                    break;


                case 20:
                    img_kubik.Visibility = Visibility.Visible;
                    prgrs_bar.Value += 100 / 14;
                    carReady();
                    Player.inventory.Remove(item);
                    invetory_drow();
                    txtbl_car.Text = "Нужно уметь радовать себя мелочами, особенно в стрессовой ситуации.";
                    break;


                case 31:
                    img_straich.Visibility = Visibility.Visible;
                    prgrs_bar.Value += 100 / 14;
                    carReady();
                    Player.inventory.Remove(item);
                    invetory_drow();
                    txtbl_car.Text = "Вам нужно лобовое стекло, иначе на ветру можно простудиться. Стрейч прозрачный и его можно натянуть, отлично.";
                    break;

                case 10://скоч
                    if (img_med.IsVisible)
                    {
                        img_med.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "/items_car/apteka_scotch.png", UriKind.RelativeOrAbsolute));
                    }
                    if (img_deck.IsVisible)
                    {
                        img_deck.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "/items_car/car_bamper_scotch.png", UriKind.RelativeOrAbsolute));
                    }
                    if (img_ognetush.IsVisible)
                    {
                        img_ognetush.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "/items_car/ognetush_scotch.png", UriKind.RelativeOrAbsolute));
                    }
                    if (img_will.IsVisible)
                    {
                        img_will.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "/items_car/4_koleso_scotch.png", UriKind.RelativeOrAbsolute));
                    }
                    if (tape == 4)
                    {
                        prgrs_bar.Value += 100 / 14;
                        carReady();
                        Player.inventory.Remove(item);
                        invetory_drow();
                        txtbl_car.Text = "Скотч - универсальное средство для енота и монтажа. Вопрос с болтами для четвертого колеса решен.";
                        break;
                    }
                    else
                    {
                        switch (tape)
                        {
                            case 0:
                                txtbl_car.Text = "Если использую скотч сейчас, я навсегда утеряю его язычек. Нужно выждать лучшее время.";
                                break;
                            case 1:
                                txtbl_car.Text = "Все держится на ноздрях. Хотелось бы, но еще рано, нужно выждать момент.";
                                break;
                            case 2:
                                txtbl_car.Text = "Для полноты картины нехватает еще одной вещи. Терпение мой друг!";
                                break;
                            case 3:
                                txtbl_car.Text = "И еще одной вещи. От куда мне было знать, я же начинающий специалист в механикости.";
                                break;
                            default:
                                break;
                        }
                        if (img_med.IsVisible)
                        {
                            img_med.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "/items_car/apteka_scotch.png", UriKind.RelativeOrAbsolute));
                        }
                        if (img_deck.IsVisible)
                        {
                            img_deck.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "/items_car/car_bamper_scotch.png", UriKind.RelativeOrAbsolute));
                        }
                        if (img_ognetush.IsVisible)
                        {
                            img_ognetush.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "/items_car/ognetush_scotch.png", UriKind.RelativeOrAbsolute));
                        }
                        if (img_will.IsVisible)
                        {
                            img_will.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "/items_car/4_koleso_scotch.png", UriKind.RelativeOrAbsolute));
                        }
                    }
                    break;

                case 15:
                    img_samagon.Visibility = Visibility.Visible;
                    prgrs_bar.Value += 100 / 14;
                    carReady();
                    Player.inventory.Remove(item);
                    invetory_drow();
                    txtbl_car.Text = "Что залить в бак - бензин? Ну уж нет, нам нужна скорость, нам нужен самогон из сливовой браги.";
                    break;

                case 21:
                    img_izolenta.Visibility = Visibility.Visible;
                    prgrs_bar.Value += 100 / 14;
                    carReady();
                    Player.inventory.Remove(item);
                    invetory_drow();
                    txtbl_car.Text = "Вся электрика держится на одном - на изоленте. Теперь проблем с аккумулятором и проводкой у вас не возникнет.";
                    break;

                case 23:
                    img_frost.Visibility = Visibility.Visible;
                    prgrs_bar.Value += 100 / 14;
                    carReady();
                    Player.inventory.Remove(item);
                    invetory_drow();
                    txtbl_car.Text = "Слегка великоват для салона, но главное засунуть и приоткрыть дверцу. Кондиционер - вещь первой необходимости для современного автомобилиста.";
                    break;

                case 8:
                    
                    prgrs_bar.Value += 100 / 14;
                    carReady();
                    Player.inventory.Remove(item);
                   
                    if (pillow)
                    {
                        txtbl_car.Text = "Неизвестно, сколько придется ехать, лучше положить под попу что-то мягкое, например, перьевую подушку.";
                        img_podushka.Visibility = Visibility.Visible;
                        img_perya.Visibility = Visibility.Hidden;
                        img_navolochka.Visibility = Visibility.Hidden;
                        invetory_drow();
                    }
                    else
                    {
                        img_navolochka.Visibility = Visibility.Visible;
                        txtbl_car.Text = "Да, это можно применить с пользой.";
                        invetory_drow();
                        pillow = true;
                    }
                    break;

                case 28:
                    prgrs_bar.Value += 100 / 14;
                    carReady();
                    Player.inventory.Remove(item);
                    
                    if (pillow)
                    {
                        txtbl_car.Text = "Неизвестно, сколько придется ехать, лучше положить под попу что-то мягкое, например, перьевую подушку.";
                        img_podushka.Visibility = Visibility.Visible;
                        img_perya.Visibility = Visibility.Hidden;
                        img_navolochka.Visibility = Visibility.Hidden;
                        invetory_drow();
                    }
                    else
                    {
                        img_perya.Visibility = Visibility.Visible;
                        txtbl_car.Text = "Да, это можно применить с пользой.";
                        invetory_drow();
                        pillow = true;
                    }
                    break;



                case 29:
                    img_roze.Visibility = Visibility.Visible;
                    prgrs_bar.Value += 100 / 15;
                    carReady();
                    Player.inventory.Remove(item);
                    invetory_drow();
                    txtbl_car.Text = "Розочка незаменимая часть автомобиля, жаль я точно не знаю где ее применить";
                    break;


                case 18:
                    img_crowbar.Visibility = Visibility.Visible;
                    prgrs_bar.Value += 100 / 15;
                    carReady();
                    Player.inventory.Remove(item);
                    invetory_drow();
                    txtbl_car.Text = "Вы с силой загоняете лом туда, где должна быть ручка переключения передач...Или нет. Чувства вас переполняют, прямо как в батином москвиче!";
                    break;

                default:
                    Random rand = new Random();
                    int x = rand.Next(relicsBad.Count);
                    txtbl_car.Text = relicsBad[x];
                    break;
            }
        }

        private void elips_startEngine_MouseEnter(object sender, MouseEventArgs e)
        {
            elips_startEngine.Width = 520;
            elips_startEngine.Height = 510;
            DropShadowEffect effect = new DropShadowEffect();
            effect.BlurRadius = 15;
            effect.Color = Colors.OrangeRed;
            effect.ShadowDepth = 15;
            effect.Direction = 90;
            elips_startEngine.Effect = effect;

    }

        private void elips_startEngine_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Locations.fin.Show();
            this.Hide();
            Start.mediaPlayer.Open(new Uri(System.IO.Directory.GetCurrentDirectory() + "/fin.mp3", UriKind.RelativeOrAbsolute));

            Start.mediaPlayer.Play();
        }

        private void elips_startEngine_MouseLeave(object sender, MouseEventArgs e)
        {
            DropShadowEffect effect2 = new DropShadowEffect();
            effect2.BlurRadius = 0;
            effect2.Color = Colors.Black;
            effect2.ShadowDepth = 0;
            effect2.Direction = 220;
            elips_startEngine.Effect = effect2;
            elips_startEngine.Width = 410;
            elips_startEngine.Height = 398;
        }
    }
}
