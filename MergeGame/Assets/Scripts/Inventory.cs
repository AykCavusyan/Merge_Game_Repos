using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    private List<ItemTypes> itemList;

    public event EventHandler OnItemListChanged;

    public Inventory()
    {
        itemList = new List<ItemTypes>();
        Debug.Log("Inventory");

        AddItem(new ItemTypes { itemType = ItemTypes.ItemType.Apple, amount = 1});
        AddItem(new ItemTypes { itemType = ItemTypes.ItemType.Armor, amount = 1 });
        AddItem(new ItemTypes { itemType = ItemTypes.ItemType.Axe, amount = 1 });
        AddItem(new ItemTypes { itemType = ItemTypes.ItemType.Bag, amount = 1 });
        AddItem(new ItemTypes { itemType = ItemTypes.ItemType.Bow, amount = 1 });
        AddItem(new ItemTypes { itemType = ItemTypes.ItemType.Bow, amount = 1 });
        Debug.Log(itemList.Count);
    }

    public void  AddItem(ItemTypes item)
    {
        itemList.Add(item);
        OnItemListChanged?.Invoke(this, EventArgs.Empty);
    }

    public List<ItemTypes> GetItemList()
    {
        return itemList;
    }

  
}
