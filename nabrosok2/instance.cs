using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace nabrosok2
{

    public class cards
    {
        public string path = "";

        public int ID;
        public Sprite bacground;
        public DropShadowEffect effect = new DropShadowEffect();
        public DropShadowEffect effect2 = new DropShadowEffect();

        public cards(string path)
        {
            bacground = new Sprite(path);
            effect.BlurRadius = 5;
            effect.Color = Colors.GreenYellow;
            effect.ShadowDepth = 5;
            effect.Direction = 220;

            effect2.BlurRadius = 0;
            effect2.Color = Colors.Cyan;
            effect2.ShadowDepth = 0;
            effect2.Direction = 220;
        }
    }

    public  class instance
    {
        public bool finishLocation = false;
        public string firstReaction = "ТЕСТОВЫЙ ТЕСТ";
        public string secondReaction = "";
        public bool bonuslocation = false;
        private bool firstTime = true;
        public string path = "";
        public Item Present;
        public Item Bonus;
        public int ID;
        public Sprite bacground;
        public string nice = "";
        public string fail = "";
        public int id_item = 0;
       
        public instance(string path)
        {
            bacground = new Sprite(path);
        }
        
        public string instalReaction()
        {
            if (bonuslocation)
            {
                if (Bonus != null)
                {
                    if (Player.inventory.Count < 5)
                    {
                        firstReaction = nice;
                        Player.inventory.Add(Present);
                        Player.inventory.Add(Bonus);
                        Locations.location.finish = true;
                    }
                    else
                    {
                        return "Здесь столько всего полезного, но ты не можешь все унести и бежишь с позором!";
                    }
                }
                else
                {
                    if (Player.inventory.Count < 6)
                    {
                        firstReaction = nice;
                        Player.inventory.Add(Present);


                        Locations.location.finish = true;
                        return firstReaction;
                    }
                    else
                    {
                        return "Здесь есть кое-что, но карманы прижимают твое лицо к земле. Не унести больше!";
                    }
                }
                return "Ты не можешь все унести и бежишь с позором!";
            }
            else
            {
                firstReaction = fail;
                return firstReaction;
            }
        }
        //это должно работать по нажатию кнопки
        public bool chekItem(Item item) 
        {
            
                firstTime = false;
                if (item.ID == id_item && Bonus != null)
                {
                    if (Player.inventory.Count < 6)//личняя проверка
                    { 
                        finishLocation = true;
                        Locations.location.finish = true;
                        Locations.location.writeText(nice);
                        Player.inventory.Remove(item);
                        Player.inventory.Add(Present);
                        Present = null;
                    // cards card = InicializeCarad.cardList.Find(x => x.ID == Locations.map.adress);
                    // Locations.map.Dump.Remove(card);
                    if (item.ID == 11) Bonus.usules = true;
                    Player.inventory.Add(Bonus);
                        Bonus = null;
                    
                        Locations.location.invetory_drow();
                        return true;
                    }
                     else
                    {
                    Locations.location.writeText("Ты не можешь все унести и бежишь с позором!");
                    return false;
                     }
                }
                else if (item.ID == id_item && Present != null)
                {
                finishLocation = true;
                Locations.location.finish = true;
                Locations.location.writeText(nice);
                Player.inventory.Remove(item);
                Player.inventory.Add(Present);
                Present = null;
                Locations.location.invetory_drow();
                 
                return true;
                }

            List<string> lose = new List<string>() 
            { "Нелься сотворить здесь!", "Безумец?", "Ты что творишь?", "Очевидно, что нет!",
             "Это не подходит!", "И что ты будешь с этим делать?", "Это тебя не спасет!", "Хватит дурачиться!" };
           
            Random rand = new Random();
            int x = rand.Next(lose.Count);
            Locations.location.writeText(lose[x]);
                return false;
            
        }
       

        public void chekFullInventory() { }

    }

    public static class InitializeInstance
    {
        public static List<instance> instances = new List<instance>();
       
        public static instance barn = new instance("/instance/barn_2.jpg");
        public static instance bike_crush = new instance("/instance/bike_awaria_2.jpg");
        public static instance bridge = new instance("/instance/bridg_2.jpg");
        public static instance bunker = new instance("/instance/bunker_2.jpg");
        public static instance camp_woodman = new instance("/instance/camp_woodman_2.jpg");
        public static instance cave = new instance("/instance/cave_2.jpg");
        
        public static instance crossroad = new instance("/instance/crossroad_2.jpg");
        public static instance skyDiwer = new instance("/instance/dead_skydiwer_2.jpg");
        public static instance destroyedCamp = new instance("/instance/destroyed_camp_2.jpg");
        public static instance gate = new instance("/instance/gate_2.jpg");
        public static instance hunterHause = new instance("/instance/hunter_hause_2.jpg");
        public static instance oldCamper = new instance("/instance/old_camper_2.jpg");
        public static instance oldRoad = new instance("/instance/old_road_2.jpg");
        public static instance sheep = new instance("/instance/sheep_2.jpg");
        public static instance swamp = new instance("/instance/spwamp_2.jpg");
        public static instance stream = new instance("/instance/stream_2.jpg");
        public static instance tower = new instance("/instance/tower_2.jpg");
        public static instance tractor = new instance("/instance/tractor_2.jpg");
        public static instance wood = new instance("/instance/wood_2.jpg");

        public static void initialize()
        {
            cave.ID = 0;
            cave.id_item = 4;
            cave.Present = Inicialize.brew;
            cave.nice = "Фонарик разгоняет мрак под каменными сводами пещеры. В глубине ее вы замечаете какой-то блеск и подходите ближе. Разворошив песок, вы находите бутылку с мутной жидкостью. Сомнений быть не может, это самогон из сливовой браги. Точно такой же гнал ваш дедушка. Этой штукой можно заправлять самолеты.";
            cave.fail = "Идти в темную пещеру вы не отваживаетесь. Может быть, в следующий раз наберетесь смелости.";

            bridge.ID = 1;
            bridge.id_item = 26;
            bridge.Present = Inicialize.deck;
            bridge.nice = "Вам кажется, что навесной мост слишком опасен, и вы решаете взять на себя ответственность за ликвидацию угрозы. Армейским ножом вы легко разрезаете канаты, и мост опадает. С чувством выполненного долга вы берете с собой трофей - одну из дощечек бывшей переправы.";
            bridge.fail = "Идти на ту сторону по обветшалому навесному мосту слишком опасно.";

            barn.ID = 2;
            barn.id_item = 25;
            barn.Present = Inicialize.plump;
            barn.nice = "Можно было бы попробовать выбить дверь плечом, но так легко пораниться. К счастью, у вас собой бензин. Вы абсолютно уверены в том, что делаете: поливаете дверь горючей жидкостью и бьете металлической канистрой по дужке замка. Высекается искра, и вспыхивает пожар, но вы быстры и уже на безопасном расстоянии. Когда сарай сгорает полностью, вы с облегчением обнаруживаете, что ценные вещи не пострадали, и, уходя, берете с собой пакет с перьями.";
            barn.fail = "У вас нет никаких идей, что делать с закрытой дверью сарая и вы решаете отложить этот вопрос.";

            wood.ID = 3;
            wood.id_item = 9;
            wood.Present = Inicialize.chest;
            wood.nice = "Молния отбила у толстенного дерева верхушку. Вы бы с удовольствием посмотрели, что там внутри ствола, поэтому завязываете лассо и закидываете его на сук над вами, поднимаетесь и находите закрытый металлический ящик.";
            wood.fail = "Молния отбила у толстенного дерева верхушку. Вы бы с удовольствием посмотрели, что там внутри ствола, но туда не залезть.";

            tractor.ID = 4;
            tractor.id_item = 14;
            tractor.Present = Inicialize.AKB;
            tractor.Bonus = Inicialize.dice;
            tractor.nice = "За неимением гаечного ключа для демонтажных работ идеально подойдет топор, вы берете его на перевес и приступаете к работе. Гнилое железо трактора легко поддается, и вскоре вы уже являетесь обладателем тракторного аккумулятора. Еще вы замечаете мягкие кубики на руле трактора и не можете пройти мимо этой милой детали.";
            tractor.fail = "Скорее всего там под гнилым железом кузова трактора есть что-то, что пригодится вам в ремонте машины. Но для работы нужен специальный инструмент.";

            hunterHause.ID = 5;
            hunterHause.id_item = 30;
            hunterHause.Present = Inicialize.fridge;
            hunterHause.nice = "Дверь не открыта. Принтер (МФУ) все еще на месте. Вы начинаете понимать и лезете в сумку за банкой тушонки. Надпись на крышке гласит: “распечатывать здесь”. Вы кладете банку в МФУ, чтобы распечать ее. "+
                "Устройство издает скрежащий звук, дверь открывается, и из домика выходит организатор. У него в руках огромный холодильник, который он протягивает вам со словами: “Ты знаешь, что с этим делать”. Дверь за ним закрывается, а у вас теперь есть холодильник.";
            hunterHause.fail = "Дверь закрыта. В нише справа от нее вы видите принтер (МФУ), а на него указывает стрелка, приклеенная к стене. Вы совершенно уверены, что перед вами загадка, но как ее разгадать непонятно.";

            tower.ID = 6;
            tower.id_item = 1;
            tower.Present = Inicialize.extiguisher;
            tower.nice = "Подняться на высоченную вышку никак нельзя - нет лестницы. Но у вас собой велосипедная цепь, а одна из опор вышки сильно тоньше остальных. По телевизору вы видели, как ствол дерева пилили чем-то вроде цепи. Вы не хотите задумываться, была ли это такая специальная пила, вам не до тонкостей процесса. Спустя несколько часов вышка наконец падает и в ее руинах вы находите огнетушитель. Вы совершенно собой довольны.";
            tower.fail = "Подняться на высоченную вышку никак нельзя - нет лестницы.";

            stream.ID = 7;
            stream.id_item = 7;
            stream.Present = Inicialize.roze;
            stream.nice = "Вода в ручье такая чистая, что хочется припасть к ней и напиться. На дне что-то сверкает, какое-то сокровище. Тут вам очень пригождается пакет, вы зачерпывате им словно сачком и достаете со дна розочку в оргстекле, смаргивая слезы ностальгии, вы с нежностью кладете ее в нагрудный карман.";
            stream.fail = "Вода в ручье такая чистая, что хочется припасть к ней и напиться. На дне что-то сверкает, какое-то сокровище. Достать его и не замочить рукава, к сожалению, невозможно.";

            bunker.ID = 8;
            bunker.id_item = 2;
            bunker.Present = Inicialize.pistol;
            bunker.Bonus = Inicialize.stew;
            bunker.nice = "То, что вы приняли сначала за холм, оказалось бомбоубежищем. Нет никакой науки в использовании скрепки для взлома, поэтому через две минуты замок двери открыт. В бомбоубежище вы находите сигнальный пистолет и целую банку тушенки";
            bunker.fail = "То, что вы приняли сначала за холм, оказалось бомбоубежищем. Вы дергаете за ручку, но дверь не поддается.";

            destroyedCamp.ID = 9;
            destroyedCamp.id_item= 27;
            destroyedCamp.Present = Inicialize.tent;
            destroyedCamp.nice = "На полянке в сени раскидистого дерева расположилась большая палатка, в брезенте которой зияют черные дыры. Нет никаких сомнений, что стоянка подверглась нападению хищника. Вы отлично знаете, что животные боятся огня, и поэтому стреляете в воздух из сигнального пистолета, обеспечивая тем самым свою безопасность. Избавленная от мусора палатка компактно складывается и помещается в вашем рюкзаке.";
            destroyedCamp.fail = "На полянке в сени раскидистого дерева расположилась большая палатка, в брезенте которой зияют черные дыры. Нет никаких сомнений, что стоянка подверглась нападению хищника. А с дикой природой заигрывать не стоит, и поэтому вы аккуратно покидаете опасную зону.";

            gate.ID = 10;
            gate.id_item = 33;
            gate.Present = Inicialize.crowbar;
            gate.nice = "Сбоку от странных ворот в лесу установлена лебедка. Эти вещи не могут быть не взаимосвязаны - для грамотного человека тут нет никакой загадки. Вы берете руль от велосипеда, крепите к лебедке и крутите. Ворота открываются. Что бы ни было за ними, оно заросло густым кустарником. Столб правой створки подперт ломом. Лом вам пригодится, вы выдергиваете его, и воротина падает.";
            gate.fail = "Сбоку от странных ворот в лесу установлена лебедка. Эти вещи не могут быть не взаимосвязаны, но как их связать вы не знаете.";

            camp_woodman.ID = 11;
            camp_woodman.bonuslocation = true;
            camp_woodman.Present = Inicialize.straych;
            camp_woodman.Bonus = Inicialize.axe;
            camp_woodman.nice = "Вдруг среди леса показывается проплешина, белеют спилы. Вы осматриваетесь. В один из пней воткнут добротный топор, а около сложенной поленницы блестит рулон стрейча. Ваш опыт работы в офисе подсказывает, что стрейч используется для связывания спиленных стволов и бревен. Вы берете эти полезные вещи с собой.";
            

            crossroad.ID = 12;
            crossroad.bonuslocation = true;
            crossroad.Present = Inicialize.brick;
            crossroad.nice = "Не обладая достаточной информацией о представленных перепутьем вариантах, вы решаете не выбирать и уже собираетесь отправиться обратно, когда замечаете в траве красивый красный кирпич. Как бы то ни было, а кирпич в хозяйстве пригодится.";
           

            oldCamper.ID = 13;
            oldCamper.bonuslocation = true;
            oldCamper.Present = Inicialize.ductTape;
            oldCamper.nice = "В буераке, в который вы спустились по пологому склону, оказывается давным-давно брошенный бивуак. Над кострищем косо стоит сгнивший мангал, неподалеку в землю врос ящик с каким-то хламом, покопавшись в нем, вы находите изоленту - незаменимую в походе вещь.";
            

            bike_crush.ID = 14;
            bike_crush.bonuslocation = true;
            bike_crush.Present = Inicialize.rull;
            bike_crush.nice = "Сложно понять, откуда посреди леса может оказаться сгнивший велосипед, тем не менее он есть. Все указывает на аварию: транспортное средство врезалось в дерево, после чего свалилось в канавку рядом. От удара колесо сильно погнулось, что сделало велосипед непригодным к использованию. Вам сломанный велосипед без надобности, но довольно приличный руль от него вы на всякий случай забираете с собой.";
            

            swamp.ID = 15;
            swamp.bonuslocation = true;
            swamp.Present = Inicialize.wheel;
            swamp.nice = "По болоту нужно ходить с длинным шестом, вы видели это в кино. Шеста у вас с собой нет, поэтому дальнейший путь закрыт. Однако, уходить с пустыми руками вам не придется - как водится, на болоте всегда можно найти что-то полезное, в вашем случае на болоте лежит хорошее колесо. Как раз его-то и не хватает для ремонта автомобиля.";


            sheep.ID = 16;
            sheep.bonuslocation = true;
            sheep.Present = Inicialize.gus;
            sheep.nice = "Грустное и поэтичное зрелище открывается вам на берегу пересохшей реки, в которой когда-то купались дети, а крестьяне ловили рыбу. Теперь здесь в абсолютном одиночестве доживает свой век чахлая лодка. Предавшись недолгим размышлениям, вы заглядываете в лодку, прежде чем идти дальше, и находите канистру бензина.";


            skyDiwer.ID = 17;
            //skyDiwer.bonuslocation = true;
            skyDiwer.id_item = 11;
            skyDiwer.Present = Inicialize.knife;
            skyDiwer.Bonus = Inicialize.firstKid;
            
            skyDiwer.fail = "Вероятность того, что на вас из густой кроны дерева свалится не совсем живой парашютист довольно высока, и все равно вы немного пугаетесь и вздрагиваете. Должно быть, парашютист был тут не один год - это одетый в штаны и куртку скелет.";
            //skyDiwer.nice = "Вероятность того, что на вас из густой кроны дерева свалится не совсем живой парашютист довольно высока, и все равно вы немного пугаетесь и вздрагиваете. Должно быть, парашютист был тут не один год - это одетый в штаны и куртку скелет. На его поясе вы видите нож и берете себе.\"Твой бой окончен, брат\", -думаете вы, - \"а мне это пригодится\".";
            skyDiwer.nice = "Вы все же не теряете надежды и пытаетесь подлечить раненого летуна. И о чудо! В благодарность вы получаете нож!\"Твой бой еще не окончен, брат\", -думаете вы, - \"Спасибо! Мне это пригодится\".";

            oldRoad.ID = 18;
            oldRoad.bonuslocation = true;
            oldRoad.Present = Inicialize.gear;
            oldRoad.nice = "Спотыкаясь, вы вываливаетесь из кустов на заросшую колею. Она никуда не ведет, теряясь в зарослях. Из сухой грязи торчит ржавая шестеренка. Вы берете ее с собой, предполагая что она к чему-то может подойти, и идете дальше";

            instances.Add(barn);
            instances.Add(bike_crush);
            instances.Add(bridge);
            instances.Add(bunker);
            instances.Add(camp_woodman);
            instances.Add(cave);
            instances.Add(crossroad);
            instances.Add(skyDiwer);
            instances.Add(destroyedCamp);
            instances.Add(gate);
            instances.Add(hunterHause);
            instances.Add(oldCamper);
            instances.Add(oldRoad);
            instances.Add(sheep);
            instances.Add(swamp);
            instances.Add(stream);
            instances.Add(tower);
            instances.Add(tractor);
            instances.Add(wood);

            /*for (int i = 0; i < 19; i++)
            {
                instances[i].ID = i;
            }*/
        
        }


    }
    public static class InicializeCarad
    {

        public static cards barn = new cards("/cart_instance/barn.png");
        public static cards bike_crush = new cards("/cart_instance/bike_awaria.png");
        public static cards bridge = new cards("/cart_instance/bridg.png");
        public static cards bunker = new cards("/cart_instance/bunker.png");
        public static cards camp_woodman = new cards("/cart_instance/camp_woodman.png");
        public static cards cave = new cards("/cart_instance/cave.png");
        public static cards crossroad = new cards("/cart_instance/crossroad.png");
        public static cards skyDiwer = new cards("/cart_instance/dead_skydiwer.png");
        public static cards destroyedCamp = new cards("/cart_instance/destroyed_camp.png");
        public static cards gate = new cards("/cart_instance/gate.png");
        public static cards hunterHause = new cards("/cart_instance/hunter_hause.png");
        public static cards oldCamper = new cards("/cart_instance/old_camper.png");
        public static cards oldRoad = new cards("/cart_instance/old_road.png");
        public static cards sheep = new cards("/cart_instance/sheep.png");
        public static cards swamp = new cards("/cart_instance/swamp.png");
        public static cards stream = new cards("/cart_instance/stream.png");
        public static cards tower = new cards("/cart_instance/tower.png");
        public static cards tractor = new cards("/cart_instance/tractor.png");
        public static cards wood = new cards("/cart_instance/wood.png");

        public static List<cards> cardList = new List<cards>();

        public static void initialize()
        {
            cardList.Add(barn);
            cardList.Add(bike_crush);
            cardList.Add(bridge);
            cardList.Add(bunker);
            cardList.Add(camp_woodman);
            cardList.Add(cave);
            cardList.Add(crossroad);
            cardList.Add(skyDiwer);
            cardList.Add(destroyedCamp);
            cardList.Add(gate);
            cardList.Add(hunterHause);
            cardList.Add(oldCamper);
            cardList.Add(oldRoad);
            cardList.Add(sheep);
            cardList.Add(swamp);
            cardList.Add(stream);
            cardList.Add(tower);
            cardList.Add(tractor);
            cardList.Add(wood);

            for (int i = 0; i < 19; i++)
            {
                cardList[i].ID = i;
            }

        }

    }


}
