using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemTypes
{
    public enum ItemType
    {
        Apple,
        Armor,
        Axe,
        Bow,
        Bag,
        Belt,
        


    }

    public ItemType itemType;
    public int amount;
    
    void Start()
    {
        ItemType rndItemType = (ItemType)Random.Range(0, 3);
    }

    public Sprite GetSprite()
    {
        switch (itemType) { default:

            case ItemType.Apple:  return ItemAssets.Instance.appleSprite;
            case ItemType.Armor:  return ItemAssets.Instance.armorSprite;
            case ItemType.Axe:    return ItemAssets.Instance.axeSprite;
            case ItemType.Bow:    return ItemAssets.Instance.bowSprite;
            case ItemType.Bag:    return ItemAssets.Instance.bagSprite;
            case ItemType.Belt:   return ItemAssets.Instance.beltSprite;

        }
    }

    public ItemType GetRandomObject()
    {
        var enumLenght = System.Enum.GetNames(typeof(ItemType)).Length;
        return  (ItemType)Random.Range(0, enumLenght);
        
    }

  


}
