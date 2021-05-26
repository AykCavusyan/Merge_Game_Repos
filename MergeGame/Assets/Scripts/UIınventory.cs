using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIınventory : MonoBehaviour
{
    private Inventory inventory;
    //private Transform itemSlotContainer;
    //private Transform itemSlotTemplate;
    LazyValue<Transform> itemSlotContainer;
    LazyValue<Transform> itemSlotTemplate;

    private void Awake()
    {
        itemSlotContainer = new LazyValue<Transform>(GetItemSlotContainer);
        itemSlotTemplate = new LazyValue<Transform>(GetItemSlotTemplate);
        //itemSlotContainer = transform.Find("itemSlotContainer");
        //itemSlotTemplate = itemSlotContainer.value.Find("itemSlotTemplate");
    }

    public Transform GetItemSlotContainer()
    {
        return transform.Find("itemSlotContainer");    
    }
    public Transform GetItemSlotTemplate()
    {
        return itemSlotContainer.value.Find("itemSlotTemplate");
    }

    private void Start()
    {
        
    }


    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
        inventory.OnItemListChanged += Inventory_OnItemListChanged;
        RefreshInventoryItems();
    }

    private void Inventory_OnItemListChanged(object sender, EventArgs e)
    {
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems()
    {
        int x = 0;
        int y = 0;
        float itemSlotCellSize = 30f;

        foreach(ItemTypes item in inventory.GetItemList())
        {
            
            RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplate.value, itemSlotContainer.value).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
            Image image = itemSlotRectTransform.Find("Image").GetComponent<Image>();
            image.sprite = item.GetSprite();
            
            
            x++;
            if (x > 4)
            {
                x = 0;
                y--;
            }
        }
    }



}
