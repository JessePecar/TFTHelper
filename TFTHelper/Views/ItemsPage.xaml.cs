using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TFTHelper.Models;
using TFTHelper.Views;
using TFTHelper.ViewModels;
using Xamarin.Essentials;

namespace TFTHelper.Views
{
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        double screenMove = App.ScreenHeight * 0.7;
        Image plusSign;
        Image arrowSign;
        Image goldenSpatula;
        Image bfSword;
        Image recurveBow;
        Image needlesslyLargeRod;
        Image tearOfTheGoddess;
        Image chainVest;
        Image negatronCloak;
        Image giantsBelt;
        Image infinityEdge;
        string boxName = "";

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();

            setUpImage();
            Console.WriteLine(screenMove);
            
            
        }
        
        private void leaveScreen()
        {
            itemBox.TranslateTo(0, 0, 250, Easing.CubicInOut);
        }

        public void setUpImage()
        {
            plusSign = new Image()
            {
                Source = ImageSource.FromUri(new Uri("http://img.icons8.com/ios-glyphs/72/plus-math.png")),
                HeightRequest = 50,
                WidthRequest = 50
            };
            arrowSign = new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://img.icons8.com/android/72/arrow.png")),
                HeightRequest = 50,
                WidthRequest = 50
            };
            goldenSpatula = new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/8.png")),
                HeightRequest = 50,
                WidthRequest = 50
            };
            bfSword = new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/1.png")),
                HeightRequest = 50,
                WidthRequest = 50
            };
            recurveBow = new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/2.png")),
                HeightRequest = 50,
                WidthRequest = 50
            };
            needlesslyLargeRod = new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/3.png")),
                HeightRequest = 50,
                WidthRequest = 50
            };
            tearOfTheGoddess = new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/4.png")),
                HeightRequest = 50,
                WidthRequest = 50
            };
            chainVest = new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/5.png")),
                HeightRequest = 50,
                WidthRequest = 50
            };
            negatronCloak = new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/6.png")),
                HeightRequest = 50,
                WidthRequest = 50
            };
            giantsBelt = new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/7.png")),
                HeightRequest = 50,
                WidthRequest = 50
            };
            infinityEdge = new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/11.png")),
                HeightRequest = 50,
                WidthRequest = 50
            };
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item.
            //ItemsListView.SelectedItem = null;
        }

        async void Help_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
        private void itemSetup(String itemNum, String rec1, String rec2, String rec3, String rec4, String rec5, String rec6, String rec7, String rec8)
        {
            StackLayout[] stack = { recipe1, recipe2, recipe3, recipe4, recipe5, recipe6, recipe7, recipe8 };

            stack[0].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/" + itemNum + ".png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[1].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/" + itemNum + ".png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[2].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/" + itemNum + ".png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[3].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/" + itemNum + ".png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[4].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/" + itemNum + ".png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[5].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/" + itemNum + ".png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[6].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/" + itemNum + ".png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[7].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/" + itemNum + ".png")),
                HeightRequest = 50,
                WidthRequest = 50
            });

            /* Plus Sign is being added here*/
            stack[0].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://img.icons8.com/ios-glyphs/72/plus-math.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[1].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://img.icons8.com/ios-glyphs/72/plus-math.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[2].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://img.icons8.com/ios-glyphs/72/plus-math.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[3].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://img.icons8.com/ios-glyphs/72/plus-math.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[4].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://img.icons8.com/ios-glyphs/72/plus-math.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[5].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://img.icons8.com/ios-glyphs/72/plus-math.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[6].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://img.icons8.com/ios-glyphs/72/plus-math.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[7].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://img.icons8.com/ios-glyphs/72/plus-math.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            /* Second Item is being added here*/
            stack[0].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/1.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[1].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/2.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[2].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/3.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[3].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/4.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[4].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/5.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[5].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/6.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[6].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/7.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[7].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/8.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            /* Arrow is being added here*/
            stack[0].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://img.icons8.com/android/72/arrow.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[1].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://img.icons8.com/android/72/arrow.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[2].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://img.icons8.com/android/72/arrow.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[3].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://img.icons8.com/android/72/arrow.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[4].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://img.icons8.com/android/72/arrow.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[5].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://img.icons8.com/android/72/arrow.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[6].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://img.icons8.com/android/72/arrow.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[7].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://img.icons8.com/android/72/arrow.png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            /* Combined Item is being added here*/
            stack[0].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/" + rec1 + ".png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[1].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/" + rec2 + ".png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[2].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/" + rec3 + ".png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[3].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/" + rec4 + ".png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[4].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/" + rec5 + ".png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[5].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/" + rec6 + ".png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[6].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/" + rec7 + ".png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
            stack[7].Children.Add(new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://cdn.leagueofgraphs.com/img/tft/items/" + rec8 + ".png")),
                HeightRequest = 50,
                WidthRequest = 50
            });
        }

        private void item1Setup()
        {
            if (true)
            {
                /*This is where the information for the items will be !!*/
                combinedName1.Text = "Infinity Edge";
                combinedDesc1.Text = "Critical Strikes deal +100% more damage";

                combinedName2.Text = "Sword of the Devine";
                combinedDesc2.Text = "Each second, the wearer has a 5.0% chance to gain 100% Critical Strike";

                combinedName3.Text = "Hextech Gunblade";
                combinedDesc3.Text = "Heal for 25.0% of all damage dealt";

                combinedName4.Text = "Spear of Shojin";
                combinedDesc4.Text = "After casting ult, wearer gains 15% of its max mana per attack";

                combinedName5.Text = "Guardian Angel";
                combinedDesc5.Text = "Wearer revives with 500 Health (can stack)";

                combinedName6.Text = "Bloodthirster";
                combinedDesc6.Text = "Attacks heal for 50% of damage dealt";

                combinedName7.Text = "Zeke's Herald";
                combinedDesc7.Text = "Adjacent allies gain +10.0% Attack Speed";

                combinedName8.Text = "Youmuu's Ghostblade";
                combinedDesc8.Text = "When frontline Darius isn't scary enough, wearer is also an Assassin";
            }
        }
        
        bool boxMove = true;
        public async void Handle_Item1Click(object se, EventArgs ee)
        {
            StackLayout[] stack = { recipe1, recipe2, recipe3, recipe4, recipe5, recipe6, recipe7, recipe8 };
            if (boxMove)
            {
                itemName.Text = "B.F. Sword";
                itemDescription.Text = "+20 Attack Damage";
                item1Setup();
                itemSetup("1", "11", "12", "13", "14", "15", "16", "17", "18");
                Console.WriteLine(screenMove);
                
                boxName = "bfSwordBox";

                if (Device.RuntimePlatform == Device.Android)
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 250, Easing.CubicInOut);
                    
                }
                else
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 250, Easing.CubicInOut);
                    
                }

                boxMove = false;
            }
            else if (!boxMove && !boxName.Equals("bfSwordBox"))
            {
                await itemBox.TranslateTo(0, 0, 250, Easing.CubicInOut);

                for (int i = 0; i < 8; i++)
                {
                    stack[i].Children.Clear();
                }
                item1Setup();
                itemName.Text = "B.F. Sword";
                itemDescription.Text = "+20 Attack Damage";
                itemSetup("1", "11", "12", "13", "14", "15", "16", "17", "18");
                boxName = "bfSwordBox";

                Task.Delay(250).Wait();

                if (Device.RuntimePlatform == Device.Android)
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 500, Easing.SinIn);
                    
                }
                else
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 500, Easing.SinIn);
                    
                }
            }
            else
            {
                await itemBox.TranslateTo(0, 0, 250, Easing.CubicInOut);
                boxMove = true;
                for (int i = 0; i < 8; i++)
                {
                    stack[i].Children.Clear();
                }


            }
        }

        private void item2Setup()
        {
            if (true)
            {
                /*This is where the information for the items will be !!*/
                combinedName1.Text = "Sword of the Devine";
                combinedDesc1.Text = "Each second, the wearer has a 5.0% chance to gain 100% Critical Strike";

                combinedName2.Text = "Rapid Fire Cannon";
                combinedDesc2.Text = "Extends Range and never miss";

                combinedName3.Text = "Guinsoo's Rageblade";
                combinedDesc3.Text = "Infinitely stack attack speed";

                combinedName4.Text = "Statikk Shiv";
                combinedDesc4.Text = "Hellah magic damage every third hit";

                combinedName5.Text = "Phantom Dancer";
                combinedDesc5.Text = "Critical strikes miss with that gay shit";

                combinedName6.Text = "Cursed Sythe";
                combinedDesc6.Text = "Big scary, enemies become smaller, less scary enemies";

                combinedName7.Text = "Titanic Hydra";
                combinedDesc7.Text = "Converts 10% health to area of effect depression";

                combinedName8.Text = "Blade of the Ruined King";
                combinedDesc8.Text = "Wearer is also a Blade Master (might be good on Lulu)";
            }
        }
        public async void Handle_Item2Click(object se, EventArgs ee)
        {
            StackLayout[] stack = { recipe1, recipe2, recipe3, recipe4, recipe5, recipe6, recipe7, recipe8 };

            if (boxMove)
            {
                itemName.Text = "Recurve Bow";
                item2Setup();
                itemDescription.Text = "+15% Attack Speed";
                itemSetup("2", "12", "22", "23", "24", "25", "26", "27", "28");


                if (Device.RuntimePlatform == Device.Android)
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 250, Easing.CubicInOut);
                    boxName = "recurveBowBox";
                }
                else
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 250, Easing.CubicInOut);
                    boxName = "recurveBowBox";
                }

                boxMove = false;
            }
            else if(!boxMove && !boxName.Equals("recurveBoxBox"))
            {
                await itemBox.TranslateTo(0, 0, 250, Easing.CubicInOut);

                for (int i = 0; i < 8; i++)
                {
                    stack[i].Children.Clear();
                }
                item2Setup();
                itemName.Text = "Recurve Bow";
                itemDescription.Text = "+15% Attack Speed";
                itemSetup("2", "12", "22", "23", "24", "25", "26", "27", "28");

                Task.Delay(250).Wait();

                if (Device.RuntimePlatform == Device.Android)
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 500, Easing.SinIn);

                }
                else
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 500, Easing.SinIn);

                }
            }
            else
            {
                await itemBox.TranslateTo(0, 0, 250, Easing.CubicInOut);
                for (int i = 0; i < 8; i++)
                {
                    stack[i].Children.Clear();
                }
                boxMove = true;
                
            }
        }

        private void item3Setup()
        {
            if (true)
            {
                /*This is where the information for the items will be !!*/
                combinedName1.Text = "Hextech Gunblade";
                combinedDesc1.Text = "Heal for 25.0% of all damage dealt";

                combinedName2.Text = "Guinsoo's Rageblade";
                combinedDesc2.Text = "Infinitely stack attack speed";

                combinedName3.Text = "Rabadon's Deathcap";
                combinedDesc3.Text = "A capton of damage";

                combinedName4.Text = "Luden's Echo";
                combinedDesc4.Text = "Spells do the splashy-splash";

                combinedName5.Text = "Locket of the Iron Solari";
                combinedDesc5.Text = "Gives an Area of Effect shield on start (Yes, it stacks and is buffed by sorcerer bonus)";

                combinedName6.Text = "Ionic Spark";
                combinedDesc6.Text = "Attaches a battery to your enemies and zaps on ability usage (Bandit's kink)";

                combinedName7.Text = "Morellonomicon";
                combinedDesc7.Text = "Turns Garen into a fiery bayblade, also abilities burn";

                combinedName8.Text = "Yuumi";
                combinedDesc8.Text = "Wearer has a 100% chance of becoming a sorcerer and 100% chance of catching zoomies";
            }
        }

        public async void Handle_Item3Click(object se, EventArgs ee)
        {
            StackLayout[] stack = { recipe1, recipe2, recipe3, recipe4, recipe5, recipe6, recipe7, recipe8 };
            
            if (boxMove)
            {
                itemName.Text = "Needlessly Large Rod";
                item3Setup();
                itemDescription.Text = "+20 Spell Damage";
                boxName = "needlessBox";
                itemSetup("3", "13", "23", "33", "34", "35", "36", "37", "38");

                if (Device.RuntimePlatform == Device.Android)
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 250, Easing.CubicInOut);
                    
                }
                else
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 250, Easing.CubicInOut);
                    
                }

                boxMove = false;
            }
            else if(!boxMove && !boxName.Equals("needlessBox"))
            {
                await itemBox.TranslateTo(0, 0, 250, Easing.CubicInOut);

                for (int i = 0; i < 8; i++)
                {
                    stack[i].Children.Clear();
                }

                itemName.Text = "Needlessly Large Rod";
                item3Setup();
                itemDescription.Text = "+20 Spell Damage";
                boxName = "needlessBox";
                itemSetup("3", "13", "23", "33", "34", "35", "36", "37", "38");

                Task.Delay(250).Wait();

                if (Device.RuntimePlatform == Device.Android)
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 500, Easing.SinIn);

                }
                else
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 500, Easing.SinIn);

                }
            }
            else
            {
                await itemBox.TranslateTo(0, 0, 250, Easing.CubicInOut);
                for (int i = 0; i < 8; i++)
                {
                    stack[i].Children.Clear();
                }
                boxMove = true;
            }
        }
        private void item4Setup()
        {
            if (true)
            {
                /*This is where the information for the items will be !!*/
                combinedName1.Text = "Spear of Shojin";
                combinedDesc1.Text = "After casting ult, wearer gains 15% of its max mana per attack";

                combinedName2.Text = "Statikk Shiv";
                combinedDesc2.Text = "Every third attack does the zappy-zap";

                combinedName3.Text = "Luden's Echo";
                combinedDesc3.Text = "Abilities do the splashy-splash";

                combinedName4.Text = "Seraph's Embrace";
                combinedDesc4.Text = "Abilities refresh some mana after use, think pyke, but only stuns";

                combinedName5.Text = "Frozen Heart";
                combinedDesc5.Text = "The surrounding enemies let their attack speed go, and the movement loss never bothered them anyway";

                combinedName6.Text = "Hush Blade";
                combinedDesc6.Text = "Your enemies didnt like their ablities anyway, also they are silenced";

                combinedName7.Text = "Redemption";
                combinedDesc7.Text = "If martyrdom was less cool, heals allies not kills enemies";

                combinedName8.Text = "World Ender";
                combinedDesc8.Text = "Wearer is also a Demon, because who needs mana?";
            }
        }

        public async void Handle_Item4Click(object se, EventArgs ee)
        {
            StackLayout[] stack = { recipe1, recipe2, recipe3, recipe4, recipe5, recipe6, recipe7, recipe8 };
            
            if (boxMove)
            {
                itemName.Text = "Tear of the Goddess";
                itemSetup("4", "14", "24", "34", "44", "45", "46", "47", "48");
                itemDescription.Text = "+20 Mana";
                boxName = "tearBox";

                item4Setup();

                if (Device.RuntimePlatform == Device.Android)
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 250, Easing.CubicInOut);
                    
                }
                else
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 250, Easing.CubicInOut);
                    
                }

                boxMove = false;
            }
            else if(!boxMove && !boxName.Equals("tearBox"))
            {
                await itemBox.TranslateTo(0, 0, 250, Easing.CubicInOut);

                for (int i = 0; i < 8; i++)
                {
                    stack[i].Children.Clear();
                }

                itemName.Text = "Tear of the Goddess";

                itemDescription.Text = "+20 Mana";
                boxName = "tearBox";
                itemSetup("4", "14", "24", "34", "44", "45", "46", "47", "48");
                item4Setup();

                Task.Delay(250).Wait();

                if (Device.RuntimePlatform == Device.Android)
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 500, Easing.SinIn);

                }
                else
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 500, Easing.SinIn);

                }
            }
            else
            {
                await itemBox.TranslateTo(0, 0, 250, Easing.CubicInOut);
                for (int i = 0; i < 8; i++)
                {
                    stack[i].Children.Clear();
                }
                boxMove = true;
            }
        }

        private void item5Setup()
        {
            if (true)
            {
                /*This is where the information for the items will be !!*/
                combinedName1.Text = "Guardian Angel";
                combinedDesc1.Text = "Wearer revives with 500 Health (can stack)";

                combinedName2.Text = "Phantom Dancer";
                combinedDesc2.Text = "Critical strikes miss with that gay shit";

                combinedName3.Text = "Locket of the Iron Solari";
                combinedDesc3.Text = "Gives an Area of Effect shield on start (Yes, it stacks and is buffed by sorcerer bonus)";

                combinedName4.Text = "Frozen Heart";
                combinedDesc4.Text = "The surrounding enemies let their attack speed go, and the movement loss never bothered them anyway";

                combinedName5.Text = "Thornmail";
                combinedDesc5.Text = "Team Fight Tactics Reverse Card and Draw 2 card all in one";

                combinedName6.Text = "Sword Breaker";
                combinedDesc6.Text = "Small chance to make enemy hate themselves, also small chance to not attack";

                combinedName7.Text = "Red Buff";
                combinedDesc7.Text = "(Singing) Sets fire, to the bads, reduce their healing and laugh at them";

                combinedName8.Text = "Knight's Vow";
                combinedDesc8.Text = "Has a 100% chance to make Noble Vayne unkillable, wearer is a Knight";
            }
        }
        public async void Handle_Item5Click(object se, EventArgs ee)
        {
            StackLayout[] stack = { recipe1, recipe2, recipe3, recipe4, recipe5, recipe6, recipe7, recipe8 };
            
            if (boxMove)
            {
                itemName.Text = "Chain Vest";
                item5Setup();
                itemSetup("5", "15", "25", "35", "45", "55", "56", "57", "58");
                itemDescription.Text = "+20 Armor";
                boxName = "chainVestBox";


                if (Device.RuntimePlatform == Device.Android)
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 250, Easing.CubicInOut);
                    
                }
                else
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 250, Easing.CubicInOut);
                    
                }

                boxMove = false;
            }
            else if (!boxMove && !boxName.Equals("chainVestBox"))
            {
                await itemBox.TranslateTo(0, 0, 250, Easing.CubicInOut);

                for (int i = 0; i < 8; i++)
                {
                    stack[i].Children.Clear();
                }

                itemName.Text = "Chain Vest";
                item5Setup();
                itemDescription.Text = "+20 Armor";
                boxName = "chainVestBox";
                itemSetup("5", "15", "25", "35", "45", "55", "56", "57", "58");

                Task.Delay(250).Wait();

                if (Device.RuntimePlatform == Device.Android)
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 500, Easing.SinIn);

                }
                else
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 500, Easing.SinIn);

                }
            }
            else
            {
                await itemBox.TranslateTo(0, 0, 250, Easing.CubicInOut);
                for (int i = 0; i < 8; i++)
                {
                    stack[i].Children.Clear();
                }
                boxMove = true;
            }
        }

        private void item6Setup()
        {
            if (true)
            {
                /*This is where the information for the items will be !!*/
                combinedName1.Text = "Bloodthirster";
                combinedDesc1.Text = "Helps converting enemy's depression to your health";

                combinedName2.Text = "Cursed Scythe";
                combinedDesc2.Text = "Big scary, enemies become smaller, less scary enemies";

                combinedName3.Text = "Ionic Spark";
                combinedDesc3.Text = "Attaches a battery to your enemies and zaps on ability usage (Bandit's kink)";

                combinedName4.Text = "Hush Blade";
                combinedDesc4.Text = "Your enemies didnt like their ablities anyway, also they are silenced";

                combinedName5.Text = "Sword Breaker";
                combinedDesc5.Text = "Small chance to make enemy hate themselves, also small chance to not attack";

                combinedName6.Text = "Dragon Claw";
                combinedDesc6.Text = "Sorcerers now have depression, causing them to deal 83% less damage to wearer";

                combinedName7.Text = "Zephyr";
                combinedDesc7.Text = "Can you take me higher, to the place where I am safe? Random enemy rides tornado at start of round";

                combinedName8.Text = "Runaan's Hurricane";
                combinedDesc8.Text = "In case 1 projectile wasn't enough, you get two more, even if you are holding a sword!";
            }

        }
        public async void Handle_Item6Click(object se, EventArgs ee)
        {
            StackLayout[] stack = { recipe1, recipe2, recipe3, recipe4, recipe5, recipe6, recipe7, recipe8 };
            
            if (boxMove)
            {
                itemName.Text = "Negatron Cloak";
                itemDescription.Text = "+20 Magic Resist";
                boxName = "negatronCloakBox";
                item6Setup();
                itemSetup("6", "16", "26", "36", "46", "56", "66", "67", "68");



                if (Device.RuntimePlatform == Device.Android)
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 250, Easing.CubicInOut);
                    
                }
                else
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 250, Easing.CubicInOut);
                    
                }

                boxMove = false;
            }
            else if (!boxMove && !boxName.Equals("negatronCloakBox"))
            {
                await itemBox.TranslateTo(0, 0, 250, Easing.CubicInOut);

                for (int i = 0; i < 8; i++)
                {
                    stack[i].Children.Clear();
                }

                itemName.Text = "Negatron Cloak";
                itemDescription.Text = "+20 Magic Resist";
                boxName = "negatronCloakBox";
                item6Setup();
                itemSetup("6", "16", "26", "36", "46", "56", "66", "67", "68");

                Task.Delay(250).Wait();

                if (Device.RuntimePlatform == Device.Android)
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 500, Easing.SinIn);

                }
                else
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 500, Easing.SinIn);

                }
            }
            else
            {
                await itemBox.TranslateTo(0, 0, 250, Easing.CubicInOut);
                for (int i = 0; i < 8; i++)
                {
                    stack[i].Children.Clear();
                }
                boxMove = true;
            }
        }
        private void item7Setup()
        {
            if (true)
            {
                /*This is where the information for the items will be !!*/
                combinedName1.Text = "Zeke's Herald";
                combinedDesc1.Text = "Sad attempt at making Jarvan IV and item, gives area of effect Attack Speed at the begining of the round";

                combinedName2.Text = "Titanic Hydra";
                combinedDesc2.Text = "Converts 10% health to area of effect depression";

                combinedName3.Text = "Morellonomicon";
                combinedDesc3.Text = "Turns Garen into a fiery bayblade, also abilities burn";

                combinedName4.Text = "Redemption";
                combinedDesc4.Text = "If martyrdom was less cool, heals allies not kills enemies";

                combinedName5.Text = "Red Buff";
                combinedDesc5.Text = "(Singing) Sets fire, to the bads, reduce their healing and laugh at them";

                combinedName6.Text = "Zephyr";
                combinedDesc6.Text = "Can you take me higher, to the place where I am safe? Random enemy rides tornado at start of round";

                combinedName7.Text = "Warmog's Armor";
                combinedDesc7.Text = "Wearer announces, 'I have big gay,' then proceeds to heal percent health every second";

                combinedName8.Text = "Frozen Mallet";
                combinedDesc8.Text = "When Varus turns into an ice, cold killer... wearer is Glacial";
            }
        }

        public async void Handle_Item7Click(object se, EventArgs ee)
        {
            StackLayout[] stack = { recipe1, recipe2, recipe3, recipe4, recipe5, recipe6, recipe7, recipe8 };
            
            if (boxMove)
            {
                itemName.Text = "Giant's Belt";
                item7Setup();
                boxName = "giantsBeltBox";
                itemDescription.Text = "+200 Health";
                itemSetup("7", "17", "27", "37", "47", "57", "67", "77", "78");

                if (Device.RuntimePlatform == Device.Android)
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 250, Easing.CubicInOut);
                    
                }
                else
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 250, Easing.CubicInOut);
                    
                }

                boxMove = false;
            }
            else if(!boxMove && !boxName.Equals("giantsBeltBox"))
            {
                await itemBox.TranslateTo(0, 0, 250, Easing.CubicInOut);

                for (int i = 0; i < 8; i++)
                {
                    stack[i].Children.Clear();
                }

                itemName.Text = "Giant's Belt";
                item7Setup();
                boxName = "giantsBeltBox";
                itemDescription.Text = "+200 Health";
                itemSetup("7", "17", "27", "37", "47", "57", "67", "77", "78");

                Task.Delay(250).Wait();

                if (Device.RuntimePlatform == Device.Android)
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 500, Easing.SinIn);

                }
                else
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 500, Easing.SinIn);

                }
            }
            else
            {
                await itemBox.TranslateTo(0, 0, 250, Easing.CubicInOut);
                for (int i = 0; i < 8; i++)
                {
                    stack[i].Children.Clear();
                }
                boxMove = true;
            }
        }

        private void item8Setup()
        {
            if (true)
            {
                /*This is where the information for the items will be !!*/
                combinedName1.Text = "Youmuu's Ghostblade";
                combinedDesc1.Text = "When frontline Darius isn't scary enough, wearer is also an Assassin";

                combinedName2.Text = "Blade of the Ruined King";
                combinedDesc2.Text = "Alright, hear me out, Blademaster Pyke, with 2 Spear of Shojins...wearer is a blademaster";

                combinedName3.Text = "Yuumi";
                combinedDesc3.Text = "Wearer has a 100% chance of becoming a sorcerer and 100% chance of catching zoomies";

                combinedName4.Text = "World Ender";
                combinedDesc4.Text = "Wearer is also a demon, because who needs mana?";

                combinedName5.Text = "Knight's Vow";
                combinedDesc5.Text = "Has a 100% chance to make Noble Vayne unkillable, wearer is a Knight";

                combinedName6.Text = "Runaan's Hurricane";
                combinedDesc6.Text = "In case 1 projectile wasn't enough, you get two more, even if you are holding a sword!";

                combinedName7.Text = "Frozen Mallet";
                combinedDesc7.Text = "When Varus turns into an ice, cold killer... wearer is Glacial";

                combinedName8.Text = "Force of Nature";
                combinedDesc8.Text = "When you want a small army but you are only level 5. Gives you the ability to play 1 extra champion";
            }
        }
        public async void Handle_Item8Click(object se, EventArgs ee)
        {
            StackLayout[] stack = { recipe1, recipe2, recipe3, recipe4, recipe5, recipe6, recipe7, recipe8 };
            
            if (boxMove)
            {
                itemName.Text = "Golden Spatula";
                item8Setup();
                itemDescription.Text = "This item must do something...";
                boxName = "goldenSpatulaBox";
                itemSetup("8", "18", "28", "38", "48", "58", "68", "78", "88");



                if (Device.RuntimePlatform == Device.Android)
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 250, Easing.CubicInOut);
                }
                else
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 250, Easing.CubicInOut);
                }

                boxMove = false;
            }
            else if (!boxMove && !boxName.Equals("goldenSpatulaBox"))
            {
                await itemBox.TranslateTo(0, 0, 250, Easing.CubicInOut);

                for (int i = 0; i < 8; i++)
                {
                    stack[i].Children.Clear();
                }

                itemName.Text = "Golden Spatula";
                item8Setup();
                itemDescription.Text = "This item must do something...";
                boxName = "goldenSpatulaBox";
                itemSetup("8", "18", "28", "38", "48", "58", "68", "78", "88");

                Task.Delay(250).Wait();

                if (Device.RuntimePlatform == Device.Android)
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 500, Easing.SinIn);

                }
                else
                {
                    await itemBox.TranslateTo(0, (int)-screenMove, 500, Easing.SinIn);

                }
            }
            else
            {
                await itemBox.TranslateTo(0, 0, 250, Easing.CubicInOut);
                for (int i = 0; i < 8; i++)
                {
                    stack[i].Children.Clear();
                }
                boxMove = true; 
            }
        }
    }
}