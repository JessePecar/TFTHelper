using System;
using System.ComponentModel;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xam.Forms.VideoPlayer;



namespace TFTHelper.Views
{
    public class Variables
    {
        /*
            Anytime a new champion gets added, only change this number to change the while loops, because using champions.Length does not work
            as intended *I think because it is a multidemensional array*

             */
             
        public const int champCount = 51;
    }
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
        champTypeHolder[] teamBuilder = new champTypeHolder[21];

        String[,] champions = {
            {"Aatrox", "3", "demon", "blademaster", "None","aatrox-the-darkin-blade", "Aatrox cleaves the area in front of him, dealing 350/600/850 damage to enemies inside it."},
            {"Ahri", "2", "wild", "sorcerer", "None","ahri-orb-of-deception", "Ahri fires an orb in a line that returns to her, dealing 100/175/250 damage to enemies it passes through." },
            {"Akali", "4", "ninja", "assassin", "None","akali-five-point-strike", "Akali throws shurikens in front of her, dealing 200/375/550 damage."},
            {"Anivia", "5", "glacial", "elementalist", "None","anivia-glacial-storm", "Anivia channels a large hailstorm for 8 second, dealing 700/950/1200 total damage and slowing the attack speed of enemies inside of it by 50%/70%/90%."  },
            {"Ashe", "3", "glacial", "ranger", "None","ashe-enchanted-crystal-arrow", "Shoots a fuck you arrow"  },
            {"AurelionSol", "4", "dragon", "sorcerer", "None","aurelion-sol-voice-of-light", "Aurelion Sol channels for 0.35 seconds, then breathes a large blast of fire in a line, dealing 250/450/650 damage to enemies."  },
            {"Blitzcrank", "2", "robot", "brawler", "None","blitzcrank-rocket-grab" , "Blitzcrank pulls the furthest enemy to him and knocks them up for 2.5 seconds and dealing 100/450/800 damage." },
            {"Brand", "4", "demon", "elementalist", "None","brand-pyroclasm", "Brand launches a bouncing 4/4/6 fireball, dealing 200/300/400 damage enemies hit."},
            {"Braum", "2", "glacial", "guardian", "None","braum-unbreakable", "Braum gains a barrier for 4 seconds that blocks 60%/75%/90% of incoming damage."},
            {"Chogath", "4", "void", "brawler", "None","chogath-rupture", "Cho'gath ruptures an area after 1.5 seconds, stunning for 2/2.5/3 seconds and dealing 200/400/600 damage to enemies inside of it."},
            {"Darius", "1", "imperial", "knight", "None","darius-decimate", "Less exciting beyblade"},
            {"Draven", "4", "imperial", "blademaster", "None","draven-spinning-axes", "Draven gains bonus 150%/200%/250% on-hit damage and 30%/45%/60% Attack Speed. Stacks up to two times. Lasts up to 8 seconds."  },
            {"Elise", "2", "demon", "shapeshifter", "None","elise-spider-form", "Elise summons 2/3/4 Spiderlings that have 500 health and transforms, gaining 60%/90%/120% Lifesteal."},
            {"Evelynn", "3", "demon", "assassin", "None","evelynn-last-caress", "Evelynn deals 200/250/300 damage to the 3 closest enemies and teleports away. Damage is increased by 3x/4x/5x against enemies below 50% health."  },
            {"Fiora", "1", "noble", "blademaster", "None","fiora-riposte", "Fiora becomes immune to damage and spells for 1.5 seconds. After a short delay, she stuns for 1.5 seconds and deals 100/175/250 damage the closest enemy."  },
            {"Gangplank", "3", "pirate", "blademaster", "gunslinger","gangplank-powder-kegs", "Gangplank periodically creates barrels. On cast, Gangplank detonates the barrels, dealing 200/325/450 damage to nearby enemies."  },
            {"Garen", "1", "noble", "knight", "None","garen-judgement", "It's beyblade time"  },
            {"Gnar", "4", "yordle", "shapeshifter", "wild","gnar-gnar", "Gnar transforms, gaining 300/600/900 Health, 30/60/90 Attack Damage and jumping behind the furthest enemy, dealing 200/300/400 damage and stunning for 2 seconds to enemies nearby."  },
            {"Graves", "1", "pirate", "gunslinger", "None","graves-buckshot", "Graves' attacks deal  5%/10%/15% increased damage and hit all enemies in front of him."  },
            {"Karthus", "5", "phantom", "sorcerer", "None","karthus-requiem", "Oprah of death"  },
            {"Kassadin", "1", "void", "sorcerer", "None","kassadin-nether-blade", "Honorary demon"  },
            {"Katarina", "3", "imperial", "assassin", "None","katarina-death-lotus", "Spins right round"  },
            {"Kayle", "5", "noble", "knight", "None","kayle-divine-judgement", "Wanna see someone never die?"  },
            {"Kennen", "3", "ninja", "yordle", "elementalist","kennen-slicing-maelstrom", "Electric slide in a circle"  },
            {"Khazix", "1", "void", "assassin", "None","khazix-taste-their-fear", "Fuck this one person in particular"  },
            {"Kindred", "4", "phantom", "ranger", "None","kindred-lambs-respite", "Erryone lives, except the enemy"  },
            {"Leona", "4", "noble", "guardian", "None","leona-solar-flare", "Stunning!"  },
            {"Lissandra", "2", "glacial", "elementalist", "None","lissandra-frozen-tomb", "Cold hearted"  },
            {"Lucian", "2", "noble", "gunslinger", "None","lucian-relentless-pursuit", "dashy boy"  },
            {"Lulu", "2", "yordle", "sorcerer", "None","lulu-wild-growth", "Oh! The things she could grow"  },
            {"MissFortune", "5", "pirate", "gunslinger", "None","miss-fortune-bullet-time", "Matrix in full motion"  },
            {"Mordekaiser", "1", "phantom", "knight", "None","mordekaiser-obliterate", "Sometimes can be useful"  },
            {"Morgana", "3", "demon", "sorcerer", "None","morgana-soul-shackles", "Best frontline move"  },
            {"Nidalee", "1", "wild", "shapeshifter", "None","nidalee-primal-surge", "I primal your surge"  },
            {"Poppy", "3", "yordle", "knight", "None","poppy-keepers-verdict", "Little one has a big hammer"  },
            {"Pyke", "2", "pirate", "assassin", "None","pyke-phantom-undertow", "Dashy boy with stunny boy"  },
            {"RekSai", "2", "void", "brawler", "None","reksai-burrow", "Good girl! Go burrow and regain health!"  },
            {"Rengar", "3","wild", "assassin", "None","rengar-savagery", "Jumpy, Stabby boy"  },
            {"Sejuani", "4", "glacial", "knight", "None","sejuani-glacial-prison", "She makes a bunch of people stunning after a delay"  },
            {"Shen", "2", "ninja", "blademaster", "None","shen-spirits-refuge", "Greased up, deaf guy of TFT"  },
            {"Shyvana", "3", "dragon", "shapeshifter", "None","shyvana-dragons-descent", "What the GoT dragons should be"  },
            {"Swain", "5", "demon", "imperial", "shapeshifter","swain-demonflare", "Summons his inner dragon trainer"  },
            {"Tristana", "1", "yordle", "gunslinger", "None","tristana-explosive-charge", "Trist gives them the boom-bewm"  },
            {"TwistedFate", "2", "pirate", "sorcerer", "None","twisted-fate-pick-a-card", "TFW you pick a blue card"  },
            {"Varus", "2", "demon", "ranger", "None","varus-piercing-arrow", "Vayne + Aurelion Sol = Varus"  },
            {"Vayne", "1", "noble", "ranger", "None","vayne-silver-bolts", "Pew, Pew, Oww!"  },
            {"Veigar", "3", "yordle", "sorcerer", "None","veigar-primordial-burst", "I see you have a level on- nevermind"  },
            {"Volibear", "3", "glacial", "brawler", "None","volibear-thunder-claws", "Big, Boy Polar Bear"  },
            {"Warwick", "1", "wild", "brawler", "None","warwick-infinite-duress", "Swipy boy"  },
            {"Yasuo", "5", "exile", "blademaster", "None","yasuo-steel-tempest", "At least he doesnt have the dash or infinite knockup"  },
            {"Zed", "2", "ninja", "assassin", "None","zed-razor-shuriken", "Just testing his accuracy" } };
        
        //https://cdn.leagueofgraphs.com/img/tft/origins/wild.png
        //https://cdn.leagueofgraphs.com/img/tft/classes/blademaster.png
        //https://d1v0ze4r2jabid.cloudfront.net/abilities/ahri-orb-of-deception.png
        public AboutPage()
        {
            
            InitializeComponent();
            SetUpChampionBar();
            Origin();
            Classes();
            championNameBox.WidthRequest = App.ScreenWidth * 0.5;
            /*
            Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");
            Console.WriteLine(champions.Length);
            Console.WriteLine("***");
            Console.WriteLine("**");
            Console.WriteLine("*");
            */

            String[] temp = { "Demon", "Blademaster", "Ranger", "Ninja", "Wild", "Sorcerer", "Assassin", "Glacial", "Robot", "Dragon", "Brawler",
            "Void", "Noble", "Imperial", "Phantom", "Exile", "Knight", "Yordle", "Elementalist", "Gunslinger", "Pirate" };
            for(int i = 0; i < teamBuilder.Length; i++)
            {
                teamBuilder[i] = new champTypeHolder(temp[i], 0);
            }
            //Setup the icons for the bonuses

        }
        /*https://cdn.leagueofgraphs.com/img/tft/origins/demon.png*/

        private void SetUpChampionBar()
        {
            for(int i = 0; i < Variables.champCount; i++)
            {
                ImageButton temp = new ImageButton()
                {
                    Source = ImageSource.FromUri(new Uri("https://d1v0ze4r2jabid.cloudfront.net/characters/" + champions[i,0] + ".png")),
                    WidthRequest = 60,
                    HeightRequest = 50,
                    BorderWidth = 2,
                    Aspect = Aspect.AspectFill
                };
                switch (champions[i,1])
                {
                    case ("1"):
                        temp.BorderColor = Color.Silver;
                        temp.BackgroundColor = Color.Silver;
                        break;
                    case ("2"):
                        temp.BorderColor = Color.ForestGreen;
                        temp.BackgroundColor = Color.ForestGreen;
                        break;
                    case ("3"):
                        temp.BorderColor = Color.DarkBlue;
                        temp.BackgroundColor = Color.DarkBlue;
                        break;
                    case ("4"):
                        temp.BorderColor = Color.Purple;
                        temp.BackgroundColor = Color.Purple;
                        break;
                    case ("5"):
                        temp.BorderColor = Color.Gold;
                        temp.BackgroundColor = Color.Gold;
                        break;
                    default:
                        temp.BorderColor = Color.Fuchsia;
                        temp.BackgroundColor = Color.Fuchsia;
                        break;
                }

                string tempName = champions[i,0];
                
                temp.Clicked += (s, e) => Handle_ChampionClick(s,e,tempName);
                ChampionContainer.Children.Add(temp);
            }
        }

        private void filteredChampionBar(String filterType)
        {
            filterType = filterType.ToLower();
            for (int i = 0; i < Variables.champCount; i++)
            {
                if (champions[i, 2].Equals(filterType) || champions[i, 3].Equals(filterType) || champions[i,4].Equals(filterType)) {
                    ImageButton temp = new ImageButton()
                    {
                        Source = ImageSource.FromUri(new Uri("https://d1v0ze4r2jabid.cloudfront.net/characters/" + champions[i, 0] + ".png")),
                        WidthRequest = 60,
                        HeightRequest = 50,
                        BorderWidth = 2,
                        Aspect = Aspect.AspectFill
                    };

                    switch (champions[i, 1])
                    {
                        case ("1"):
                            temp.BorderColor = Color.Silver;
                            temp.BackgroundColor = Color.Silver;
                            break;
                        case ("2"):
                            temp.BorderColor = Color.ForestGreen;
                            temp.BackgroundColor = Color.ForestGreen;
                            break;
                        case ("3"):
                            temp.BorderColor = Color.DarkBlue;
                            temp.BackgroundColor = Color.DarkBlue;
                            break;
                        case ("4"):
                            temp.BorderColor = Color.Purple;
                            temp.BackgroundColor = Color.Purple;
                            break;
                        case ("5"):
                            temp.BorderColor = Color.Gold;
                            temp.BackgroundColor = Color.Gold;
                            break;
                        default:
                            temp.BorderColor = Color.Fuchsia;
                            temp.BackgroundColor = Color.Fuchsia;
                            break;
                    }
                    string tempName = champions[i, 0];
                    temp.Clicked += (s, e) => Handle_ChampionClick(s, e, tempName);
                    ChampionContainer.Children.Add(temp);
                }
            }
        }
        private void Handle_ClearClick(Object se, EventArgs ea, StackLayout obj, String name)
        {
            obj.Children.Clear();
            for (int i = 0; i < Variables.champCount; i++) {
                if (champions[i, 0].Equals(name))
                {

                }
            }
            compHolder.Children.Remove(obj);
        }

        private void Handle_BoxClose(Object se, EventArgs ea)
        {
            championInfoBox.IsVisible = false;
            championInfoBox.IsEnabled = false;
        }
        private void Handle_InformationClick(Object se, EventArgs ea, String champName, String type1, String type2, String type3, String icon, String ability)
        {
            championIconBox.Source = ImageSource.FromUri(new Uri("https://d1v0ze4r2jabid.cloudfront.net/characters/" + champName + ".png"));
            championNameBox.Text = champName;
            championType1Box.Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/origins/" + type1 + ".png"));
            championType2Box.Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/classes/" + type2 + ".png"));
            if (type3.Equals("None"))
            {
                championType3Box.Source = "";
            }
            else if (type3.Equals("blademaster") || type3.Equals("assassin") || type3.Equals("brawler") || type3.Equals("elementalist")
                || type3.Equals("guardian") || type3.Equals("gunslinger") || type3.Equals("knight") || type3.Equals("ranger")
                || type3.Equals("shapeshifter") || type3.Equals("sorcerer"))
            {

                championType3Box.Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/classes/" + type3 + ".png"));

            }
            else
            {
                championType3Box.Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/origins/" + type3 + ".png"));
            }
            championAbilityBox.Source = ImageSource.FromUri(new Uri("https://d1v0ze4r2jabid.cloudfront.net/abilities/" + icon + ".png"));
            championAbilityDescriptionBox.Text = ability;
            championInfoBox.IsVisible = true;
            championInfoBox.IsEnabled = true;
        }
        private void Handle_ChampionClick(Object se, EventArgs ea, string champName)
        {
            int i = 0;
            //System.Diagnostics.Debug.WriteLine("First attempt at finding the index limit");
            while(!champions[i,0].Equals(champName) && i < Variables.champCount)
            {
                i++;
            }
            /* TODO: Im gonna keep adding stack layouts to the scrollview so you can have multiple champions,
             * this will be a team builder of sorts,
             * TODO: Create a standard StackLayout that will hold the Champion Icon, Name, Recommended items, ultIcon, Ult Description,
             * and symbols for their origin/class
             */
            StackLayout championHolder = new StackLayout() {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.FromRgba(0.5, 0.5, 0.5, 0.5)
             };
            StackLayout infoHolder1 = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Margin = 10,
                Padding = 5

            };
            String tempName = champName;
            tempName.Replace(" ", "");
            tempName.Replace("'", "");
            ImageButton champIcon = new ImageButton()
            {
                Source = ImageSource.FromUri(new Uri("https://d1v0ze4r2jabid.cloudfront.net/characters/" + tempName + ".png")),
                WidthRequest = 100,
                HeightRequest = 100,
                BackgroundColor = Color.Transparent
            };
            champIcon.Clicked += (s, e) => Handle_InformationClick(s, e, champName, champions[i,2], champions[i, 3], champions[i, 4], champions[i, 5], champions[i, 6]);
            infoHolder1.Children.Add(champIcon);

            StackLayout champNameType = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                Margin = 10,
                Padding = 5
            };
            Forms9Patch.Label tempLabel = new Forms9Patch.Label()
            {
                Text = champName,
                FontAttributes = FontAttributes.Bold,
                FontSize = 28,
                MinFontSize = 10,
                TextColor = Color.White
            };
            Label championName = new Label()
            {
                Text = champName,
                FontAttributes = FontAttributes.Bold,
                FontSize = 28,
                TextColor = Color.White
            };
            /*
                This is where I am testing a new NuGet library for a label text resizer and will need to modify if this is not done correctly :)
                If done correctly I can put Miss Forturne and Zed on the same amount of lines
            */
            tempLabel.Lines = 1;
            tempLabel.AutoFit = Forms9Patch.AutoFit.Width;
            
            champNameType.Children.Add(tempLabel);
            
            StackLayout typeHolder = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Margin = 10,
                Padding = 5
            };
            Image champType1 = new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/origins/" + champions[i, 2] + ".png")),
                HeightRequest = 33,
                WidthRequest = 33
            };
            Image champType2;
            if (champions[i, 3].Equals("pirate"))
            {
                champType2 = new Image()
                {
                    Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/origins/" + champions[i, 3] + ".png")),
                    HeightRequest = 33,
                    WidthRequest = 33
                };
            }
            else
            {
                champType2 = new Image()
                {
                    Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/classes/" + champions[i, 3] + ".png")),
                    HeightRequest = 33,
                    WidthRequest = 33
                };
            }
            Image champType3 = new Image()
            {
                HeightRequest = 33,
                WidthRequest = 33
            };
            //itemContainer.Children.Clear();

            if (champions[i, 4].Equals("None")){
                champType3.Source = "";
            }
            else if (champions[i,4].Equals("blademaster") || champions[i, 4].Equals("assassin") || champions[i, 4].Equals("brawler") || champions[i, 4].Equals("elementalist")
                || champions[i, 4].Equals("guardian") || champions[i, 4].Equals("gunslinger") || champions[i, 4].Equals("Knight") || champions[i, 4].Equals("ranger")
                || champions[i, 4].Equals("shapeshifter") || champions[i, 4].Equals("sorcerer"))
            {

                champType3.Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/classes/" + champions[i,4] + ".png"));

            }
            else
            {
                champType3.Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/origins/" + champions[i, 4] + ".png"));
            }
            
            typeHolder.Children.Add(champType1);
            typeHolder.Children.Add(champType2);
            typeHolder.Children.Add(champType3);
            champNameType.Children.Add(typeHolder);
            
            ImageButton clearButton = new ImageButton()
            {
                Source = "https://img.icons8.com/plasticine/2x/close-window.png",
                WidthRequest = 30,
                HeightRequest = 35,
                VerticalOptions = LayoutOptions.Start,
                BackgroundColor = Color.Transparent,

                
            };
            clearButton.Clicked += (s, e) => Handle_ClearClick(s, e, championHolder, champName);

            infoHolder1.Children.Add(champNameType);
            infoHolder1.Children.Add(clearButton);
            /*
            StackLayout infoHolder2 = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Margin = 10,
                Padding = 5
            };
            Image abilIcon = new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://d1v0ze4r2jabid.cloudfront.net/abilities/" + champions[i, 5] + ".png")),
                WidthRequest = 50,
                HeightRequest = 50
            };
            Label abilInfo = new Label()
            {
                FontSize = 16,
                TextColor = Color.White,
                Text = champions[i,6]
            };
            infoHolder2.Children.Add(abilIcon);
            infoHolder2.Children.Add(abilInfo);
            */
            championHolder.Children.Add(infoHolder1);
            //championHolder.Children.Add(infoHolder2);

            compHolder.Children.Add(championHolder);
            //abilityIcon.Source = ImageSource.FromUri(new Uri("https://d1v0ze4r2jabid.cloudfront.net/abilities/" + champions[i,5] +".png"));

            /*Add the Suggested items here*/
        }

        private void Handle_ClearClicked(Object se, EventArgs ea)
        {
            compHolder.Children.Clear();
        }

        private void Origin()
        {
            String[] origins = 
            {
                "None", "Assassin" ,  "Blademaster" , "Brawler" , "Elementalist" ,
                "Guardian" , "Gunslinger" , "Knight" , "Ranger" ,
                "Shapeshifter" , "Sorcerer"  
            };
            createPicker("Origins" ,origins);
        }
        private void Classes()
        {
            String[] classes =
            {
                "None", "Demon", "Dragon", "Exile", "Glacial", "Imperial",  "Noble", "Ninja" , "Phantom" ,
                 "Pirate" ,  "Robot" ,  "Void",  "Wild" ,
                 "Yordle" 
            };
            createPicker("Classes",classes);
        }
        private void createPicker(String type, String[] choices)
        {
            Picker picker = new Picker()
            {
                Title = type,
                TextColor = Color.White,
                TitleColor = Color.White,
                
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Start,
                WidthRequest = App.ScreenWidth * 0.45
            };
            
            foreach (string choice in choices)
            {
                picker.Items.Add(choice);
            }

            picker.SelectedIndexChanged += (sender, args) =>
            {
                if (picker.SelectedIndex == -1)
                {
                   
                }
                else if (picker.Items[picker.SelectedIndex].Equals("None"))
                {
                    ChampionContainer.Children.Clear();
                    SetUpChampionBar();
                }
                else
                {
                    //Reload the champions in filtered form
                    ChampionContainer.Children.Clear();
                    filteredChampionBar(picker.Items[picker.SelectedIndex]);
                }
            };
            filterHolder.Children.Add(picker);
        }
    }

    public class champTypeHolder
    {
        String champType = "";
        int typeCount = 0;
        public champTypeHolder(String type, int count)
        {
            champType = type;
            typeCount = count;
        }
        void addCount()
        {
            typeCount++;
        }
        void reduceCount()
        {
            typeCount--;
        }
    }
}
//