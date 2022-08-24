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
    /// <summary>
    /// Логика взаимодействия для AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public string step;
        public string lvl;
        public string item;
        public int day;

        public AdminPanel()
        {
            InitializeComponent();
        }

        

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
                Locations.camp.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Collapsed;
        }

        protected override void OnClosed(EventArgs e)
        {
            App.Current.Shutdown();
        }

        private void ComboBox_Selected(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void bxItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void bxStep_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_GO_Click(object sender, RoutedEventArgs e)
        {
          lvl = bxLvl.Text;
          
          step= bxStep.Text;

            
            Locations.location.Visibility = Visibility.Visible;
           
            Locations.location.LocationBackground.Background = InitializeInstance.instances[ScanAdress(bxLvl.Text)].bacground.image;
            Locations.location.ID = InitializeInstance.instances[ScanAdress(bxLvl.Text)].ID;
            Locations.location.writeText(InitializeInstance.instances[ScanAdress(bxLvl.Text)].instalReaction());
            Locations.location.invetory_drow();
            this.Visibility = Visibility.Collapsed;
        }

        private Item ScanItem(string item)
        {
            switch (item)
            {

                case "Акум от сотового":
                    return Inicialize.mobil_akb;
                case "Аптечка":
                    return Inicialize.firstKid;
                case "Велосипедная цепь":
                    return Inicialize.chain;//
                case "Веревка":
                    return Inicialize.rope;
                case "Карта":
                    return Inicialize.map;
                case "Компас":
                    return Inicialize.compass;
                case "Наволочка":
                    return Inicialize.pillowcase;
                case "Полиэтиленовый пакет":
                    return Inicialize.package;
                case "Скотч":
                    return Inicialize.tape;
                case "Скрепка":
                    return Inicialize.clip;
                case "Спички":
                    return Inicialize.matches;
                case "Фонарик":
                    return Inicialize.flashlight;
                case "Аккумулятор":
                    return Inicialize.AKB;
                case "Армейский нож":
                    return Inicialize.knife;
                case "Бензин":
                    return Inicialize.gus;
                case "Брелок с розой":
                    return Inicialize.roze;
                case "Изолента":
                    return Inicialize.ductTape;
                case "Кирпич":
                    return Inicialize.brick;
                case "Колесо":
                    return Inicialize.wheel;
                case "Кубики":
                    return Inicialize.dice;
                case "Лом":
                    return Inicialize.crowbar;
                case "Металлический ящик":
                    return Inicialize.chest;
                case "Огнетушитель":
                    return Inicialize.extiguisher;
                case "Перекладина":
                    return Inicialize.deck;
                case "Перья":
                    return Inicialize.plump;
                case "Рваная палатка":
                    return Inicialize.tent;
                case "Руль":
                    return Inicialize.rull;
                case "Самогон":
                    return Inicialize.brew;
                case "Сигнальный пистолет":
                    return Inicialize.pistol;
                case "Стрейч":
                    return Inicialize.straych;
                case "топор":
                    return Inicialize.axe;
                case "Тушенка":
                    return Inicialize.stew;
                case "Холодильник":
                    return Inicialize.fridge;
                case "Шестеренка":
                    return Inicialize.gear;
                default:
                    break;
                   
            }
            return null;

        }

        private int ScanAdress(string instance)
        {
            switch (instance)
            {
                case "Сарай":
                    return 0;
                case "Велик":
                    return 1;
                case "Мост":
                    return 2;
                case "Бункер":
                    return 3;
                case "Лагерь лесников":
                    return 4;
                case "Пещера":
                    return 5;
                case "Перекресток":
                    return 6;
                case "Паращютист":
                    return 7;
                case "Разрушенный лагерь":
                    return 8;
                case "Врата":
                    return 9;
                case "Охотнечий домик":
                    return 10;
                case "Заброшеный лагерь":
                    return 11;
                case "Заросшая дорога":
                    return 12;
                case "Лодка":
                    return 13;
                case "Болото":
                    return 14;
                case "Ручей":
                    return 15;
                case "Вышка":
                    return 16;
                case "Трактор":
                    return 17;
                case "Дерево":
                    return 18;

                default:
                    break;
            }

            return 0;
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            item = bxItem.Text;
            Player.inventory.Add(ScanItem(bxItem.Text));
           
        }

        private void btn_fin_Click(object sender, RoutedEventArgs e)
        {
            Locations.fin.Show();
        }

        private void btn_car_Click(object sender, RoutedEventArgs e)
        {
            Locations.car.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Locations.car.prgrs_bar.Value += 90;
        }
    }
}
