using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    private List<ItemTypes> itemList; 

    public Inventory()
    {
        itemList = new List<ItemTypes>();
        Debug.Log("Inventory");

        AddItem(new ItemTypes { itemType = ItemTypes.ItemType.Apple, amount = 1});
        AddItem(new ItemTypes { itemType = ItemTypes.ItemType.Armor, amount = 1 });
        AddItem(new ItemTypes { itemType = ItemTypes.ItemType.Axe, amount = 1 });
        AddItem(new ItemTypes { itemType = ItemTypes.ItemType.Bag, amount = 1 });
        AddItem(new ItemTypes { itemType = ItemTypes.ItemType.Bow, amount = 1 });
        AddItem(new ItemTypes { itemType = ItemTypes.ItemType.Gem, amount = 1 });
        Debug.Log(itemList.Count);
    }

    public void  AddItem(ItemTypes item)
    {
        itemList.Add(item);
    }

    public List<ItemTypes> GetItemList()
    {
        return itemList;
    }
}
