using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    LazyValue<UIýnventory> uiInventory;
    private Inventory inventory;
    [SerializeField] private ItemTypes itemTake;
    

    // Start is called before the first frame update
    void Awake()
    {
        itemTake = new ItemTypes();
        inventory = new Inventory();
        uiInventory = new LazyValue<UIýnventory>(GetUIInventory);
    }

    private UIýnventory GetUIInventory()
    {
        return GameObject.Find("UIInventory").GetComponent<UIýnventory>();
    }

    private void Start()
    {
        uiInventory.value.SetInventory(inventory);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            uiInventory.value.SetInventory(inventory);
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {

            var rndItemName = itemTake.GetRandomObject();
            Debug.Log(rndItemName);
            inventory.AddItem(new ItemTypes { itemType = rndItemName });
            
        }
    }

    // Update is called once per frame

}
