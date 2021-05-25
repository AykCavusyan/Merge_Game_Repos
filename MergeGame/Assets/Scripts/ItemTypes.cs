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
        Book,
        Bracers,
        Cloak,
        Coin,
        Gem,
        Gloves,
        Helmet,
        Potion,
        Ingot


    }

    public ItemType itemType;
    public int amount;

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
}
