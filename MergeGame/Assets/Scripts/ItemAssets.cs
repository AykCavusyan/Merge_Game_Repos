using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{

    public static ItemAssets Instance { get; private set; }

    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
    }

   
    public Sprite appleSprite;
    public Sprite armorSprite;
    public Sprite axeSprite;
    public Sprite bowSprite;
    public Sprite bagSprite;
    public Sprite beltSprite;
    public Sprite bookSprite;
    public Sprite bracersSprite;
    public Sprite cloakSprite;
    public Sprite coinSprite;
    public Sprite gemSprite;
    public Sprite glovesSprite;
    public Sprite helmetSprite;
    public Sprite potionSprite;
    public Sprite ingotSprite;







}