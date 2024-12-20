using HarmonyLib;
using Unity.Mathematics;
using UnityEngine;
using Zorro.Settings;
using Zorro.Core;


namespace ExampleCWPlugin
{
    
    


    [ContentWarningPlugin("emn4tor.ItemAdder", "1.0.0", true)]
    public class Example
    {
        static Example()
        {
        }

        [HarmonyPatch(typeof(ShopViewScreen))]
        public class ShopViewScreenPatch
        {
            [HarmonyPatch("Awake"), HarmonyPostfix]
            static void AwakePatch(ShopViewScreen __instance)
            {
                Debug.Log("Starting to register items...");
                ShopCategories.Initialize();
                ShopCategories.RegisterCategory("Electronics");
                // Loop through all items in the ItemDatabase
                foreach (var item in SingletonAsset<ItemDatabase>.Instance.Objects)
                {
                    Debug.Log($"Found item: {item.displayName}");

                    if (item.displayName == "Camera")
                    {
                        item.spawnable = true;
                        item.purchasable = true;
                        item.Category = ShopItemCategory.Misc; // Use new category here
                        item.price = 100;
                        Debug.Log("Registered Camera");
                    }
                    if (item.displayName == "Radio");
                    {
                        item.spawnable = true;
                        item.purchasable = true;
                        item.Category = ShopItemCategory.Misc;
                        item.price = 100;
                        Debug.Log("Registered Radio");
                    }
                    if (item.displayName == "Walkie-talkie")
                    {
                        item.spawnable = true;
                        item.purchasable = true;
                        item.Category = ShopItemCategory.Misc;
                        item.price = 200;
                        Debug.Log("Registered WalkieTalkie");
                    }
                    if (item.displayName == "Grabber")
                    {
                        item.spawnable = true;
                        item.purchasable = true;
                        item.Category = ShopItemCategory.Misc;
                        item.price = 150;
                        Debug.Log("Registered GrabberArm");
                    }
                    if (item.displayName == "Apple")
                    {
                        item.spawnable = true;
                        item.purchasable = true;
                        item.Category = ShopItemCategory.Medical;
                        item.price = 10;
                        Debug.Log("Registered Apple");
                    }
                    if (item.displayName == "Dance 104")
                    {
                        item.spawnable = true;
                        item.purchasable = true;
                        item.Category = ShopItemCategory.Medical;
                        item.price = 200;
                        Debug.Log("Registered Dance 104");
                    }
                    if (item.displayName == "")
                    {
                        item.spawnable = true;
                        item.purchasable = true;
                        item.Category = ShopItemCategory.Misc;
                        item.price = 200;
                        Debug.Log("Registered Emote_Dance4TokTok");
                    }
                    if (item.displayName == "HardHat")
                    {
                        item.spawnable = true;
                        item.purchasable = true;
                        item.Category = ShopItemCategory.Misc;
                        item.price = 200;
                        Debug.Log("Registered HardHat");
                    }
                    if (item.displayName == "Norf Gun")
                    {
                        item.spawnable = true;
                        item.purchasable = true;
                        item.Category = ShopItemCategory.Misc;
                        item.price = 150;
                        Debug.Log("Registered NorfGun");
                    }
                    if (item.displayName == "Hermans Borkin Bag")
                    {
                        item.spawnable = true;
                        item.purchasable = true;
                        item.Category = ShopItemCategory.Medical;
                        item.price = 100;
                        Debug.Log("Registered HermansBag");
                    }
                    if (item.displayName == "FredGull")
                    {
                        item.spawnable = true;
                        item.purchasable = true;
                        item.Category = ShopItemCategory.Medical;
                        item.price = 50;
                        Debug.Log("Registered FredGull");
                    }
                    if (item.displayName == "PersistentRadio")
                    {
                        item.displayName = "Persistent Radio";
                        item.spawnable = true;
                        item.purchasable = true;
                        item.Category = ShopItemCategory.Medical;
                        item.price = 200;
                        Debug.Log("Registered PersistentRadio");
                    }
                    if (item.displayName == "SirMonsterBurger")
                    {
                        item.spawnable = true;
                        item.purchasable = true;
                        item.Category = ShopItemCategory.Misc;
                        item.price = 100;
                        Debug.Log("Registered SirMonsterBurger");
                    }
                    if (item.displayName == "Winch")
                    {
                        item.spawnable = true;
                        item.purchasable = true;
                        item.Category = ShopItemCategory.Misc;
                        item.price = 150;
                        Debug.Log("Registered Winch");
                    }
                    
                    
                }
                
            }
        }
    }
}


