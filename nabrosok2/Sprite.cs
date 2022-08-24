using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace nabrosok2
{
    public class Sprite
    {
       
        public readonly  ImageBrush image = new ImageBrush();

        public Sprite(double x, double y, string path)
        {
            image.ImageSource = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + path, UriKind.RelativeOrAbsolute));
            image.Viewbox = new Rect(x, y, 1, 0.3);
           // image.Viewbox = new Rect(x, y, 0.1, 0.1);
            image.ViewboxUnits = BrushMappingMode.RelativeToBoundingBox;
            image.Viewport = new Rect(0, 0, 1,1);
            image.ViewportUnits = BrushMappingMode.RelativeToBoundingBox;
            //image.TileMode = TileMode.Tile;
            //image.Stretch = Stretch.Fill;
            image.AlignmentX = AlignmentX.Center;
            image.AlignmentY = AlignmentY.Center;
        }

        public Sprite(double x, double y, double z,double q, string path)
        {
            image.ImageSource = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + path, UriKind.RelativeOrAbsolute));
            image.Viewbox = new Rect(x, y, z, q);
            // image.Viewbox = new Rect(x, y, 0.1, 0.1);
            image.ViewboxUnits = BrushMappingMode.RelativeToBoundingBox;
            image.Viewport = new Rect(0, 0, 1, 1);
            image.ViewportUnits = BrushMappingMode.RelativeToBoundingBox;
            //image.TileMode = TileMode.Tile;
            //image.Stretch = Stretch.Fill;
            image.AlignmentX = AlignmentX.Center;
            image.AlignmentY = AlignmentY.Center;
        }
        public Sprite(string path)
        {
            image.ImageSource = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + path, UriKind.RelativeOrAbsolute));
        }
      

    }

    public class Item
    {
        public bool usules = false;
        public int ID;
        public Sprite Card;
        public Sprite Begin;
        public Sprite Enter;
        public Sprite Click;
        public string Path;

        public Item(int id, double x, double y, string path)
        {
            Begin = new Sprite(x, y, path);
            Enter = new Sprite(x-0.01, y+0.315, path);
            Click = new Sprite(x - 0.01, y+0.629, path);
            ID = id;
            Path = path;
        }

        public Item(int id, double x, double y, string path, double sinX, double sinY, double cosX, double cosY)
        {
            Begin = new Sprite(x, y, path);
            Enter = new Sprite(x + sinX, y + sinY, path);
            Click = new Sprite(x + cosX, y + cosY, path);
            ID = id;
            Path = path;
        }

        public Item(string path)
        {
            Begin = new Sprite(path);
            Enter = new Sprite(path);
            Click = new Sprite(path);
            Path = path;
        }

        public Item() { }

        public void change_begin(double x, int y)
        {
            Begin = new Sprite(x, y, Path);
        }
        public void change_Enter(int x, int y)
        {
            Enter = new Sprite(x, y, Path);
        }
        public void change_Clik(int x, int y)
        {
            Click = new Sprite(x, y, Path);
        }

        public void change_begin(double pos_x, double pos_y, double with, double height)
        {
            Begin = new Sprite(pos_x, pos_y, with, height, Path);
        }
        public void change_Enter(double pos_x, double pos_y, double with, double height)
        {
            Enter = new Sprite(pos_x, pos_y, with, height, Path);
        }
        public void change_Clik(double pos_x, double pos_y, double with, double height)
        {
            Click = new Sprite(pos_x, pos_y, with, height, Path);
        }


    }
    
    public static class Inicialize
    {
        public static List<Item> Stock_items = new List<Item>(22);
        public static List<Item> Other_items = new List<Item>(22);
        //stok  
        public static Item chain = new Item("/image/sprite_begin.png");
       public static void initializeChain()
        {
            chain.ID = 1;
            chain.change_begin(-0.020, 0.125, 0.23, 0.12);
            chain.Path = "/image/sprite_enter.png";
            chain.change_Enter(-0.020, 0.12, 0.23, 0.12);
            chain.Path = "/image/sprite_click.png";
            chain.change_Clik(-0.020, 0.12, 0.23, 0.12);
            chain.Card = new Sprite("/image/item_stok/chain.png");
            Stock_items.Add(chain);
        }
        //
        public static Item clip = new Item("/image/sprite_begin.png");
        public static void initializeclip()
        {
            clip.ID = 2;
            clip.change_begin(0.195, 0.010, 0.23, 0.12);
            clip.Path = "/image/sprite_enter.png";
            clip.change_Enter(0.195, 0.005, 0.23, 0.12);
            clip.Path = "/image/sprite_click.png";
            clip.change_Clik(0.195, 0.005, 0.23, 0.12);
            clip.Card = new Sprite("/image/item_stok/clip.png");
            Stock_items.Add(clip);
        }
        //
        public static Item compass = new Item("/image/sprite_begin.png");
        public static void initializecompass()
        {
            compass.ID = 3;
            compass.change_begin(-0.020, 0.5, 0.23, 0.12);
            compass.Path = "/image/sprite_enter.png";
            compass.change_Enter(-0.020, 0.495, 0.23, 0.12);
            compass.Path = "/image/sprite_click.png";
            compass.change_Clik(-0.020, 0.495, 0.23, 0.12);
            compass.Card = new Sprite("/image/item_stok/compass.png");
            Stock_items.Add(compass);
        }
        //
        public static Item flashlight = new Item("/image/sprite_begin.png");
        public static void initializeflashlight()
        {
            flashlight.ID = 4;
            flashlight.change_begin(0.185, 0.250, 0.23, 0.12);
            flashlight.Path = "/image/sprite_enter.png";
            flashlight.change_Enter(0.185, 0.245, 0.23, 0.12);
            flashlight.Path = "/image/sprite_click.png";
            flashlight.change_Clik(0.185, 0.245, 0.23, 0.12);
            flashlight.Card = new Sprite("/image/item_stok/flashlight.png");
            Stock_items.Add(flashlight);
        }
        //
        public static Item map = new Item("/image/sprite_begin.png");
        public static void initializemap()
        {
            map.ID = 5;
            map.change_begin(-0.020, 0.385, 0.23, 0.12);
            map.Path = "/image/sprite_enter.png";
            map.change_Enter(-0.020, 0.380, 0.23, 0.12);
            map.Path = "/image/sprite_click.png";
            map.change_Clik(-0.020, 0.380, 0.23, 0.12);
            map.Card = new Sprite("/image/item_stok/map.png");
            Stock_items.Add(map);
        }
        //
        public static Item matches = new Item("/image/sprite_begin.png");
        public static void initializematches()
        {
            matches.ID = 6;
            matches.change_begin(0.185, 0.130, 0.23, 0.12);
            matches.Path = "/image/sprite_enter.png";
            matches.change_Enter(0.185, 0.125, 0.23, 0.12);
            matches.Path = "/image/sprite_click.png";
            matches.change_Clik(0.185, 0.125, 0.23, 0.12);
            matches.Card = new Sprite("/image/item_stok/matches.png");
            Stock_items.Add(matches);
        }
        //
        public static Item package = new Item("/image/sprite_begin.png");
        public static void initializepackage()
        {
            package.ID = 7;
            package.change_begin(-0.020, 0.753, 0.23, 0.12);
            package.Path = "/image/sprite_enter.png";
            package.change_Enter(-0.020, 0.748, 0.23, 0.12);
            package.Path = "/image/sprite_click.png";
            package.change_Clik(-0.020, 0.748, 0.23, 0.12);
            package.Card = new Sprite("/image/item_stok/package.png");
            Stock_items.Add(package);
        }
         //
        public static Item pillowcase = new Item("/image/sprite_begin.png");
        public static void initializepillowcase()
        {
            pillowcase.ID = 8;
            pillowcase.change_begin(-0.020, 0.63, 0.23, 0.12);
            pillowcase.Path = "/image/sprite_enter.png";
            pillowcase.change_Enter(-0.020, 0.625, 0.23, 0.12);
            pillowcase.Path = "/image/sprite_click.png";
            pillowcase.change_Clik(-0.020, 0.625, 0.23, 0.12);
            pillowcase.Card = new Sprite("/image/item_stok/pillowcase.png");
            Stock_items.Add(pillowcase);
        }
        //
        public static Item rope = new Item("/image/sprite_begin.png");
        public static void initializerope()
        {
            rope.ID = 9;
            rope.change_begin(-0.020, 0.255, 0.23, 0.12);
            rope.Path = "/image/sprite_enter.png";
            rope.change_Enter(-0.020, 0.25, 0.23, 0.12);
            rope.Path = "/image/sprite_click.png";
            rope.change_Clik(-0.020, 0.25, 0.23, 0.12);
            rope.Card = new Sprite("/image/item_stok/rope.png");
            Stock_items.Add(rope);
        }
        //
        public static Item tape = new Item("/image/sprite_begin.png");
        public static void initializetape()
        {
            tape.ID = 10;
            tape.change_begin(-0.020, 0.88, 0.23, 0.12);
            tape.Path = "/image/sprite_enter.png";
            tape.change_Enter(-0.020, 0.875, 0.23, 0.12);
            tape.Path = "/image/sprite_click.png";
            tape.change_Clik(-0.020, 0.875, 0.23, 0.12);
            tape.Card = new Sprite("/image/item_stok/tape.png");
            Stock_items.Add(tape);
        }
        //
        public static Item firstKid = new Item("/image/sprite_begin.png");
        public static void initializefirstKid()
        {
            firstKid.ID = 11;
            firstKid.change_begin(-0.020, 0.010, 0.23, 0.12);
            firstKid.Path = "/image/sprite_enter.png";
            firstKid.change_Enter(-0.020, 0.005, 0.23, 0.12);
            firstKid.Path = "/image/sprite_click.png";
            firstKid.change_Clik(-0.020, 0.005, 0.23, 0.12);
            firstKid.Card = new Sprite("/image/item_stok/firstKid.png");
            Stock_items.Add(firstKid);
        }
        //
        public static Item mobil_akb = new Item("/image/sprite_begin.png");
        public static void initializemobil_akb()
        {
            mobil_akb.ID = 12;
            mobil_akb.change_begin(0.185, 0.370, 0.23, 0.12);
            mobil_akb.Path = "/image/sprite_enter.png";
            mobil_akb.change_Enter(0.185, 0.365, 0.23, 0.12);
            mobil_akb.Path = "/image/sprite_click.png";
            mobil_akb.change_Clik(0.185, 0.365, 0.23, 0.12);
            mobil_akb.Card = new Sprite("/image/item_stok/mobil_akb.png");
            Stock_items.Add(mobil_akb);
        }
        
        //other

        public static Item AKB = new Item("/image/sprite_begin.png");
        public static void initializeAKB()
        {
            AKB.ID = 13;
            AKB.change_begin(0.795, 0.38, 0.23, 0.12);
            AKB.Path = "/image/sprite_enter.png";
            AKB.change_Enter(0.795, 0.375, 0.23, 0.12);
            AKB.Path = "/image/sprite_click.png";
            AKB.change_Clik(0.795, 0.375, 0.23, 0.12);
            AKB.Card = new Sprite("/image/Other_Item/AKB.png");
            Other_items.Add(AKB);
        }
        //
        public static Item axe = new Item("/image/sprite_begin.png");
        public static void initializeaxe()
        {
            axe.ID = 14;
            axe.change_begin(0.587, 0.873, 0.23, 0.12);
            axe.Path = "/image/sprite_enter.png";
            axe.change_Enter(0.587, 0.868, 0.23, 0.12);
            axe.Path = "/image/sprite_click.png";
            axe.change_Clik(0.587, 0.868, 0.23, 0.12);
            axe.Card = new Sprite("/image/Other_Item/axe.png");
            Other_items.Add(axe);
        }
        //
        public static Item brew = new Item("/image/sprite_begin.png");
        public static void initializebrew()
        {
            brew.ID = 15;
            brew.change_begin(0.585, 0.5, 0.23, 0.12);
            brew.Path = "/image/sprite_enter.png";
            brew.change_Enter(0.585, 0.495, 0.23, 0.12);
            brew.Path = "/image/sprite_click.png";
            brew.change_Clik(0.585, 0.495, 0.23, 0.12);
            brew.Card = new Sprite("/image/Other_Item/brew.png");
            Other_items.Add(brew);
        }
        //
        public static Item brick = new Item("/image/sprite_begin.png");
        public static void initializebrik()
        {
            brick.ID = 16;
            
            brick.change_begin(0.38, 0.375, 0.23, 0.12);
            brick.Path = "/image/sprite_enter.png";
            brick.change_Enter(0.38, 0.37, 0.23, 0.12);
            brick.Path = "/image/sprite_click.png";
            brick.change_Clik(0.38, 0.37, 0.23, 0.12);
            brick.Card = new Sprite("/image/Other_Item/brick.png");
            Other_items.Add(brick);
        }
        //
        public static Item chest = new Item("/image/sprite_begin.png");
        public static void initializechest()
        {   
            chest.ID = 17;
            chest.change_begin(0.38, 0.75, 0.23, 0.12);
            chest.Path = "/image/sprite_enter.png";
            chest.change_Enter(0.38, 0.745, 0.23, 0.12);
            chest.Path = "/image/sprite_click.png";
            chest.change_Clik(0.38, 0.745, 0.23, 0.12);
            chest.Card = new Sprite("/image/Other_Item/chest.png");
            Other_items.Add(chest);
        }
        //
        public static Item crowbar = new Item("/image/sprite_begin.png");
        public static void initializecrowbar()
        {
            crowbar.ID = 18;
            crowbar.change_begin(0.38, 0.615, 0.23, 0.12);
            crowbar.Path = "/image/sprite_enter.png";
            crowbar.change_Enter(0.38, 0.610, 0.23, 0.12);
            crowbar.Path = "/image/sprite_click.png";
            crowbar.change_Clik(0.38, 0.610, 0.23, 0.12);
            crowbar.Card = new Sprite("/image/Other_Item/crowbar.png");
            Other_items.Add(crowbar);
        }
        //
        public static Item deck = new Item("/image/sprite_begin.png"); 
        public static void initializedeck()
        {
            deck.ID = 19;
            deck.change_begin(0.595, 0.007, 0.23, 0.12);
            deck.Path = "/image/sprite_enter.png";
            deck.change_Enter(0.595, 0.002, 0.23, 0.12);
            deck.Path = "/image/sprite_click.png";
            deck.change_Clik(0.595, 0.002, 0.23, 0.12);
            deck.Card = new Sprite("/image/Other_Item/deck.png");
            Other_items.Add(deck);
        }

        public static Item dice = new Item("/image/sprite_begin.png");
        public static void initializedice()
        {
            dice.ID = 20;
            dice.change_begin(0.79, 0.628, 0.23, 0.12);
            dice.Path = "/image/sprite_enter.png";
            dice.change_Enter(0.79, 0.623, 0.23, 0.12);
            dice.Path = "/image/sprite_click.png";
            dice.change_Clik(0.79, 0.623, 0.23, 0.12);
            dice.Card = new Sprite("/image/Other_Item/dice.png");
            Other_items.Add(dice);
        }
        //
        public static Item ductTape = new Item("/image/sprite_begin.png");
        public static void initializeducTape()
        {   
            ductTape.ID = 21;
            ductTape.change_begin(0.375, 0.248, 0.23, 0.12);
            ductTape.Path = "/image/sprite_enter.png";
            ductTape.change_Enter(0.375, 0.243, 0.23, 0.12);
            ductTape.Path = "/image/sprite_click.png";
            ductTape.change_Clik(0.375, 0.243, 0.23, 0.12);
            ductTape.Card = new Sprite("/image/Other_Item/ductTape.png");
            Other_items.Add(ductTape);
        }
        //
        public static Item extiguisher = new Item("/image/sprite_begin.png");
        public static void initializeextiguisher()
        {
            extiguisher.ID = 22;
            extiguisher.change_begin(0.38, 0.875, 0.23, 0.12);
            extiguisher.Path = "/image/sprite_enter.png";
            extiguisher.change_Enter(0.38, 0.87, 0.23, 0.12);
            extiguisher.Path = "/image/sprite_click.png";
            extiguisher.change_Clik(0.38, 0.87, 0.23, 0.12);
            extiguisher.Card = new Sprite("/image/Other_Item/extinguisher.png");
            Other_items.Add(extiguisher);
        }
        //
        public static Item fridge = new Item("/image/sprite_begin.png"); 
        public static void initializefridge()
        {
            fridge.ID = 23;
            fridge.change_begin(0.795, 0.127, 0.23, 0.12);
            fridge.Path = "/image/sprite_enter.png";
            fridge.change_Enter(0.795, 0.122, 0.23, 0.12);
            fridge.Path = "/image/sprite_click.png";
            fridge.change_Clik(0.795, 0.122, 0.23, 0.12);
            fridge.Card = new Sprite("/image/Other_Item/fridge.png");
            Other_items.Add(fridge);
        }
        //
        public static Item gear = new Item("/image/sprite_begin.png");
        public static void initializegear()
        {
            gear.ID = 24;
            gear.change_begin(0.795, 0.26, 0.23, 0.12);
            gear.Path = "/image/sprite_enter.png";
            gear.change_Enter(0.795, 0.255, 0.23, 0.12);
            gear.Path = "/image/sprite_click.png";
            gear.change_Clik(0.795, 0.255, 0.23, 0.12);
            gear.Card = new Sprite("/image/Other_Item/gear.png");
            Other_items.Add(gear);
        }
        //
        public static Item gus = new Item("/image/sprite_begin.png");
        public static void initializegus()
        {   
            gus.ID = 25;
            gus.change_begin(0.395, 0.007, 0.23, 0.12);
            gus.Path = "/image/sprite_enter.png";
            gus.change_Enter(0.395, 0.002, 0.23, 0.12);
            gus.Path = "/image/sprite_click.png";
            gus.change_Clik(0.395, 0.002, 0.23, 0.12);
            gus.Card = new Sprite("/image/Other_Item/gus.png");
            Other_items.Add(gus);
        }

        public static Item knife = new Item("/image/sprite_begin.png");
        public static void initializeknife()
        {
            knife.ID = 26;
            knife.change_begin(0.79, 0.505, 0.23, 0.12);
            knife.Path = "/image/sprite_enter.png";
            knife.change_Enter(0.79, 0.5, 0.23, 0.12);
            knife.Path = "/image/sprite_click.png";
            knife.change_Clik(0.79, 0.5, 0.23, 0.12);
            knife.Card = new Sprite("/image/Other_Item/knife.png");
            Other_items.Add(knife);
        }
        //
        public static Item pistol = new Item("/image/sprite_begin.png");
        public static void initializepistol()
        {   
            pistol.ID = 27;
            pistol.change_begin(0.585, 0.63, 0.23, 0.12);
            pistol.Path = "/image/sprite_enter.png";
            pistol.change_Enter(0.585, 0.625, 0.23, 0.12);
            pistol.Path = "/image/sprite_click.png";
            pistol.change_Clik(0.585, 0.625, 0.23, 0.12);
            pistol.Card = new Sprite("/image/Other_Item/pistol.png");
            Other_items.Add(pistol);
        }
        //
        public static Item plump = new Item("/image/sprite_begin.png");
        public static void initializeplump()
        {
            plump.ID = 28;
            plump.change_begin(0.595, 0.127, 0.23, 0.12);
            plump.Path = "/image/sprite_enter.png";
            plump.change_Enter(0.595, 0.122, 0.23, 0.12);
            plump.Path = "/image/sprite_click.png";
            plump.change_Clik(0.595, 0.122, 0.23, 0.12);
            plump.Card = new Sprite("/image/Other_Item/plum.png");
            Other_items.Add(plump);
        }
        //
        public static Item roze = new Item("/image/sprite_begin.png");
        public static void initializeroze()
        {
            roze.ID = 29;
            roze.change_begin(0.395, 0.127, 0.23, 0.12);
            roze.Path = "/image/sprite_enter.png";
            roze.change_Enter(0.395, 0.122, 0.23, 0.12);
            roze.Path = "/image/sprite_click.png";
            roze.change_Clik(0.395, 0.122, 0.23, 0.12);
            roze.Card = new Sprite("/image/Other_Item/roze.png");
            Other_items.Add(roze);
        }
        //
        public static Item stew = new Item("/image/sprite_begin.png");
        public static void initializestew()
        {
            stew.ID = 30;
            stew.change_begin(0.795, 0.007, 0.23, 0.12);
            stew.Path = "/image/sprite_enter.png";
            stew.change_Enter(0.795, 0.002, 0.23, 0.12);
            stew.Path = "/image/sprite_click.png";
            stew.change_Clik(0.795, 0.002, 0.23, 0.12);
            stew.Card = new Sprite("/image/Other_Item/stew.png");
            Other_items.Add(stew);
        }
        //
        public static Item straych = new Item("/image/sprite_begin.png");
        public static void initializestraych()
        {
            straych.ID = 31;
            straych.change_begin(0.587, 0.753, 0.23, 0.12);
            straych.Path = "/image/sprite_enter.png";
            straych.change_Enter(0.587, 0.748, 0.23, 0.12);
            straych.Path = "/image/sprite_click.png";
            straych.change_Clik(0.587, 0.748, 0.23, 0.12);
            straych.Card = new Sprite("/image/Other_Item/straych.png");
            Other_items.Add(straych);
        }
        //
        public static Item tent = new Item("/image/sprite_begin.png");
        public static void initializetent()
        {
            tent.ID = 32;
            tent.change_begin(0.595, 0.255, 0.23, 0.12);
            tent.Path = "/image/sprite_enter.png";
            tent.change_Enter(0.595, 0.25, 0.23, 0.12);
            tent.Path = "/image/sprite_click.png";
            tent.change_Clik(0.595, 0.25, 0.23, 0.12);
            tent.Card = new Sprite("/image/Other_Item/tent.png");
            Other_items.Add(tent);
        }
        //
        public static Item rull = new Item("/image/sprite_begin.png");
        public static void initializerull()
        {
            rull.ID = 33;
            rull.change_begin(0.58, 0.375, 0.23, 0.12);
            rull.Path = "/image/sprite_enter.png";
            rull.change_Enter(0.58, 0.37, 0.23, 0.12);
            rull.Path = "/image/sprite_click.png";
            rull.change_Clik(0.58, 0.37, 0.23, 0.12);
            rull.Card = new Sprite("/image/Other_Item/rull.png");
            Other_items.Add(rull);
        }
        //
        public static Item wheel = new Item("/image/sprite_begin.png");
        public static void initializewheel()
        {
            wheel.ID = 34;
            wheel.change_begin(0.38, 0.495, 0.23, 0.12);
            wheel.Path = "/image/sprite_enter.png";
            wheel.change_Enter(0.38, 0.49, 0.23, 0.12);
            wheel.Path = "/image/sprite_click.png";
            wheel.change_Clik(0.38, 0.49, 0.23, 0.12);
            wheel.Card = new Sprite("/image/Other_Item/wheel.png");
            Other_items.Add(wheel);
        }
       
        public static void initializeItem()
        {
            initializeChain(); //0
            initializestew(); 
            initializestraych();//2
            initializetent();
            initializerull();//4
             initializewheel();
             initializeroze();//6
             initializeplump();
             initializepistol();//8
             initializeknife();
             initializegus();//10
             initializegear();
             initializefridge();//12
             initializeextiguisher();
             initializeducTape();//14
             initializedice();
             initializedeck();//16
             initializecrowbar(); 
             initializebrik();//18
             initializebrew();
             initializeaxe();//20
             initializeAKB();
             initializemobil_akb();//22
             initializefirstKid();
             initializetape();//24
             initializerope();
             initializepillowcase();//26
             initializepackage();
             initializematches();/*28 */
            initializechest();
            initializemap();//30
             initializeflashlight();
             initializecompass();//32
             initializeclip(); 
           
            Player.deck_item = Stock_items;
        }

    }

}
