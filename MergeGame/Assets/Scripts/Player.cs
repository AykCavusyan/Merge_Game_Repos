using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private UIýnventory uiInventory;
    private Inventory inventory;

    // Start is called before the first frame update
    void Awake()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
    }

    private void Start()
    {
        //uiInventory.SetInventory(inventory);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            uiInventory.SetInventory(inventory);
        }
    }

    // Update is called once per frame

}
